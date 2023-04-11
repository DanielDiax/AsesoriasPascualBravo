using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{

    public partial class FrmRegistro : Form
    {
        #region Propiedades y variables
        public int perfil { get; set; }
        public bool validador { get; set; }

        Login login = new Login();
        DataSet ds = new DataSet();
        #endregion
        public FrmRegistro()
        {   
            InitializeComponent();
            perfil = 1;
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
        }

        #region Text Imput controles
        private void txtPrimerNombre_Enter(object sender, EventArgs e)
        {
            if (this.txtPrimerNombre.Text == "Primer Nombre")
            {
                this.txtPrimerNombre.Text = "";
                this.txtPrimerNombre.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }
        private void txtSegundoNombre_Enter(object sender, EventArgs e)
        {
            if (this.txtSegundoNombre.Text == "Segundo Nombre") 
            {
                this.txtSegundoNombre.Text = "";
                this.txtSegundoNombre.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (this.txtPrimerApellido.Text == "Primer Apellido")
            {
                this.txtPrimerApellido.Text = "";
                this.txtPrimerApellido.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (this.txtSegundoApellido.Text == "Segundo Apellido")
            {
                this.txtSegundoApellido.Text = "";
                this.txtSegundoApellido.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (this.txtDocumento.Text == "Documento de Identidad")
            {
                this.txtDocumento.Text = "";
                this.txtDocumento.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (this.txtEdad.Text == "Edad")
            {
                this.txtEdad.Text = "";
                this.txtEdad.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (this.txtEmail.Text == "Correo Electronico")
            {
                this.txtEmail.Text = "";
                this.txtEmail.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (this.txtPass.Text == "Contraseña")
            {
                this.txtPass.Text = "";
                this.txtPass.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void txtCpass_Enter(object sender, EventArgs e)
        {
            if (this.txtCpass.Text == "Confirmar Contraseña")
            {
                this.txtCpass.Text = "";
                this.txtCpass.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void rbtnPerfil_Click(object sender, EventArgs e)
        {
            if (this.rbtnPerfil.Checked && perfil == 2)
            {
                perfil = 1;
                this.rbtnPerfil.Checked = false;
                
            }
            else
            {
                perfil = 2;
                this.rbtnPerfil.Checked = true;
                
            }
        }

        #endregion

        #region Metodos
        public void LimpiarCampos()
        {
            this.txtPrimerNombre.Text = "Primer Nombre";
            this.txtPrimerNombre.ForeColor = Color.DarkGray;
            this.txtSegundoNombre.Text = "Segundo Nombre";
            this.txtSegundoNombre.ForeColor = Color.DarkGray;
            this.txtPrimerApellido.Text = "Primer Apellido";
            this.txtPrimerApellido.ForeColor = Color.DarkGray;
            this.txtSegundoApellido.Text = "Segundo Apellido";
            this.txtSegundoApellido.ForeColor = Color.DarkGray;
            this.txtDocumento.Text = "Documento de Identidad";
            this.txtDocumento.ForeColor = Color.DarkGray;
            this.txtEdad.Text = "Edad";
            this.txtEdad.ForeColor = Color.DarkGray;
            this.txtEmail.Text = "Correo Electronico";
            this.txtEmail.ForeColor = Color.DarkGray;
            this.txtPass.Text = "Contraseña";
            this.txtPass.ForeColor = Color.DarkGray;
            this.txtCpass.Text = "Confirmar Contraseña";
            this.txtCpass.ForeColor = Color.DarkGray;

            this.rbtnPerfil.Checked = false;
            this.validador = false;
            this.perfil = 1;
        }

        public void ValidadorDatos()
        {
            try
            {
                if (txtPrimerNombre.Text == "" || txtPrimerNombre.Text == "Primer Nombre"
                 || txtPrimerApellido.Text == "" || txtPrimerApellido.Text == "Primer Apellido"
                 || txtDocumento.Text == "" || txtDocumento.Text == "Documento de Identidad"
                 || txtEdad.Text == "" || txtEdad.Text == "Edad"
                 || txtEmail.Text == "" || txtEmail.Text == "Correo Electronico"
                 || txtPass.Text == "" || txtPass.Text == "Contraseña"
                 || txtCpass.Text == "" || txtCpass.Text == "Confirmar Contraseña")
                {
                    MessageBox.Show("Recuerde que debe completar todos los campos."
                        + Environment.NewLine + "Porfavor rellene revise de nuevo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.validador = false;
                }
                else
                {
                    this.validador = true;
                }
                if (txtPass.Text != txtCpass.Text & validador == true)
                {
                    MessageBox.Show("Las contraseñas no coinciden."
                            + Environment.NewLine + "por favor ingreselas de nuevo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCpass.Text = "";
                    this.txtPass.Text = "";
                    this.validador = false;
                }

                if (txtSegundoNombre.Text == "Segundo Nombre")
                {
                    txtSegundoNombre.Text = "";
                }
                if (txtSegundoApellido.Text == "Segundo Apellido")
                {
                    txtSegundoApellido.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en los datos ingresados."
                   + Environment.NewLine + "Verifique los datos que ha ingresado."
                   + Environment.NewLine + "Detalle del Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Eventos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorDatos();
                if (validador == true)
                {
                    string nombre = txtPrimerNombre.Text;
                    string segNombre = txtSegundoApellido.Text;
                    string apellido = txtPrimerApellido.Text;
                    string segApellido = txtSegundoApellido.Text;
                    int edad = Convert.ToInt32(txtEdad.Text);
                    string dni = txtDocumento.Text;
                    string eMail = txtEmail.Text;
                    string pass = txtPass.Text;
                    

                    ds = login.CrearUsuario(nombre, segNombre, apellido, segApellido, edad, dni, eMail, pass, perfil);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string mensaje = ds.Tables[0].Rows[0]["Mensaje"].ToString();
                        MessageBox.Show("¡Muy bien!"
                        + Environment.NewLine + mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados."
                   + Environment.NewLine + "Verifique los datos que ha ingresado."
                   + Environment.NewLine + "Detalle del Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
    }
}
