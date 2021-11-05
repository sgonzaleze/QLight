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

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Equals("") ||  textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Debes poner un nombre y una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxExclamacion1.Visible = true;
                pictureBoxExclamacion2.Visible = true;
                pictureBoxExclamacion3.Visible = true;
                labelError.Visible = true;
            }else if (!textBoxUser.Text.Equals(pepe.UserName) || !textBoxPassword.Text.Equals(pepe.Password)) {
                MessageBox.Show("El nombre de usuario o contraseña no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxExclamacion1.Visible = true;
                pictureBoxExclamacion2.Visible = true;
                pictureBoxExclamacion3.Visible = true;
                labelError.Visible = true;
            }
            if (textBoxUser.Text.Equals(pepe.UserName) && textBoxPassword.Text.Equals(pepe.Password))
            {
                MessageBox.Show("Bienvenido, " + pepe.Name, "Mensaje", MessageBoxButtons.OK);
                pictureBoxExclamacion1.Visible = false;
                pictureBoxExclamacion2.Visible = false;
                pictureBoxExclamacion3.Visible = false;
                labelError.Visible = false;
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
                MenuAdmin a = new MenuAdmin(pepe);
                a.ShowDialog();
            }
            
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
