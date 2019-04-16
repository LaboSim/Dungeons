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
    public partial class EndOfGameForm : Form
    {
        Menu menu = new Menu();
        int counter = 5;

        public EndOfGameForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void StartTimer()
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            menu.Restart();
            this.Close();
            menu.ShowDialog();
        }

        private void EndOfGame_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Stop();
            if (e.KeyCode == Keys.Space)
                ShowMainMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if(counter == 0)
            {
                timer1.Stop();
                ShowMainMenu();
            }

        }
    }
}
