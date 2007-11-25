using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyndicateNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutSyndicateNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyndicateNet.GUI.About about = new SyndicateNet.GUI.About();
            about.Show();
        }
    }
}
