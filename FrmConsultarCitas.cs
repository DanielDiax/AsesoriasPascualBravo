using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{
    public partial class FrmConsultarCitas : Form
    {
        #region Declaraciones y Variables
        public int IdEstudiante { get; set; }
        public int IdCita { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        #endregion
        
        public FrmConsultarCitas(int idEstudiante)
        {
            InitializeComponent();
            IdEstudiante = idEstudiante;
            IdCita = 0;
        }

        private void FrmConsultarCitas_Load(object sender, EventArgs e)
        {
            ConsultarCitas();
        }

        #region Funciones
        public void ConsultarCitas()
        {
            try
            {
                ds = agendamientos.ConsultarCitasPorEstudiante(IdEstudiante);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvCitas.DataSource = ds.Tables[0];
                    this.dgvCitas.Columns[0].Visible = false;   
                }
                else
                {
                    MessageBox.Show("No tiene citas programadas vaya a agendamientos y seleccione alguna.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obteniendo las citas."
                      + Environment.NewLine + "Detalles del error." + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarCita()
        {
            DataSet data = null;

            if (IdCita != 0)
            {
                data = agendamientos.EliminarCita(IdCita);

                if (data.Tables[0].Rows.Count > 0)
                {
                    string mensaje = data.Tables[0].Rows[0]["mensaje"].ToString();
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarCitas();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna cita.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        #region Eventos
        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCita = Convert.ToInt32(this.dgvCitas.Rows[e.RowIndex].Cells["IdCita"].Value);
            this.btnEliminar.Enabled = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCita();
        }

        #endregion

        
    }
}
