using System;
using System.Data;
using System.Windows.Forms;

namespace AsesoriasPascualBravo.Servicios
{
    class Login
    {
        public DataSet ConsultarConeccion()
        {

            DataSet Ds = null;
            try
            {
                Ds
                    = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                                                  "@Accion", DbType.String, "Guardar");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Ds;
        }
    }
}
