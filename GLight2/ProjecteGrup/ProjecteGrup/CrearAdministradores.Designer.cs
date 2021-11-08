
namespace ProjecteGrup
{
    partial class CrearAdministradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItemCrearAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItemCrearAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelNombreAdmin = new System.Windows.Forms.Label();
            this.labelApellidoAdmin = new System.Windows.Forms.Label();
            this.labelUserNameAdmin = new System.Windows.Forms.Label();
            this.labelPasswordAdmin = new System.Windows.Forms.Label();
            this.textBoxNombreAdmin = new System.Windows.Forms.TextBox();
            this.textBoxApellidoAdmin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameAdmin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAdmin = new System.Windows.Forms.TextBox();
            this.buttonAnadirAdmin = new System.Windows.Forms.Button();
            this.dataGridViewAdmins = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNamee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModificarAdmin = new System.Windows.Forms.Button();
            this.buttonSalirAdmin = new System.Windows.Forms.Button();
            this.buttonBorrarAdmin = new System.Windows.Forms.Button();
            this.labelRuta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItemCrearAdmin,
            this.salirToolStripMenuItemCrearAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripCrearAdmin";
            // 
            // opcionesToolStripMenuItemCrearAdmin
            // 
            this.opcionesToolStripMenuItemCrearAdmin.Name = "opcionesToolStripMenuItemCrearAdmin";
            this.opcionesToolStripMenuItemCrearAdmin.Size = new System.Drawing.Size(69, 22);
            this.opcionesToolStripMenuItemCrearAdmin.Text = "Opciones";
            // 
            // salirToolStripMenuItemCrearAdmin
            // 
            this.salirToolStripMenuItemCrearAdmin.Name = "salirToolStripMenuItemCrearAdmin";
            this.salirToolStripMenuItemCrearAdmin.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItemCrearAdmin.Text = "Salir";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 31);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(244, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "En este apartado se pueden crear administradores";
            // 
            // labelNombreAdmin
            // 
            this.labelNombreAdmin.AutoSize = true;
            this.labelNombreAdmin.Location = new System.Drawing.Point(79, 65);
            this.labelNombreAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreAdmin.Name = "labelNombreAdmin";
            this.labelNombreAdmin.Size = new System.Drawing.Size(44, 13);
            this.labelNombreAdmin.TabIndex = 2;
            this.labelNombreAdmin.Text = "Nombre";
            // 
            // labelApellidoAdmin
            // 
            this.labelApellidoAdmin.AutoSize = true;
            this.labelApellidoAdmin.Location = new System.Drawing.Point(79, 87);
            this.labelApellidoAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellidoAdmin.Name = "labelApellidoAdmin";
            this.labelApellidoAdmin.Size = new System.Drawing.Size(44, 13);
            this.labelApellidoAdmin.TabIndex = 3;
            this.labelApellidoAdmin.Text = "Apellido";
            // 
            // labelUserNameAdmin
            // 
            this.labelUserNameAdmin.AutoSize = true;
            this.labelUserNameAdmin.Location = new System.Drawing.Point(79, 109);
            this.labelUserNameAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserNameAdmin.Name = "labelUserNameAdmin";
            this.labelUserNameAdmin.Size = new System.Drawing.Size(96, 13);
            this.labelUserNameAdmin.TabIndex = 4;
            this.labelUserNameAdmin.Text = "Nombre de usuario";
            // 
            // labelPasswordAdmin
            // 
            this.labelPasswordAdmin.AutoSize = true;
            this.labelPasswordAdmin.Location = new System.Drawing.Point(79, 131);
            this.labelPasswordAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordAdmin.Name = "labelPasswordAdmin";
            this.labelPasswordAdmin.Size = new System.Drawing.Size(61, 13);
            this.labelPasswordAdmin.TabIndex = 5;
            this.labelPasswordAdmin.Text = "Contraseña";
            // 
            // textBoxNombreAdmin
            // 
            this.textBoxNombreAdmin.Location = new System.Drawing.Point(204, 63);
            this.textBoxNombreAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreAdmin.Name = "textBoxNombreAdmin";
            this.textBoxNombreAdmin.Size = new System.Drawing.Size(173, 20);
            this.textBoxNombreAdmin.TabIndex = 6;
            // 
            // textBoxApellidoAdmin
            // 
            this.textBoxApellidoAdmin.Location = new System.Drawing.Point(204, 85);
            this.textBoxApellidoAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellidoAdmin.Name = "textBoxApellidoAdmin";
            this.textBoxApellidoAdmin.Size = new System.Drawing.Size(173, 20);
            this.textBoxApellidoAdmin.TabIndex = 7;
            // 
            // textBoxUserNameAdmin
            // 
            this.textBoxUserNameAdmin.Location = new System.Drawing.Point(204, 107);
            this.textBoxUserNameAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUserNameAdmin.Name = "textBoxUserNameAdmin";
            this.textBoxUserNameAdmin.Size = new System.Drawing.Size(173, 20);
            this.textBoxUserNameAdmin.TabIndex = 8;
            // 
            // textBoxPasswordAdmin
            // 
            this.textBoxPasswordAdmin.Location = new System.Drawing.Point(204, 129);
            this.textBoxPasswordAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswordAdmin.Name = "textBoxPasswordAdmin";
            this.textBoxPasswordAdmin.Size = new System.Drawing.Size(173, 20);
            this.textBoxPasswordAdmin.TabIndex = 9;
            // 
            // buttonAnadirAdmin
            // 
            this.buttonAnadirAdmin.Location = new System.Drawing.Point(204, 151);
            this.buttonAnadirAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnadirAdmin.Name = "buttonAnadirAdmin";
            this.buttonAnadirAdmin.Size = new System.Drawing.Size(50, 20);
            this.buttonAnadirAdmin.TabIndex = 10;
            this.buttonAnadirAdmin.Text = "Añadir";
            this.buttonAnadirAdmin.UseVisualStyleBackColor = true;
            this.buttonAnadirAdmin.Click += new System.EventHandler(this.buttonAnadirAdmin_Click);
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.AllowUserToAddRows = false;
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.UserNamee,
            this.Password});
            this.dataGridViewAdmins.Location = new System.Drawing.Point(11, 175);
            this.dataGridViewAdmins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.RowHeadersWidth = 62;
            this.dataGridViewAdmins.RowTemplate.Height = 28;
            this.dataGridViewAdmins.Size = new System.Drawing.Size(443, 127);
            this.dataGridViewAdmins.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Name";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Surname";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // UserNamee
            // 
            this.UserNamee.DataPropertyName = "UserName";
            this.UserNamee.HeaderText = "User Name";
            this.UserNamee.MinimumWidth = 8;
            this.UserNamee.Name = "UserNamee";
            this.UserNamee.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Contraseña";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // buttonModificarAdmin
            // 
            this.buttonModificarAdmin.Location = new System.Drawing.Point(262, 151);
            this.buttonModificarAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificarAdmin.Name = "buttonModificarAdmin";
            this.buttonModificarAdmin.Size = new System.Drawing.Size(55, 20);
            this.buttonModificarAdmin.TabIndex = 12;
            this.buttonModificarAdmin.Text = "Modificar";
            this.buttonModificarAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonSalirAdmin
            // 
            this.buttonSalirAdmin.Location = new System.Drawing.Point(204, 318);
            this.buttonSalirAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalirAdmin.Name = "buttonSalirAdmin";
            this.buttonSalirAdmin.Size = new System.Drawing.Size(50, 23);
            this.buttonSalirAdmin.TabIndex = 13;
            this.buttonSalirAdmin.Text = "Salir";
            this.buttonSalirAdmin.UseVisualStyleBackColor = true;
            this.buttonSalirAdmin.Click += new System.EventHandler(this.buttonSalirAdmin_Click);
            // 
            // buttonBorrarAdmin
            // 
            this.buttonBorrarAdmin.Location = new System.Drawing.Point(325, 151);
            this.buttonBorrarAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBorrarAdmin.Name = "buttonBorrarAdmin";
            this.buttonBorrarAdmin.Size = new System.Drawing.Size(50, 20);
            this.buttonBorrarAdmin.TabIndex = 14;
            this.buttonBorrarAdmin.Text = "Borrar";
            this.buttonBorrarAdmin.UseVisualStyleBackColor = true;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Location = new System.Drawing.Point(259, 31);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(30, 13);
            this.labelRuta.TabIndex = 15;
            this.labelRuta.Text = "Ruta";
            // 
            // CrearAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(468, 352);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.buttonBorrarAdmin);
            this.Controls.Add(this.buttonSalirAdmin);
            this.Controls.Add(this.buttonModificarAdmin);
            this.Controls.Add(this.dataGridViewAdmins);
            this.Controls.Add(this.buttonAnadirAdmin);
            this.Controls.Add(this.textBoxPasswordAdmin);
            this.Controls.Add(this.textBoxUserNameAdmin);
            this.Controls.Add(this.textBoxApellidoAdmin);
            this.Controls.Add(this.textBoxNombreAdmin);
            this.Controls.Add(this.labelPasswordAdmin);
            this.Controls.Add(this.labelUserNameAdmin);
            this.Controls.Add(this.labelApellidoAdmin);
            this.Controls.Add(this.labelNombreAdmin);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearAdministradores";
            this.Load += new System.EventHandler(this.CrearAdministradores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItemCrearAdmin;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItemCrearAdmin;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelNombreAdmin;
        private System.Windows.Forms.Label labelApellidoAdmin;
        private System.Windows.Forms.Label labelUserNameAdmin;
        private System.Windows.Forms.Label labelPasswordAdmin;
        private System.Windows.Forms.TextBox textBoxNombreAdmin;
        private System.Windows.Forms.TextBox textBoxApellidoAdmin;
        private System.Windows.Forms.TextBox textBoxUserNameAdmin;
        private System.Windows.Forms.TextBox textBoxPasswordAdmin;
        private System.Windows.Forms.Button buttonAnadirAdmin;
        private System.Windows.Forms.DataGridView dataGridViewAdmins;
        private System.Windows.Forms.Button buttonModificarAdmin;
        private System.Windows.Forms.Button buttonSalirAdmin;
        private System.Windows.Forms.Button buttonBorrarAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNamee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label labelRuta;
    }
}