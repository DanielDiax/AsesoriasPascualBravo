    
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pbPascualBravo = new System.Windows.Forms.PictureBox();
            this.btnMinus = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionarAsignaturas = new FontAwesome.Sharp.IconButton();
            this.btnConsultarAsesorias = new FontAwesome.Sharp.IconButton();
            this.btnCrearAsesoria = new FontAwesome.Sharp.IconButton();
            this.btnConsultarCitas = new FontAwesome.Sharp.IconButton();
            this.btnAgendarCitas = new FontAwesome.Sharp.IconButton();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPascualBravo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnSeleccionarAsignaturas);
            this.panelMenu.Controls.Add(this.btnConsultarAsesorias);
            this.panelMenu.Controls.Add(this.btnCrearAsesoria);
            this.panelMenu.Controls.Add(this.btnConsultarCitas);
            this.panelMenu.Controls.Add(this.btnAgendarCitas);
            this.panelMenu.Controls.Add(this.btnRegistro);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 599);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.lblPerfil);
            this.panelTitleBar.Controls.Add(this.lblApellidoUsuario);
            this.panelTitleBar.Controls.Add(this.lblNombreUsuario);
            this.panelTitleBar.Controls.Add(this.btnMinus);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(825, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AccessibleName = "";
            this.lblPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.lblPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPerfil.Location = new System.Drawing.Point(251, 22);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(56, 23);
            this.lblPerfil.TabIndex = 9;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AccessibleName = "lblApellidoUsuario";
            this.lblApellidoUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.lblApellidoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lblApellidoUsuario.Location = new System.Drawing.Point(491, 23);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblApellidoUsuario.TabIndex = 8;
            this.lblApellidoUsuario.Text = "Apellido";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AccessibleName = "lblNombreUsuario";
            this.lblNombreUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNombreUsuario.Location = new System.Drawing.Point(381, 23);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(77, 23);
            this.lblNombreUsuario.TabIndex = 7;
            this.lblNombreUsuario.Text = "Nombre";
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
            this.panelShadow.Size = new System.Drawing.Size(825, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelDesktop.Controls.Add(this.panelLogin);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.pbPascualBravo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 73);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(825, 526);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.materialDivider2);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.materialDivider1);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.materialLabel1);
            this.panelLogin.Controls.Add(this.iconButton1);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Location = new System.Drawing.Point(252, 94);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(321, 339);
            this.panelLogin.TabIndex = 5;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(60, 115);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(195, 2);
            this.materialDivider2.TabIndex = 9;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(61, 167);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(195, 2);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(60, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(129, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 18);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Login";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(58, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "E-Mail";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 526);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AsesoriasPascualBravo.Properties.Resources.cropped_Institucion_Pascual_Bravo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.iconButton1.IconColor = System.Drawing.Color.DarkGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(58, 200);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(189, 40);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Iniciar Sesión";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pbPascualBravo
            // 
            this.pbPascualBravo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPascualBravo.BackColor = System.Drawing.Color.White;
            this.pbPascualBravo.Image = global::AsesoriasPascualBravo.Properties.Resources.cropped_Institucion_Pascual_Bravo_Logo;
            this.pbPascualBravo.Location = new System.Drawing.Point(81, 107);
            this.pbPascualBravo.Name = "pbPascualBravo";
            this.pbPascualBravo.Size = new System.Drawing.Size(655, 181);
            this.pbPascualBravo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPascualBravo.TabIndex = 9;
            this.pbPascualBravo.TabStop = false;
            this.pbPascualBravo.Visible = false;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMinus.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.DarkGray;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 15;
            this.btnMinus.Location = new System.Drawing.Point(756, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(15, 15);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(777, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 15);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.DarkGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(798, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(0, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(200, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionarAsignaturas
            // 
            this.btnSeleccionarAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeleccionarAsignaturas.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarAsignaturas.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarAsignaturas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarAsignaturas.IconChar = FontAwesome.Sharp.IconChar.RulerCombined;
            this.btnSeleccionarAsignaturas.IconColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarAsignaturas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSeleccionarAsignaturas.IconSize = 32;
            this.btnSeleccionarAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarAsignaturas.Location = new System.Drawing.Point(0, 380);
            this.btnSeleccionarAsignaturas.Name = "btnSeleccionarAsignaturas";
            this.btnSeleccionarAsignaturas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSeleccionarAsignaturas.Size = new System.Drawing.Size(200, 40);
            this.btnSeleccionarAsignaturas.TabIndex = 8;
            this.btnSeleccionarAsignaturas.Text = "Seleccionar Asignaturas";
            this.btnSeleccionarAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarAsignaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarAsignaturas.UseVisualStyleBackColor = true;
            this.btnSeleccionarAsignaturas.Visible = false;
            this.btnSeleccionarAsignaturas.Click += new System.EventHandler(this.btnSeleccionarAsignaturas_Click);
            // 
            // btnConsultarAsesorias
            // 
            this.btnConsultarAsesorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarAsesorias.FlatAppearance.BorderSize = 0;
            this.btnConsultarAsesorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAsesorias.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAsesorias.ForeColor = System.Drawing.Color.DarkGray;
            this.btnConsultarAsesorias.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnConsultarAsesorias.IconColor = System.Drawing.Color.DarkGray;
            this.btnConsultarAsesorias.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConsultarAsesorias.IconSize = 32;
            this.btnConsultarAsesorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAsesorias.Location = new System.Drawing.Point(0, 340);
            this.btnConsultarAsesorias.Name = "btnConsultarAsesorias";
            this.btnConsultarAsesorias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsultarAsesorias.Size = new System.Drawing.Size(200, 40);
            this.btnConsultarAsesorias.TabIndex = 6;
            this.btnConsultarAsesorias.Text = "ConsultarAsesorias";
            this.btnConsultarAsesorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAsesorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarAsesorias.UseVisualStyleBackColor = true;
            this.btnConsultarAsesorias.Visible = false;
            this.btnConsultarAsesorias.Click += new System.EventHandler(this.btnConsultarAsesorias_Click);
            // 
            // btnCrearAsesoria
            // 
            this.btnCrearAsesoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearAsesoria.FlatAppearance.BorderSize = 0;
            this.btnCrearAsesoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAsesoria.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAsesoria.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCrearAsesoria.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnCrearAsesoria.IconColor = System.Drawing.Color.DarkGray;
            this.btnCrearAsesoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCrearAsesoria.IconSize = 32;
            this.btnCrearAsesoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAsesoria.Location = new System.Drawing.Point(0, 300);
            this.btnCrearAsesoria.Name = "btnCrearAsesoria";
            this.btnCrearAsesoria.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCrearAsesoria.Size = new System.Drawing.Size(200, 40);
            this.btnCrearAsesoria.TabIndex = 5;
            this.btnCrearAsesoria.Text = "Crear Asesoria";
            this.btnCrearAsesoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAsesoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearAsesoria.UseVisualStyleBackColor = true;
            this.btnCrearAsesoria.Visible = false;
            this.btnCrearAsesoria.Click += new System.EventHandler(this.btnCrearAsesoria_Click);
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
            this.btnConsultarCitas.Visible = false;
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
            this.btnAgendarCitas.Visible = false;
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
            this.btnLogin.Visible = false;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 599);
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
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPascualBravo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMinus;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton btnConsultarAsesorias;
        public FontAwesome.Sharp.IconButton btnCrearAsesoria;
        public FontAwesome.Sharp.IconButton btnConsultarCitas;
        public FontAwesome.Sharp.IconButton btnAgendarCitas;
        public FontAwesome.Sharp.IconButton btnRegistro;
        public FontAwesome.Sharp.IconButton btnLogin;
        public System.Windows.Forms.Label lblApellidoUsuario;
        public System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel panelLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.TextBox txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbPascualBravo;
        public System.Windows.Forms.Label lblPerfil;
        public FontAwesome.Sharp.IconButton btnSeleccionarAsignaturas;
        public FontAwesome.Sharp.IconButton btnSalir;
    }
}

