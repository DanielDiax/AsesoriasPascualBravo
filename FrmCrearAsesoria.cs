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
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        #endregion
        public FrmCrearAsesoria(int idDocente)
        {
            InitializeComponent();
            IdDocente = idDocente;
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
                ds = agendamientos.ConsultarAsignaturasPorDocente(1);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvAsignaturas.DataSource = ds.Tables[0];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void dgvAsignaturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSeleccionAsignatura.Text = this.dgvAsignaturas.Rows[e.RowIndex].Cells["Asignatura"].ToString();
        }
    }
}
