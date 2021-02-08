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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void Change_Load(object sender, EventArgs e)
        {
            SecretW.Text = Form1.secretword;
        }

        private void changetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                Form1.secretword = changetb.Text;
            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            Form1.secretword = changetb.Text;
            SecretW.Text = Form1.secretword;
        }
    }
}
