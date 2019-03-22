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
    public partial class Dungeons : Form
    {
        private Game game;
        private Random random = new Random();

        public Dungeons()
        {
            InitializeComponent();
            player30.Visible = true;
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
            player30.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    bat30.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints >= 1)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat)
                bat30.Visible = true;
            else
            {
                bat30.Visible = false;
                batHitPoints.Text = "";
            }
                
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
    }
}
