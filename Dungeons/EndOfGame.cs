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
    public partial class EndOfGame : Form
    {
        Menu menu = new Menu();

        public EndOfGame()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            menu.Restart();
            this.Close();
            menu.ShowDialog();
        }
    }
}
