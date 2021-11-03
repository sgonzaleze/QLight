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
    public partial class JuegoAdmin : Form
    {
        public JuegoAdmin()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {


   
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin();

            ma.ShowDialog();
        }

        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personatges p = new Personatges();
            p.ShowDialog();

        }
    }
}
