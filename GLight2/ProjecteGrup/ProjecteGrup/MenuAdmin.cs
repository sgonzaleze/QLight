﻿using System;
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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            DateTime fechaEntrada = DateTime.UtcNow;
            labelSesion.Text = Convert.ToString(fechaEntrada);
        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void añadirPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuegoAdmin f = new JuegoAdmin();

            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void personajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personatges p = new Personatges();
            p.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptarJuego_Click(object sender, EventArgs e)
        {
            JuegoAdmin a = new JuegoAdmin();
            a.ShowDialog();
        }

        private void labelSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
