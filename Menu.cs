using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;
using FontAwesome.Sharp;

namespace AsesoriasPascualBravo
{
    public partial class Menu : Form
    {
        
        private void Menu_Load(object sender, EventArgs e)
        {
            this.lblPerfil.Text = "";
            this.lblApellidoUsuario.Text = "";
            this.lblNombreUsuario.Text = "";
        }
        // Creo campos que se van a asignar dinamicamente a los botones 
        #region Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public int Perfil { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDocente { get; set; }

        Login login = new Login();
        DataSet ds = new DataSet();
        #endregion

        //Constructor 
        public Menu()
        {
            InitializeComponent();
            //inicialización del panel izquierdo
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //Formulario 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Estructura de Colores, para invocar uno especificamente al accionar el botón(Opcional)
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Metodo para cambiar los estilos del boton 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = ( IconButton )senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        //Metodo para retornar los valores del botón por defecto.
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 30, 54);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmLogin());
            FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.Perfil == 1)
            {
                this.btnAgendarCitas.Visible = true;
                this.btnConsultarCitas.Visible = true; 
            }
        }

        #region Botones de los formularios
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmRegistro());
        }

        private void btnAgendarCitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmAgendarCita(IdEstudiante));
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnVisualizarCitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FrmCrearAsesoria(IdDocente));
        }

        private void btnCrearCitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Application.Exit();
        }

        #endregion


        #region Controles de ventana Minimizar, Maximizar, Arrastrar, Cerrar
        //Se importan las librerias para poder arrastrar el formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Eventos en los textArea para hacerlos mas interactivios, cambiando el color y borrando el contenido inicial

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "E-Mail")
            {
                this.txtUsuario.Text = "";
                this.txtUsuario.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { txtPassword.Focus(); }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Contraseña")
            {
                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = Color.FromArgb(37, 37, 38);
                this.txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
            if (e.KeyChar == 13) { LogIn();}
        }

        #endregion


        #region Metodo Para Login y eventos del login

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        public void LogIn() 
        {
            try
            {
                if (txtUsuario.Text == "" || txtUsuario.Text == "E-Mail"
                    || txtPassword.Text == "" || txtPassword.Text == "Contraseña")
                {
                    MessageBox.Show("Recuerde que debe completar todos los campos."
                    + Environment.NewLine + "Porfavor rellene revise de nuevo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string usuario = txtUsuario.Text;
                    string contrasena = txtPassword.Text;
                    ds = login.UserLogin(usuario, contrasena);

                    if (ds.Tables[0].Columns.Count == 1)
                    {
                        string mensaje = ds.Tables[0].Rows[0]["Mensaje"].ToString();
                        MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.lblNombreUsuario.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
                        this.lblApellidoUsuario.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
                        this.panelDesktop.BackColor = Color.White;
                        this.pbPascualBravo.Visible = true;
                        this.panelLogin.Visible = false;
                        this.btnRegistro.Visible = false;
                        txtUsuario.Text = "";
                        txtPassword.Text = "";

                        Perfil = Convert.ToInt32(ds.Tables[0].Rows[0]["Perfil"]);
                        if (Perfil == 1)
                        {
                            MessageBox.Show("Ha iniciado como estudiante", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnAgendarCitas.Visible = true;
                            this.btnConsultarCitas.Visible = true;
                            this.lblPerfil.Text = "Estudiante";
                            this.IdEstudiante = Convert.ToInt32(ds.Tables[0].Rows[0]["IdRows"]);
                        }
                        else
                        {
                            MessageBox.Show("Ha iniciado como profesor", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnSeleccionarAsignaturas.Visible = true;
                            this.btnCrearAsesoria.Visible = true;
                            this.lblPerfil.Text = "Docente";
                            IdDocente = Convert.ToInt32(ds.Tables[0].Rows[0]["IdRows"]);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el logueo."
                   + Environment.NewLine + "Valide los datos ingresado o comuniquese con soporte."
                   + Environment.NewLine + "Detalle del Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        
    }
}
