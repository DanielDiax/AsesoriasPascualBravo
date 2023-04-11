using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{
    public partial class FrmLogin : Form
    {
        #region Propiedades y variables
        public int Perfil { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDocente { get; set; }

        Login login = new Login();
        DataSet ds = new DataSet();
        
        #endregion
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

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
            if (e.KeyChar == 13) { }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
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
                        Menu menu = new Menu();
                        string nombreUsuario = ds.Tables[0].Rows[0]["Nombre"].ToString();
                        string apellidoUsuario = ds.Tables[0].Rows[0]["Apellido"].ToString();
                        
                        menu.btnAgendarCitas.Visible = true;
                        txtUsuario.Text = "";
                        txtPassword.Text = "";

                        Perfil = Convert.ToInt32(ds.Tables[0].Rows[0]["Perfil"]);
                        if (Perfil == 1)
                        {
                            MessageBox.Show("Ha iniciado como estudiante", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("Ha iniciado como profesor", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
