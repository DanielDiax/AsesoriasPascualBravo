using System;
using System.Data;
using System.Windows;


namespace AsesoriasPascualBravo.Servicios
{
    class Agendamientos
    {
        public DataSet ConsultarAsesoriasDisponibles()
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "AsesoriasDisponibles");

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

        public void CrearAsesoriaXDocente(int idAsignaturaInt, string fecha, string horaInicial, string horaFinal)
        {
            try
            {
                AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                                                    "@Accion", DbType.String, "CrearAsesoria",
                                                         "@IdRowAsignaturaInt", DbType.Int32, idAsignaturaInt,
                                                         "@FechaAsesoria", DbType.DateTime, Convert.ToDateTime(fecha),
                                                         "@HoraInicial", DbType.DateTime, Convert.ToDateTime(horaInicial),
                                                         "@HoraFinal", DbType.DateTime, Convert.ToDateTime(horaFinal));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataSet ConsultarAsesoriasPorDocente(int idDocente, string fechaInicial, string fechaFinal)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                                                    "@Accion", DbType.String, "AsesoriasPorDocente",
                                                         "@IdDocente", DbType.Int32, idDocente,
                                                         "@FechaInicial", DbType.String, fechaInicial,
                                                         "@FechaFinal", DbType.String, fechaFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet CrearCitaAsesoria(int idAsesoria, int idEstudiante)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                                                    "@Accion", DbType.String, "CrearCita",
                                                         "@IdAsesoria", DbType.Int32, idAsesoria,
                                                         "@IdEstudiante", DbType.Int32, idEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ga salido mal al guardar la cita."
                      + Environment.NewLine + "Detalles del error." + ex);
            }
            return ds;
        }

        public DataSet ConsultarCitasPorEstudiante(int idEstudiante)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "ConsultarCitas",
                         "@IdEstudiante", DbType.Int32, idEstudiante);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet EliminarCita(int idCita)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "EliminarCita",
                         "@IdCita", DbType.Int32, idCita);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet EliminarAsesoria(int idAsesoria)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "EliminarAsesoria",
                         "@IdAsesoria", DbType.Int32, idAsesoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet AgregarAsignatura(int idDodente, int idAsignatura)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "AgregarAsignaturas",
                         "@IdDocente", DbType.Int32, idDodente,
                         "@IdRowAsignatura", DbType.Int32, idAsignatura);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;

        }
    }
}
