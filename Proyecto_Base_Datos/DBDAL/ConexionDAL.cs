using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DBDAL
{

    public class ConexionDAL
    {
        //291297
        private string conexion = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=clave123;Database=";
        private string base_ = "postgres";
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        SqlConnection connection;
        NpgsqlDataReader dr;
        NpgsqlDataAdapter da;

        public ConexionDAL()
        {
        }
        private void AbrirConexionVieja()
        {
            conn = new NpgsqlConnection(conexion + base_ + ";Pooling=false;");
            conn.Open();
        }

        public void AbrirConexionNueva(string base_nueva)
        {
            conn = new NpgsqlConnection(conexion + base_nueva + ";Pooling=false;");
            conn.Open();
        }

        public void NuevaConAdapter(string base_nueva)
        {
            connection = new SqlConnection(conexion + base_nueva);
            connection.Open();
        }

        public void CerrarConexion()
        {

            if (dr != null && dr.HasRows) dr.Dispose();
            if (dr != null && dr.HasRows) dr.Close();
            if (conn != null) conn.Dispose();
            if (conn != null) conn.Close();

        }

        /// <summary>
        /// Realiza cualquier consulta u string sql que
        /// se necesite en la base de datos que se desea
        /// </summary>
        /// <param name="consul">string sql </param>
        /// <param name="bd">string nombre de la base de datos</param>
        /// <returns>true si fue posible, de lo contrario enviara el error generado</returns>
        public bool Consulta(string consul, string bd)
        {
            //if (String.IsNullOrEmpty(bd))
            //{
            //    AbrirConexionNueva(bd);
            //}
            //else
            //{
            //    AbrirConexionVieja();
            //}
            AbrirConexionNueva(bd);
            int cambio = 0;
            try
            {
                cmd = new NpgsqlCommand(consul, conn);
                cambio = cmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                CerrarConexion();
                throw new Exception(ex.Message);
            }



            if (cambio == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Lee datos de la base de datos dependiendo del string que recibe por consulta
        /// y los retorna en una lista como strings
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public List<String> LeerTabla(string consulta)
        {
            AbrirConexionVieja();
            List<string> bases = new List<string>(); ;
            cmd = new NpgsqlCommand(consulta, conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bases.Add(dr.GetString(0));
                }
                dr.Close();
                dr.Dispose();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                CerrarConexion();
            }

            return bases;
        }

       
        /// <summary>
        /// Se encarga de cargar todas las tablas de las bases de datos
        /// </summary>
        /// <param name="bases"></param>
        /// <returns></returns>
        public string BuscarTablas(string bases)
        {
            CerrarConexion();
            string tablas = "";
            AbrirConexionNueva(bases);
            cmd = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';", conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tablas += dr.GetString(0) + "|";
                }
            }
            CerrarConexion();

            return tablas;
        }


        /// <summary>
        /// Se encarga de realizar un select mediante un dataadapter
        /// que luego es retornado para ser mostrado
        /// </summary>
        /// <param name="consul">string el select que se desea realizar</param>
        /// <param name="bd">string nombre de la base de datos a la que se quiere acceder</param>
        /// <returns> NpgsqlDataAdapter que contiene todos los datos de la tabla solicitada</returns>
        public NpgsqlDataAdapter ConsultaSelect(string consul, string bd)
        {

            AbrirConexionNueva(bd);
            try
            {
                //cmd = new NpgsqlCommand(consul, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                da = new NpgsqlDataAdapter();
                da.SelectCommand = new NpgsqlCommand(consul, conn);
                

                return da;
                
            }
            catch (Exception ex)
            {
                CerrarConexion();
                throw new Exception(ex.Message);
            }
        }

    }
}
