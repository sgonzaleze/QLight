
namespace ProjecteGrup
{
    partial class LoginAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxExclamacion1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExclamacion2 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxExclamacion3 = new System.Windows.Forms.PictureBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(57, 87);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(29, 20);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 0;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(57, 128);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(29, 20);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 1;
            this.pictureBoxPassword.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUser.Location = new System.Drawing.Point(135, 87);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(183, 20);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "User";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPassword.Location = new System.Drawing.Point(135, 127);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(183, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(161, 166);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(138, 38);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(161, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(138, 59);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login";
            this.labelLogin.UseCompatibleTextRendering = true;
            // 
            // pictureBoxExclamacion1
            // 
            this.pictureBoxExclamacion1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExclamacion1.Image")));
            this.pictureBoxExclamacion1.Location = new System.Drawing.Point(408, 79);
            this.pictureBoxExclamacion1.Name = "pictureBoxExclamacion1";
            this.pictureBoxExclamacion1.Size = new System.Drawing.Size(33, 28);
            this.pictureBoxExclamacion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExclamacion1.TabIndex = 7;
            this.pictureBoxExclamacion1.TabStop = false;
            this.pictureBoxExclamacion1.Visible = false;
            // 
            // pictureBoxExclamacion2
            // 
            this.pictureBoxExclamacion2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExclamacion2.Image")));
            this.pictureBoxExclamacion2.Location = new System.Drawing.Point(408, 119);
            this.pictureBoxExclamacion2.Name = "pictureBoxExclamacion2";
            this.pictureBoxExclamacion2.Size = new System.Drawing.Size(33, 28);
            this.pictureBoxExclamacion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExclamacion2.TabIndex = 8;
            this.pictureBoxExclamacion2.TabStop = false;
            this.pictureBoxExclamacion2.Visible = false;
            // 
            // labelError
            // 
            this.labelError.Location = new System.Drawing.Point(185, 224);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(129, 28);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "El usuario o la contraseña son incorrectos";
            this.labelError.UseWaitCursor = true;
            this.labelError.Visible = false;
            // 
            // pictureBoxExclamacion3
            // 
            this.pictureBoxExclamacion3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExclamacion3.Image")));
            this.pictureBoxExclamacion3.Location = new System.Drawing.Point(135, 224);
            this.pictureBoxExclamacion3.Name = "pictureBoxExclamacion3";
            this.pictureBoxExclamacion3.Size = new System.Drawing.Size(33, 28);
            this.pictureBoxExclamacion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExclamacion3.TabIndex = 10;
            this.pictureBoxExclamacion3.TabStop = false;
            this.pictureBoxExclamacion3.Visible = false;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(324, 127);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(42, 17);
            this.checkBoxPassword.TabIndex = 11;
            this.checkBoxPassword.Text = "Ver";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            this.checkBoxPassword.Click += new System.EventHandler(this.checkBoxPassword_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(453, 275);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.pictureBoxExclamacion3);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureBoxExclamacion2);
            this.Controls.Add(this.pictureBoxExclamacion1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Name = "LoginAdmin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExclamacion3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxExclamacion1;
        private System.Windows.Forms.PictureBox pictureBoxExclamacion2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxExclamacion3;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}

