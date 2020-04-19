using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("Created by FAFAFA");
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Drawer20x20 Drawer = new Drawer20x20();
            Drawer.Show();
        }
    }
}
