using System;
using System.Data;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{
    public partial class FrmConsultarAsesorias : Form
    {
        #region Declaraciones y Variables
        public int IdDocente { get; set; }
        public int IdAsesoria { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet data = null;
        #endregion
        public FrmConsultarAsesorias(int idDocente)
        {
            IdDocente = idDocente;
            IdAsesoria = 0;
            InitializeComponent();
        }
        private void FrmConsultarAsesorias_Load(object sender, EventArgs e)
        {

        }


        #region Funciones
        public void ConsultarAseroriasxDocente()
        {
            string fechaInicial = dtpFechaInicial.Text;
            string fechaFinal = dtpFechaFinal.Text;

            fechaFinal = fechaFinal.Replace("/", "");
            fechaInicial = fechaInicial.Replace("/", "");

            data = agendamientos.ConsultarAsesoriasPorDocente(IdDocente, fechaInicial, fechaFinal);



            if (data.Tables[0].Rows.Count > 0)
            {
                this.dgvAsesorias.DataSource = data.Tables[0];
                this.dgvAsesorias.Columns[0].Visible = false;
                this.dgvAsesorias.Columns[1].Visible = false;
            }
            else
            {
                MessageBox.Show("No hay asesorias asignadas en el rago de fechas seleccionado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EliminarAsesoria()
        {
            try
            {
                if (IdAsesoria == 0)
                {
                    MessageBox.Show("Debe seleccionar alguna asesoria para eliminarla", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataSet ds = null;

                    ds = agendamientos.EliminarAsesoria(IdAsesoria);

                    ConsultarAseroriasxDocente();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string mensaje = ds.Tables[0].Rows[0]["Mensaje"].ToString();
                        MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        #endregion

        #region Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarAseroriasxDocente();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAsesoria();
        }

        #endregion

        private void dgvAsesorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdAsesoria = Convert.ToInt32(this.dgvAsesorias.Rows[e.RowIndex].Cells["idAsesoria"].Value);
            this.btnEliminar.Enabled = true;
        }
    }
}
