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
    public partial class JuegoAdmin : Form
    {
        BindingList<Pregunta> generoMusical1 = new BindingList<Pregunta>();
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
            String gender = "";
            String dificult = "";
            String respuesta1 = textBoxResposta1.Text;
            String respuesta2 = textBoxResposta2.Text;
            String respuesta3 = textBoxResposta3.Text;
            String respuesta4 = textBoxResposta4.Text;
            bool isTrueRes1 = false;
            bool isTrueRes2 = false;
            bool isTrueRes3 = false;
            bool isTrueRes4 = false;
            List<Respuesta> Respuestas = new List<Respuesta>();
            Respuesta primera, segunda, tercera, cuarta;
            Pregunta preguntaConRespuestas;

            dificult = SeleccionarDificultadPregunta(dificult);

            gender = SeleccionarGenero(gender);

            isTrueRes1 = ControlPrimeraRespuesta(isTrueRes1);
            isTrueRes2 = ControlSegundaRespuesta(isTrueRes2);
            isTrueRes3 = ControlTerceraRespuesta(isTrueRes3);
            isTrueRes4 = ControlCuartaPregunta(isTrueRes4);
            if (isTrueRes1 == false && isTrueRes2 == false && isTrueRes3 == false && isTrueRes4 == false)
            {
                MessageBox.Show("Todas las respuestas son falsas,debe haber una sola correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isTrueRes1 == true && isTrueRes2 == true && isTrueRes3 == true && isTrueRes4 == true)
            {
                MessageBox.Show("Todas las respuestas son ciertas, debe haber una sola correcta y las demás falsas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                primera = ObtenerObjetoRespuesta(respuesta1, isTrueRes1);
                segunda = ObtenerObjetoRespuesta(respuesta2, isTrueRes2);
                tercera = ObtenerObjetoRespuesta(respuesta3, isTrueRes3);
                cuarta = ObtenerObjetoRespuesta(respuesta4, isTrueRes4);
                Respuestas = AnadirLista(primera, segunda, tercera, cuarta);
                preguntaConRespuestas = new Pregunta(pregunta, Respuestas, dificult, gender);
                generoMusical1.Add(preguntaConRespuestas);
                dataGridView1.DataSource = generoMusical1;

                LimpiarFormulario();
            }
        }

        private void LimpiarFormulario()
        {
            textBoxPregunta.Text = "";
            textBoxResposta1.Text = "";
            textBoxResposta2.Text = "";
            textBoxResposta3.Text = "";
            textBoxResposta4.Text = "";
        }

        private string SeleccionarGenero(string gender)
        {
            if (radioButtonRock.Checked == true)
            {
                gender = radioButtonRock.Text;
            }
            else if (radioButtonHeavy.Checked == true)
            {
                gender = radioButtonHeavy.Text;

            }
            else if (radioButtonPop.Checked == true)
            {
                gender = radioButtonPop.Text;

            }
            else if (radioButtonRap.Checked == true)
            {
                gender = radioButtonRap.Text;

            }
            else if (radioButtonFunk.Checked == true)
            {
                gender = radioButtonFunk.Text;

            }

            return gender;
        }

        private string SeleccionarDificultadPregunta(string dificul)
        {
            string dificult;
            if (radioButtonFacil.Checked == true)
            {
                dificult = "Facil";
            }
            else if (radioButtonMedio.Checked == true)
            {
                dificult = "Medio";
            }
            else
            {
                dificult = "Dificil";
            }

            return dificult;
        }

        private bool ControlCuartaPregunta(bool isTrueRes4)
        {
            if (radioButtonCiertoCuarto.Checked == true)
            {
                isTrueRes4 = true;
            }
            else if (radioButtonFalsoCuarto.Checked == true)
            {
                isTrueRes4 = false;
            }

            return isTrueRes4;
        }

        private bool ControlTerceraRespuesta(bool isTrueRes3)
        {
            if (radioButtonCiertoTercero.Checked == true)
            {
                isTrueRes3 = true;
            }
            else if (radioButtonFalsoTercero.Checked == true)
            {
                isTrueRes3 = false;
            }

            return isTrueRes3;
        }

        private bool ControlSegundaRespuesta(bool isTrueRes2)
        {
            if (radioButtonCiertoSegundo.Checked == true)
            {
                isTrueRes2 = true;
            }
            else if (radioButtonFalsoSegundo.Checked == true)
            {
                isTrueRes2 = false;
            }

            return isTrueRes2;
        }

        private bool ControlPrimeraRespuesta(bool isTrueRes1)
        {
            if (radioButtonCiertoPrimero.Checked == true)
            {
                isTrueRes1 = true;
            }
            else if (radioButtonFalsoPrimero.Checked == true)
            {
                isTrueRes1 = false;
            }

            return isTrueRes1;
        }

        private static Respuesta ObtenerObjetoRespuesta(string respuesta, bool isTrueRes)
        {
            Respuesta respuestaGuardar = new Respuesta(respuesta, isTrueRes);
            return respuestaGuardar;
        }

        private static List<Respuesta> AnadirLista(Respuesta a, Respuesta b, Respuesta c, Respuesta d)
        {
            List<Respuesta> respuestas = new List<Respuesta>();
            respuestas.Add(a);
            respuestas.Add(b);
            respuestas.Add(c);
            respuestas.Add(d);

            return respuestas;
        }

        private static Pregunta ObtenerObjetoPregunta(String pregunta, List<Respuesta> respuestas, String dificult, String gender) 
        {
            Pregunta preguntaGuardar = new Pregunta(pregunta, respuestas, dificult, gender);
            return preguntaGuardar;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
