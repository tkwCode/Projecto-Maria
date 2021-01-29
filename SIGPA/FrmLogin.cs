using System;
using System.Windows.Forms;

namespace SIGPA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin( )
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            bool logar = true;

            if (logar)
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
        }
    }
}
