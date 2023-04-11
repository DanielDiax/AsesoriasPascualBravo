using System;
using System.Data;
using System.Windows;

namespace AsesoriasPascualBravo.Servicios
{
    class Agendamientos
    {
        public DataSet ConsultarAsesorias()
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "AsesoriasDocentes");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet ConsultarAsignaturasPorDocente(int idDocente)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "AsignaturasPorDocente",
                         "@IdDocente", DbType.Int32, idDocente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}
