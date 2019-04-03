using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dungeons
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void quitGame_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Exit();

            if(startGame.Text == "START GAME (S)")
            {
                if (e.KeyCode == Keys.S)
                    this.Close();
            }
            else
            {
                if (e.KeyCode == Keys.R)
                    Application.Restart();
            }
        }

        private void Exit()
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Thread.Sleep(1500);
                Application.Exit();
            }
        }

        public void Restart()
        {
            startGame.Text = "RESTART (R)";
        }
    }
}
