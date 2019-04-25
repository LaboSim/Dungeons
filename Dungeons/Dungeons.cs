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
           
            setTheVisibilityOfTheItemOnTheBoard();

            Control itemControl = null;
            chooseItemToDisplay(itemControl);

            setClearEquipItem();
            checkInventory();
            setNoneItemInInventory();
            
            choosenItem();

            checkTheStatusOfItemOnTheBoard(chooseItemToDisplay(itemControl));

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
            overallNumberOfMoves.Text = "Overall number of moves: " + PlayerStatistics.MovePlayer;
            overallNumberOfAttacks.Text = "Overall number of attacks: " + PlayerStatistics.AttackPlayer;
            overallNumberOfAttacksSuccessful.Text = "Overall number of attack successful: " +
                PlayerStatistics.SuccessfulAttackPlayer;
        }

        private void checkTheStatusOfItemOnTheBoard(Control itemControl)
        {
            itemControl.Location = game.ItemInRoom.Location;
            if (game.ItemInRoom.PickedUp)
                itemControl.Visible = false;
            else
                itemControl.Visible = true;
        }

        private Control chooseItemToDisplay(Control itemControl)
        {
            switch (game.ItemInRoom.Name)
            {
                case "Sword":
                    {
                        itemControl = sword30;
                        break;
                    }
                case "Bow":
                    {
                        itemControl = bow30;
                        break;
                    }
                case "Mace":
                    {
                        itemControl = mace30;
                        break;
                    }
                case "Blue potion":
                    {
                        itemControl = bluePotion30;
                        break;
                    }
                case "Red potion":
                    {
                        itemControl = redPotion30;
                        break;
                    }
                case "Battle axe":
                    {
                        itemControl = battleAxe30;
                        break;
                    }
                case "Quiver":
                    {
                        itemControl = quiver30;
                        break;
                    }
                case "Shield":
                    {
                        itemControl = shield30;
                        break;
                    }
                case "Bomb":
                    {
                        itemControl = bomb30;
                        break;
                    }
            }
            itemControl.Visible = true;
            return itemControl;
        }

        private void countEnemies(int enemiesShown)
        {
            if (game.Level == 18)
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

        private void setTheVisibilityOfTheItemOnTheBoard()
        {
            sword30.Visible = false;
            bow30.Visible = false;
            mace30.Visible = false;
            bluePotion30.Visible = false;
            redPotion30.Visible = false;
            battleAxe30.Visible = false;
            quiver30.Visible = false;
            shield30.Visible = false;
            bomb30.Visible = false;
        }

        private void setNoneItemInInventory()
        {
            equipSword.BorderStyle = BorderStyle.None;
            equipBow.BorderStyle = BorderStyle.None;
            equipMace.BorderStyle = BorderStyle.None;
            equipBluePotion.BorderStyle = BorderStyle.None;
            equipRedPotion.BorderStyle = BorderStyle.None;
            equipBattleAxe.BorderStyle = BorderStyle.None;
            equipQuiver.BorderStyle = BorderStyle.None;
            equipShield.BorderStyle = BorderStyle.None;
            equipBomb.BorderStyle = BorderStyle.None;
        }

        private void setClearEquipItem()
        {
            equipWeaponSword.Visible = false;
            equipWeaponBow.Visible = false;
            equipWeaponMace.Visible = false;
            equipWeaponBluePotion.Visible = false;
            equipWeaponRedPotion.Visible = false;
            equipWeaponBattleAxe.Visible = false;
            equipWeaponQuiver.Visible = false;
            equipWeaponShield.Visible = false;
            equipWeaponBomb.Visible = false;
        }

        private void choosenItem()
        {
            if(game.ChoosenItemByPlayer() == "Sword")
            {
                equipSword.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponSword.Visible = true;
                setTheVisibilityOfButtons();
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Bow")
            {
                equipBow.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBow.Visible = true;
                setTheVisibilityOfButtons();
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Mace")
            {
                equipMace.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponMace.Visible = true;
                setTheVisibilityOfButtons();
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Blue potion")
            {
                equipBluePotion.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBluePotion.Visible = true;
                setTheVisibilityOfButtons();
                drinkButton.Visible = true;
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Red potion")
            {
                equipRedPotion.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponRedPotion.Visible = true;
                setTheVisibilityOfButtons();
                drinkButton.Visible = true;
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Battle axe")
            {
                equipBattleAxe.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBattleAxe.Visible = true;
                setTheVisibilityOfButtons();
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Quiver")
            {
                equipQuiver.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponQuiver.Visible = true;
                setTheVisibilityOfButtons();
                quiverButton.Visible = true;
                TabAttackManager(true);
            }
            else if(game.ChoosenItemByPlayer() == "Shield")
            {
                equipShield.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponShield.Visible = true;
                setTheVisibilityOfButtons();
                TabAttackManager(false);
            }
            else if(game.ChoosenItemByPlayer() == "Bomb")
            {
                equipBomb.BorderStyle = BorderStyle.FixedSingle;
                equipWeaponBomb.Visible = true;
                setTheVisibilityOfButtons();
                blowButton.Visible = true;
                TabAttackManager(true);
            }
        }

        private void setTheVisibilityOfButtons()
        {
            drinkButton.Visible = false;
            quiverButton.Visible = false;
            blowButton.Visible = false;
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

            if (game.CheckPlayerInventory("Bomb"))
                equipBomb.Visible = true;

            if (game.CheckPlayerInventory("Shield"))
            {
                equipShield.Visible = true;
                pointShield.Visible = true;
                pointShield.Text = game.PointsOfArmour.ToString();
            }
            else
            {
                equipShield.Visible = false;
                pointShield.Visible = false;
            }
               
        }

        private void TabAttackManager(bool value)
        {
            ((Control)this.tabPage2).Enabled = value;
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
            string potion = game.ChoosenItemByPlayer();

            if (game.UseDisposable(random))
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
            if (game.UseDisposable(random))
            {
                UpdateCharacters();
                quiverButton.Visible = false;
                equipQuiver.Visible = false;
            }
        }

        private void equipShield_Click(object sender, EventArgs e)
        {
            game.Equip("Shield");
            UpdateCharacters();
        }

        private void equipBomb_Click(object sender, EventArgs e)
        {
            game.Equip("Bomb");
            UpdateCharacters();
        }

        private void blowButton_Click(object sender, EventArgs e)
        {
            if (game.DetonateBomb(random))
            {
                UpdateCharacters();
                blowButton.Visible = false;
                equipBomb.Visible = false;
            }
        }
    }
}
