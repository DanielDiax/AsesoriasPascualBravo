using System;
using System.Data;
using System.Windows.Forms;

using AsesoriasPascualBravo.Servicios;

namespace AsesoriasPascualBravo
{
    public partial class FrmSeleccionarAsignaturas : Form
    {
        #region Declaraciones y Variables
        public int IdDocente { get; set; }
        public int IdAsignatura { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        #endregion
        public FrmSeleccionarAsignaturas(int idDocente)
        {
            IdDocente = idDocente;
            InitializeComponent();
        }

        private void FrmSeleccionarAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asignaturas_UIPascualBravoDataSet.tbl_Asignaturas' Puede moverla o quitarla según sea necesario.
            this.tbl_AsignaturasTableAdapter.Fill(this.asignaturas_UIPascualBravoDataSet.tbl_Asignaturas);
            ConsultarAsignaturasPorDocente();
        }

        #region Funciones
        public void ConsultarAsignaturasPorDocente()
        {
            this.DgvAsignaturas.DataSource = null;
            try
            {
                ds = agendamientos.ConsultarAsignaturasPorDocente(IdDocente);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.DgvAsignaturas.DataSource = ds.Tables[0];
                    this.DgvAsignaturas.Columns[0].Visible = false;
                }
                else 
                {
                    MessageBox.Show("No tiene ninguna asignatura asignada, seleccione alguna", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public void AgregarAsignatura()
        {
            DataSet dsM = null;

            IdAsignatura = Convert.ToInt32(cmbAsignaturas.SelectedValue);

            dsM = agendamientos.AgregarAsignatura(IdDocente, IdAsignatura);

            if (dsM.Tables[0].Rows.Count > 0)
            {
                string mensaje = Convert.ToString(dsM.Tables[0].Rows[0]["Mensaje"]);
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ConsultarAsignaturasPorDocente();
        }
        #endregion

        private void btnAgregarAsignatura_Click(object sender, EventArgs e)
        {
            AgregarAsignatura();
        }

        private void dgvAsignaturas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //IdAsignatura = Convert.ToInt32(this.dgvAsignaturas.Rows[e.RowIndex].Cells["IdAsignaturaInt"].Value);
        }
    }
}
