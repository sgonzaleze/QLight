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

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            String pregunta = textBoxPregunta.Text;
            String respuesta1 = textBoxResposta1.Text;
            String respuesta2 = textBoxResposta2.Text;
            String respuesta3 = textBoxResposta3.Text;
            String respuesta4 = textBoxResposta4.Text;
            bool isTrueRes1 = false;
            bool isTrueRes2 = false;
            bool isTrueRes3 = false;
            bool isTrueRes4 = false;
            List<Respuesta> Respuestas = new List<Respuesta>();

            if (radioButtonCiertoPrimero.Checked == true)
            {
                isTrueRes1 = true;
            }
            else if (radioButtonFalsoPrimero.Checked == true)
            {
                isTrueRes1 = false;
            }
            if (radioButtonCiertoSegundo.Checked == true)
            {
                isTrueRes2 = true;
            }
            else if (radioButtonFalsoSegundo.Checked == true)
            {
                isTrueRes2 = false;
            }
            if (radioButtonCiertoTercero.Checked == true)
            {
                isTrueRes3 = true;
            }
            else if (radioButtonFalsoTercero.Checked == true)
            {
                isTrueRes3 = false;
            }
            if (radioButtonCiertoCuarto.Checked == true)
            {
                isTrueRes4 = true;
            }
            else if (radioButtonFalsoCuarto.Checked == true)
            {
                isTrueRes4 = false;
            }

            ObtenerObjetoRespuesta(respuesta1, isTrueRes1);
            ObtenerObjetoRespuesta(respuesta2, isTrueRes2);
            ObtenerObjetoRespuesta(respuesta3, isTrueRes3);
            ObtenerObjetoRespuesta(respuesta4, isTrueRes4);

        }

        private static Respuesta ObtenerObjetoRespuesta(string respuesta, bool isTrueRes)
        {
            Respuesta respuestaGuardar = new Respuesta(respuesta, isTrueRes);
            return respuestaGuardar;
        }
    }
}
