using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace useless_guessing_game
{
    public partial class Form1 : Form
    {
        public static string secretword = "asdf";

        public Form1()
        {
            InitializeComponent();
        }

        private void checker()
        {
            if (guess_tb.Text == secretword)
            {
                MessageBox.Show("you win");
            }
            else
            {
                MessageBox.Show("you lose");
            }
        }

        private void guess_btn_Click(object sender, EventArgs e)
        {
            checker();
        }

        private void guess_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checker();
            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            Change changesw = new Change();
            changesw.Show();
        }
    }
}
