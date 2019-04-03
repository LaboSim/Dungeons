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
            Thread.Sleep(1500);
            Application.Exit();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
