    
namespace AsesoriasPascualBravo
{
    partial class Menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnCrearCitas = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarCitas = new FontAwesome.Sharp.IconButton();
            this.btnConsultarCitas = new FontAwesome.Sharp.IconButton();
            this.btnAgendarCitas = new FontAwesome.Sharp.IconButton();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnCrearCitas);
            this.panelMenu.Controls.Add(this.btnVisualizarCitas);
            this.panelMenu.Controls.Add(this.btnConsultarCitas);
            this.panelMenu.Controls.Add(this.btnAgendarCitas);
            this.panelMenu.Controls.Add(this.btnRegistro);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 514);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.DarkGray;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrearCitas
            // 
            this.btnCrearCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCitas.FlatAppearance.BorderSize = 0;
            this.btnCrearCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCitas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCitas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCrearCitas.IconChar = FontAwesome.Sharp.IconChar.RulerCombined;
            this.btnCrearCitas.IconColor = System.Drawing.Color.DarkGray;
            this.btnCrearCitas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCrearCitas.IconSize = 32;
            this.btnCrearCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCitas.Location = new System.Drawing.Point(0, 340);
            this.btnCrearCitas.Name = "btnCrearCitas";
            this.btnCrearCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCrearCitas.Size = new System.Drawing.Size(200, 40);
            this.btnCrearCitas.TabIndex = 6;
            this.btnCrearCitas.Text = "Crear Asignatura";
            this.btnCrearCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCitas.UseVisualStyleBackColor = true;
            this.btnCrearCitas.Click += new System.EventHandler(this.btnCrearCitas_Click);
            // 
            // btnVisualizarCitas
            // 
            this.btnVisualizarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizarCitas.FlatAppearance.BorderSize = 0;
            this.btnVisualizarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarCitas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCitas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnVisualizarCitas.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.btnVisualizarCitas.IconColor = System.Drawing.Color.DarkGray;
            this.btnVisualizarCitas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnVisualizarCitas.IconSize = 32;
            this.btnVisualizarCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarCitas.Location = new System.Drawing.Point(0, 300);
            this.btnVisualizarCitas.Name = "btnVisualizarCitas";
            this.btnVisualizarCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVisualizarCitas.Size = new System.Drawing.Size(200, 40);
            this.btnVisualizarCitas.TabIndex = 5;
            this.btnVisualizarCitas.Text = "Visualizar Agenda";
            this.btnVisualizarCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizarCitas.UseVisualStyleBackColor = true;
            this.btnVisualizarCitas.Click += new System.EventHandler(this.btnVisualizarCitas_Click);
            // 
            // btnConsultarCitas
            // 
            this.btnConsultarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarCitas.FlatAppearance.BorderSize = 0;
            this.btnConsultarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCitas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCitas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnConsultarCitas.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnConsultarCitas.IconColor = System.Drawing.Color.DarkGray;
            this.btnConsultarCitas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConsultarCitas.IconSize = 32;
            this.btnConsultarCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCitas.Location = new System.Drawing.Point(0, 260);
            this.btnConsultarCitas.Name = "btnConsultarCitas";
            this.btnConsultarCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultarCitas.Size = new System.Drawing.Size(200, 40);
            this.btnConsultarCitas.TabIndex = 4;
            this.btnConsultarCitas.Text = "Consultar Citas";
            this.btnConsultarCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarCitas.UseVisualStyleBackColor = true;
            this.btnConsultarCitas.Click += new System.EventHandler(this.btnConsultarCitas_Click);
            // 
            // btnAgendarCitas
            // 
            this.btnAgendarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarCitas.FlatAppearance.BorderSize = 0;
            this.btnAgendarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCitas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCitas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgendarCitas.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAgendarCitas.IconColor = System.Drawing.Color.DarkGray;
            this.btnAgendarCitas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgendarCitas.IconSize = 32;
            this.btnAgendarCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarCitas.Location = new System.Drawing.Point(0, 220);
            this.btnAgendarCitas.Name = "btnAgendarCitas";
            this.btnAgendarCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgendarCitas.Size = new System.Drawing.Size(200, 40);
            this.btnAgendarCitas.TabIndex = 3;
            this.btnAgendarCitas.Text = "Agendar Citas";
            this.btnAgendarCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendarCitas.UseVisualStyleBackColor = true;
            this.btnAgendarCitas.Click += new System.EventHandler(this.btnAgendarCitas_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.btnRegistro.IconColor = System.Drawing.Color.DarkGray;
            this.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRegistro.IconSize = 32;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 180);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegistro.Size = new System.Drawing.Size(200, 40);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnLogin.IconColor = System.Drawing.Color.DarkGray;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::AsesoriasPascualBravo.Properties.Resources.UIPascualBravo;
            this.btnHome.Location = new System.Drawing.Point(23, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 112);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(634, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 13);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 23);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(42, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 65);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(634, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 73);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(634, 441);
            this.panelDesktop.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 514);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asesorias UI Pascual Bravo";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCrearCitas;
        private FontAwesome.Sharp.IconButton btnVisualizarCitas;
        private FontAwesome.Sharp.IconButton btnConsultarCitas;
        private FontAwesome.Sharp.IconButton btnAgendarCitas;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

