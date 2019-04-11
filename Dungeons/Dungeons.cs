using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons
{
    public partial class DungeonsForm : Form
    {
        private Game game;
        private Random random = new Random();
        Menu menu = new Menu();
        EndOfGameForm endOfGame = new EndOfGameForm();
        bool checkVisibilityStats = true;

        public DungeonsForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            player30.Visible = true;
            CenterToScreen();
            this.Show();
            menu.ShowDialog();
        }

        private void Dungeons_Load(object sender, EventArgs e)
        {
            //70(left), 50(up), 420(right), 139(bottom)
            //78, 57, 420, 155
            game = new Game(new Rectangle(70, 50, 420, 145));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            int enemiesShown;
            UpdatePlayer();
            enemiesShown = UpdateEnemies();
           
            setTheVisibilityOfTheWeaponOnTheBoard();

            Control weaponControl = null;
            chooseWeaponToDisplay(weaponControl);

            setClearEquipWeapon();
            checkInventory();
            setNoneWeaponInInventory();
            
            choosenWeapon();

            checkTheStatusOfWeaponOnTheBoard(chooseWeaponToDisplay(weaponControl));

            checkHitPoints(game.PlayerHitPoints);
            countEnemies(enemiesShown);               
        }

        private int UpdateEnemies()
        {
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            bool showWizard = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat30.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints >= 1)
                    {
                        showBat = true;                        
                        enemiesShown++;
                    }
                    showEnemies(showBat, enemy);
                }
                else if(enemy is Ghost)
                {
                    ghost30.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints >= 1)
                    {
                        showGhost = true;                        
                        enemiesShown++;
                    }
                    showEnemies(showGhost, enemy);
                }
                else if(enemy is Ghoul)
                {
                    ghoul30.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints >= 1)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                    showEnemies(showGhoul, enemy);
                }
                else if(enemy is Wizard)
                {
                    wizard30.Location = enemy.Location;
                    wizardHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints >= 1)
                    {
                        showWizard = true;
                        enemiesShown++;
                    }
                    showEnemies(showWizard, enemy);
                }
            }
            return enemiesShown;
        }

        private void showEnemies(bool showEnemy, Enemy enemy)
        {
                if(enemy is Bat)
                {
                    if (showEnemy)
                        bat30.Visible = true;                   
                    else
                    {
                        bat30.Visible = false;
                        batHitPoints.Text = "";
                    }
                }
                if(enemy is Ghost)
                {
                    if (showEnemy)
                        ghost30.Visible = true;                      
                    else
                    {
                        ghost30.Visible = false;
                        ghostHitPoints.Text = "";
                    }
                }
                if(enemy is Ghoul)
                {
                    if (showEnemy)
                        ghoul30.Visible = true;                   
                    else
                    {
                        ghoul30.Visible = false;
                        ghoulHitPoints.Text = "";
                    }
                }
                if(enemy is Wizard)
                {
                    if (showEnemy)
                        wizard30.Visible = true;
                    else
                    {
                        wizard30.Visible = false;
                        wizardHitPoints.Text = "";
                    }

                }
        }

        private void UpdatePlayer()
        {
            player30.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            overallNumberOfMoves.Text = "Overall number of moves: " + game.NumberOfPlayerMoves.ToString();
            overallNumberOfAttacks.Text = "Overall number of attacks: " + game.NumberOfAttack.ToString();
            overallNumberOfAttacksSuccessful.Text = "Overall number of attack successful: " +
                game.NumberOfAttackSuccessful.ToString();
        }

        private void checkTheStatusOfWeaponOnTheBoard(Control weaponControl)
        {
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
        }

        private Control chooseWeaponToDisplay(Control weaponControl)
        {
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    {
                        weaponControl = sword30;
                        break;
                    }
                case "Bow":
                    {
                        weaponControl = bow30;
                        break;
                    }
                case "Mace":
                    {
                        weaponControl = mace30;
                        break;
                    }
                case "Blue potion":
                    {
                        weaponControl = bluePotion30;
                        break;
                    }
                case "Red potion":
                    {
                        weaponControl = redPotion30;
                        break;
                    }
                case "Battle axe":
                    {
                        weaponControl = battleAxe30;
                        break;
                    }
                case "Quiver":
                    {
                        weaponControl = quiver30;
                        break;
                    }
                case "Shield":
                    {
                        weaponControl = shield30;
                        break;
                    }
            }
            weaponControl.Visible = true;
            return weaponControl;
        }

        private void countEnemies(int enemiesShown)
        {
            if (game.Level == 9)
                FinishTheGame();

            else
            {
                if (enemiesShown < 1)
                {
                    MessageBox.Show("You defeated all of enemies at this level", "Great Job");
                    game.NewLevel(random);
                    UpdateCharacters();
                    actualLevel.Text = "Level " + game.Level.ToString();
                }
            }           
        }

        private void FinishTheGame()
        {
            endOfGame.StartTimer();
            endOfGame.ShowDialog();
        }

        private void checkHitPoints(int playerHitPoints)
        {
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You have been killed", "Opsss");
                menu.Restart();
                menu.ShowDialog();
            }
        }

        private void setTheVisibilityOfTheWeaponOnTheBoard()
        {
            sword30.Visible = false;
            bow30.Visible = false;
            mace30.Visible = false;
            bluePotion30.Visible = false;
            redPotion30.Visible = false;
            battleAxe30.Visible = false;
            quiver30.Visible = false;
            shield30.Visible = false;
        }

        private void setNoneWeaponInInventory()
        {
            equipSword.BorderStyle = BorderStyle.None;
            equipBow.BorderStyle = BorderStyle.None;
            equipMace.BorderStyle = BorderStyle.None;
            equipBluePotion.BorderStyle = BorderStyle.None;
            equipRedPotion.BorderStyle = BorderStyle.None;
            equipBattleAxe.BorderStyle = BorderStyle.None;
            equipQuiver.BorderStyle = BorderStyle.None;
            equipShield.BorderStyle = BorderStyle.None;
        }

        private void setClearEquipWeapon()
        {
            equipWeaponSword.Visible = false;
            equipWeaponBow.Visible = false;
            equipWeaponMace.Visible = false;
            equipWeaponBluePotion.Visible = false;
            equipWeaponRedPotion.Visible = false;
            equipWeaponBattleAxe.Visible = false;
            equipWeaponQuiver.Visible = false;
            equipWeaponShield.Visible = false;
        }

        private void choosenWeapon()
        {
            if(game.choosenWeaponByPlayer() == "Sword")
            {
                equipSword.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponSword.Visible = true;
                setTheVisibilityOfButtons();
            }
            else if(game.choosenWeaponByPlayer() == "Bow")
            {
                equipBow.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBow.Visible = true;
                setTheVisibilityOfButtons();
            }
            else if(game.choosenWeaponByPlayer() == "Mace")
            {
                equipMace.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponMace.Visible = true;
                setTheVisibilityOfButtons();
            }
            else if(game.choosenWeaponByPlayer() == "Blue potion")
            {
                equipBluePotion.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBluePotion.Visible = true;
                setTheVisibilityOfButtons();
                drinkButton.Visible = true;
            }
            else if(game.choosenWeaponByPlayer() == "Red potion")
            {
                equipRedPotion.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponRedPotion.Visible = true;
                setTheVisibilityOfButtons();
                drinkButton.Visible = true;
            }
            else if(game.choosenWeaponByPlayer() == "Battle axe")
            {
                equipBattleAxe.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBattleAxe.Visible = true;
                setTheVisibilityOfButtons();
            }
            else if(game.choosenWeaponByPlayer() == "Quiver")
            {
                equipQuiver.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponQuiver.Visible = true;
                setTheVisibilityOfButtons();
                quiverButton.Visible = true;
            }
            else if(game.choosenWeaponByPlayer() == "Shield")
            {
                equipShield.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponShield.Visible = true;
                setTheVisibilityOfButtons();
            }
        }

        private void setTheVisibilityOfButtons()
        {
            drinkButton.Visible = false;
            quiverButton.Visible = false;
        }

        private void checkInventory()
        {
            if (game.CheckPlayerInventory("Sword"))
                equipSword.Visible = true;

            if (game.CheckPlayerInventory("Bow"))
            {
                equipBow.Visible = true;
                CheckArrows();               
            }

            if (game.CheckPlayerInventory("Mace"))
                equipMace.Visible = true;

            if (game.CheckPlayerInventory("Blue potion"))
                equipBluePotion.Visible = true;

            if (game.CheckPlayerInventory("Red potion"))
                equipRedPotion.Visible = true;

            if (game.CheckPlayerInventory("Battle axe"))
                equipBattleAxe.Visible = true;

            if (game.CheckPlayerInventory("Quiver"))
                equipQuiver.Visible = true;

            if (game.CheckPlayerInventory("Shield"))
            {
                equipShield.Visible = true;
                pointShield.Visible = true;
                pointShield.Text = game.PointOfShield().ToString();
                Console.WriteLine(game.PointOfShield());
            }
            else
            {
                equipShield.Visible = false;
                pointShield.Visible = false;
            }
               
        }

        private void CheckArrows()
        {
            numberOfArrows.Visible = true;

            if (game.CheckNumberOfArrows() == 0)
            {
                equipBow.Enabled = false;
                numberOfArrows.Enabled = false;
            }
            else
            {
                equipBow.Enabled = true;
                numberOfArrows.Enabled = true;
            }
            numberOfArrows.Text = game.CheckNumberOfArrows().ToString();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void equipSword_Click(object sender, EventArgs e)
        {
            game.Equip("Sword");
            UpdateCharacters();
        }

        private void equipBow_Click(object sender, EventArgs e)
        {
            game.Equip("Bow");
            UpdateCharacters();
        }

        private void equipMace_Click(object sender, EventArgs e)
        {
            game.Equip("Mace");
            UpdateCharacters();
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            string potion = game.choosenWeaponByPlayer();

            game.Attack(Direction.Up, random);
            if (game.CheckUsedDisposable())
            {
                UpdateCharacters();
                drinkButton.Visible = false;
                setVisibilityEquipPotion(potion);
            }
        }

        private void setVisibilityEquipPotion(string potion)
        {
            if (potion == "Blue potion")
                equipBluePotion.Visible = false;
            else
                equipRedPotion.Visible = false;
        }

        private void equipBluePotion_Click(object sender, EventArgs e)
        {
            game.Equip("Blue potion");
            UpdateCharacters();
        }

        private void equipRedPotion_Click(object sender, EventArgs e)
        {
            game.Equip("Red potion");
            UpdateCharacters();
        }

        private void Dungeons_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.M)
                menu.ShowDialog();
            else if(e.KeyCode == Keys.V)
                VisibilityStatistics();
        }

        private void VisibilityStatistics()
        {
            if (checkVisibilityStats)
                offVisibilityStats();
            else
                onVisibilityStats();
        }

        private void onVisibilityStats()
        {
            checkVisibilityStats = true;
            overallNumberOfMoves.Visible = true;
            overallNumberOfAttacks.Visible = true;
            overallNumberOfAttacksSuccessful.Visible = true;
            visibilityStats.Visible = false;
        }

        private void offVisibilityStats()
        {
            checkVisibilityStats = false;
            overallNumberOfMoves.Visible = false;
            overallNumberOfAttacks.Visible = false;
            overallNumberOfAttacksSuccessful.Visible = false;
            visibilityStats.Visible = true;
        }

        private void visibilityStats_Click(object sender, EventArgs e)
        {
            VisibilityStatistics();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabPage1)
            {
                moveLabel.Visible = true;
                attackLabel.Visible = false;
            }
            else
            {
                moveLabel.Visible = false;
                attackLabel.Visible = true;
            }
        }

        private void equipBattleAxe_Click(object sender, EventArgs e)
        {
            game.Equip("Battle axe");
            UpdateCharacters();
        }

        private void equipQuiver_Click(object sender, EventArgs e)
        {
            game.Equip("Quiver");
            UpdateCharacters();
        }

        private void quiverButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            if (game.CheckUsedDisposable())
            {
                UpdateCharacters();
                quiverButton.Visible = false;
                equipQuiver.Visible = false;
            }
        }

        private void equipShield_Click(object sender, EventArgs e)
        {
            game.Equip("Shield");
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }
    }
}
