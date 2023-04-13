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
    public partial class FrmCrearAsesoria : Form
    {
        #region Declaraciones y Variables
        public int IdDocente { get; set; }
        public int IdAsignaturaInt { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        #endregion
        public FrmCrearAsesoria(int idDocente)
        {
            InitializeComponent();
            IdDocente = idDocente;
            IdAsignaturaInt = 0;
        }
        private void FrmCrearAsesoria_Load(object sender, EventArgs e)
        {
            ConsultarAsignaturasPorDocente();
        }

        #region Metodos
        public void ConsultarAsignaturasPorDocente()
        {
            try
            {
                ds = agendamientos.ConsultarAsignaturasPorDocente(IdDocente);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvAsignaturas.DataSource = ds.Tables[0];
                    dgvAsignaturas.Columns[0].Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CrearAsesoriaXDocente() 
        {
            try
            {
                if (IdAsignaturaInt == 0)
                {
                    MessageBox.Show("Recuerde que debe Seleccionar una materia."
                       + Environment.NewLine + "Porfavos escojala de la tabla.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string fecha = dtpFecha.Text;
                    string horaInicial = dtpHoraInicial.Text;
                    string horaFinal = dtpHoraFinal.Text;

                    agendamientos.CrearAsesoriaXDocente(IdAsignaturaInt, fecha, horaInicial, horaFinal);

                    MessageBox.Show("La asesoria se ha guardado correctamente."
                       + Environment.NewLine + "Consulte las asesorias por docente para validar que este correcta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ga salido mal al guardar la asesoria."
                      + Environment.NewLine + "Detalles del error."+ ex,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void dgvAsignaturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSeleccionAsignatura.Text = Convert.ToString(this.dgvAsignaturas.Rows[e.RowIndex].Cells["Asignatura"].Value);
            IdAsignaturaInt = Convert.ToInt32(this.dgvAsignaturas.Rows[e.RowIndex].Cells["IdAsignaturaInt"].Value);
        }

        private void CrearAsesoria_Click(object sender, EventArgs e)
        {
            CrearAsesoriaXDocente();
        }
    }
}
