﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGPA
{
    public partial class FrmMain : Form
    {
        public FrmMain( )
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            if (MessageBox.Show("Deseja realmente sair?", Application.ProductName, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        private void sairToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FrmMain_FormClosing(this, null);
        }
    }
}
