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

        public EndOfGameForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
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
            if (e.KeyCode == Keys.Space)
                ShowMainMenu();
        }       
    }
}
