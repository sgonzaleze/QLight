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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }
        SuperAdministrador pepe = new SuperAdministrador("Josep", "Guiu", "contrapepe", "jguius");
        Administrador sergio = new Administrador("Sergio", "Gonzalez", "contra", "usuSergio");
        //static BindingList<Administrador> listaAdministradores = new BindingList<Administrador>();
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Equals("") ||  textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Debes poner un nombre y una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarIconosError();
            }
            if (textBoxUser.Text.Equals(pepe.UserName) && !textBoxPassword.Text.Equals(pepe.Password)) {
                MessageBox.Show("El nombre de usuario o contraseña no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarIconosError();
            }
            if (textBoxUser.Text.Equals(sergio.UserName) && !textBoxPassword.Text.Equals(sergio.Password))
            {
                MessageBox.Show("El nombre de usuario o contraseña no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarIconosError();
            }
            if (textBoxUser.Text.Equals(pepe.UserName) && textBoxPassword.Text.Equals(pepe.Password))
            {
                MessageBox.Show("Bienvenido, " + pepe.Name, "Mensaje", MessageBoxButtons.OK);
                NoMostrarIconosError();
                LimpiarLogin();
                MenuAdmin a = new MenuAdmin(pepe);
                a.ShowDialog();
            }
            if (textBoxUser.Text.Equals(sergio.UserName) && textBoxPassword.Text.Equals(sergio.Password))
            {
                MessageBox.Show("Bienvenido, " + sergio.Name, "Mensaje", MessageBoxButtons.OK);
                NoMostrarIconosError();
                LimpiarLogin();
                MenuAdminBasico a = new MenuAdminBasico(sergio);
                a.ShowDialog();
            }

        }

        private void LimpiarLogin()
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
        }

        private void NoMostrarIconosError()
        {
            pictureBoxExclamacion1.Visible = false;
            pictureBoxExclamacion2.Visible = false;
            pictureBoxExclamacion3.Visible = false;
            labelError.Visible = false;
        }

        private void MostrarIconosError()
        {
            pictureBoxExclamacion1.Visible = true;
            pictureBoxExclamacion2.Visible = true;
            pictureBoxExclamacion3.Visible = true;
            labelError.Visible = true;
        }

        public static void AgregarAdministradorLista(BindingList<Administrador> x)
        {
            //listaAdministradores = x;
        }
        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
