using System;
using System.Data;
using System.Windows.Forms;

namespace AsesoriasPascualBravo.Servicios
{
    class Login
    {
        public int Perfil { get; set; }
        public DataSet CrearUsuario(string nombre, string segNombre, string Apellido, string segApellido, int edad, string dni, string eMail, string pass, int perfil)
        {

            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                                                  "@Accion", DbType.String, "GuardarPersona",
                                                       "@Nombre", DbType.String, nombre,
                                                       "@SegNombre", DbType.String, segNombre,
                                                       "@Apellido", DbType.String, Apellido,
                                                       "@SegApellido", DbType.String, segApellido,
                                                       "@Edad", DbType.Int32, edad,
                                                       "@DNI", DbType.String, dni,
                                                       "@CorreoElectronico", DbType.String, eMail,
                                                       "@Contrasena", DbType.String, pass,
                                                       "@Perfil", DbType.Int32, perfil);

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public DataSet UserLogin(string email, string contrasena)
        {
            DataSet ds = null;
            try
            {
                ds = AccesoDatos.DAO.ObtenerDatos("Sp_AsesoriasPascualBravo", CommandType.StoredProcedure,
                    "@Accion", DbType.String, "ConsultarUsuario",
                         "@CorreoElectronico", DbType.String, email,
                         "@Contrasena", DbType.String, contrasena);
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}
