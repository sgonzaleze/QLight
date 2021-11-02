using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteGrup
{
    public partial class Personatges : Form
    {
        public Personatges()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin();
            ma.ShowDialog();

        }
    }
}
