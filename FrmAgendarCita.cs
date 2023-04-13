using System;
using System.Data;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{
    public partial class FrmAgendarCita : Form
    {
        public int IdEstudiante { get; set; }
        public int IdAsesoria { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        public FrmAgendarCita(int idEstudiante)
        {
            InitializeComponent();
            IdEstudiante = idEstudiante;
            IdAsesoria = 0;
        }

        private void FrmAgendarCita_Load(object sender, EventArgs e)
        {
            ConsultarAsesoriasDisponibles();
        }
        #region Funciones
        public void ConsultarAsesoriasDisponibles()
        {
            try
            {
                ds = agendamientos.ConsultarAsesoriasDisponibles();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvAsesoriasDisponibles.DataSource = ds.Tables[0];
                    this.dgvAsesoriasDisponibles.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay asesorias disponibles.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void CrearCita ()
        {
            try
            {
                if (IdAsesoria == 0)
                {
                    MessageBox.Show("No ha seleccionado una asesoria.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataSet data = null;
                    data = agendamientos.CrearCitaAsesoria(IdAsesoria, IdEstudiante);
                    string mensaje;

                    mensaje = data.Tables[0].Rows[0]["mensaje"].ToString();

                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo ga salido mal al guardar la cita."
                      + Environment.NewLine + "Detalles del error." + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region Eventos
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            CrearCita();
        }

        private void dgvAsesoriasDisponibles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdAsesoria = Convert.ToInt32(this.dgvAsesoriasDisponibles.Rows[e.RowIndex].Cells["IdAsesoria"].Value);
        }
        #endregion

    }
}
