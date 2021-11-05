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

        private void Personatges_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(UserPoints >= 0)
            {
                pictureBoxImatges.Image = Properties.Resources.metallica;
            }
            else if(UserPoints >= 300)
            {
                pictureBoxImatges.Image = Properties.Resources.nirvana;
            }
            else if (UserPoints >= 550)
            {
                pictureBoxImatges.Image = Properties.Resources.acdc;
            }
            else if (UserPoints >= 800)
            {
                pictureBoxImatges.Image = Properties.Resources.beatles;
            }
        }

        private void heavyMetalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserPoints >= 0)
            {
                pictureBoxImatges.Image = Properties.Resources.blacksabbath;
            }
            else if (UserPoints >= 300)
            {
                pictureBoxImatges.Image = Properties.Resources.judaspriest;
            }
            else if (UserPoints >= 550)
            {
                pictureBoxImatges.Image = Properties.Resources.ironmaiden;
            }
            else if (UserPoints >= 800)
            {
                pictureBoxImatges.Image = Properties.Resources.rollingstones;
            }
        }

        private void popToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserPoints >= 0)
            {
                pictureBoxImatges.Image = Properties.Resources.dualipa;
            }
            else if (UserPoints >= 300)
            {
                pictureBoxImatges.Image = Properties.Resources.edsheran;
            }
            else if (UserPoints >= 550)
            {
                pictureBoxImatges.Image = Properties.Resources.arianagranded;
            }
            else if (UserPoints >= 800)
            {
                pictureBoxImatges.Image = Properties.Resources.michaeljackson;
            }
        }

        private void rapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserPoints >= 0)
            {
                pictureBoxImatges.Image = Properties.Resources._2pac;
            }
            else if (UserPoints >= 300)
            {
                pictureBoxImatges.Image = Properties.Resources.snoopdogg;
            }
            else if (UserPoints >= 550)
            {
                pictureBoxImatges.Image = Properties.Resources._50cent;
            }
            else if (UserPoints >= 800)
            {
                pictureBoxImatges.Image = Properties.Resources.eminem;
            }
        }

        private void funkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserPoints >= 0)
            {
                pictureBoxImatges.Image = Properties.Resources.sandrasa;
            }
            else if (UserPoints >= 300)
            {
                pictureBoxImatges.Image = Properties.Resources.brunomars;
            }
            else if (UserPoints >= 550)
            {
                pictureBoxImatges.Image = Properties.Resources.larryblackmon;
            }
            else if (UserPoints >= 800)
            {
                pictureBoxImatges.Image = Properties.Resources.jamesbrown;
            }
        }
    }
}
