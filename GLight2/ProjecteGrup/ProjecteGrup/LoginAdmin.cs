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

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Equals("") ||  textBoxPassword.Text.Equals(""))
            {
                pictureBoxExclamacion1.Visible = true;
                pictureBoxExclamacion2.Visible = true;
                pictureBoxExclamacion3.Visible = true;
                labelError.Visible = true;
            }
            else
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.ShowDialog();

                pictureBoxExclamacion1.Visible = false;
                pictureBoxExclamacion2.Visible = false;
                pictureBoxExclamacion3.Visible = false;
                labelError.Visible = false;
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
