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
    public partial class FrmAgendarCita : Form
    {
        public int IdEstudiante { get; set; }
        Agendamientos agendamientos = new Agendamientos();
        DataSet ds = null;
        public FrmAgendarCita(int idEstudiante)
        {
            InitializeComponent();
            IdEstudiante = idEstudiante;
        }

        private void FrmAgendarCita_Load(object sender, EventArgs e)
        {
            ConsultarAsesoriasDisponibles();
        }

        public void ConsultarAsesoriasDisponibles() 
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
