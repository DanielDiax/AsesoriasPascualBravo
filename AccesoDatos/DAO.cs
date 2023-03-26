using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Globalization;


namespace AccesoDatos
{
    public class DAO
    {
        public static DbProviderFactory ObtenerProveedorDatos()
        {
            if (ConfigurationManager.ConnectionStrings["AsesoriasPascualBravo.Properties.Settings.ConexionDB"] == null)
                throw new ApplicationException("No se ha definido la cadena de conexión 'datos'");

            string proveedor = ConfigurationManager.ConnectionStrings["AsesoriasPascualBravo.Properties.Settings.ConexionDB"].ProviderName;

            DbProviderFactory proveedorDatos = DbProviderFactories.GetFactory(proveedor);

            return proveedorDatos;
        }

        private static string ObtenerCadenaConexion()
        {
            if (ConfigurationManager.ConnectionStrings["AsesoriasPascualBravo.Properties.Settings.ConexionDB"] == null)
                throw new ApplicationException("No se ha definido la cadena de conexión 'datos'");

            string connectionString = ConfigurationManager.ConnectionStrings["AsesoriasPascualBravo.Properties.Settings.ConexionDB"].ConnectionString;

            return connectionString;
        }

        public static DataSet ObtenerDatos(string sql, CommandType tipo, params object[] args)
        {
            DbProviderFactory proveedorDatos = ObtenerProveedorDatos();

            using (DataSet ds = new DataSet())
            using (DbConnection conexion = proveedorDatos.CreateConnection())
            using (DbCommand comando = conexion.CreateCommand())
            using (DbDataAdapter adaptador = proveedorDatos.CreateDataAdapter())
            {
                conexion.ConnectionString = ObtenerCadenaConexion();
                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.CommandTimeout = 5000;
                comando.CommandType = tipo;
                adaptador.SelectCommand = comando;
                ds.Locale = CultureInfo.InvariantCulture;

                AdicionarParametros(comando, args);

                adaptador.Fill(ds);
                ds.AcceptChanges();

                return ds.Copy();
            }
        }

     
        //public static int Ejecutar(string sql, CommandType tipo, params object[] args)
        //{
        //    int rows = 0;
        //    DbProviderFactory proveedorDatos = ObtenerProveedorDatos();

        //    using (DbConnection conexion = proveedorDatos.CreateConnection())
        //    using (DbCommand comando = conexion.CreateCommand())
        //    {
        //        conexion.ConnectionString = ObtenerCadenaConexion();
        //        comando.Connection = conexion;
        //        comando.CommandText = sql;
        //        comando.CommandTimeout = 5000;
        //        comando.CommandType = tipo;

        //        AdicionarParametros(comando, args);
        //        conexion.Open();
        //        rows = comando.ExecuteNonQuery();
        //    }

        //    return rows;
        //}

   
        //public static DbTransaction CrearTransaccion()
        //{
        //    DbProviderFactory proveedorDatos = ObtenerProveedorDatos();
        //    DbConnection conexion = proveedorDatos.CreateConnection();
        //    DbTransaction transaccion =
        //        conexion.BeginTransaction(IsolationLevel.ReadCommitted);

        //    return transaccion;
        //}

      
        private static void AdicionarParametros(DbCommand cmd, params object[] args)
        {
            if (args != null && args.Length >= 3)
            {
                string parameterName;
                object value;

                for (int index = 0; index <= args.Length - 3; index += 3)
                {
                    parameterName = args[index].ToString();
                    DbType type = ( DbType )args[index + 1];
                    value = args[index + 2];

                    DbParameter parametro = cmd.CreateParameter();
                    parametro.ParameterName = parameterName;

                    cmd.Parameters.Add(parametro);
                    cmd.Parameters[parameterName].Value = value;
                    cmd.Parameters[parameterName].DbType = type;
                }
            }
        }
    }
}
