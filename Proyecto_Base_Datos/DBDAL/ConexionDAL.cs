using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DBDAL
{

    public class ConexionDAL
    {
        private string conexion = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=clave123;Database=";
        private string base_ = "postgres";
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;

        public ConexionDAL()
        {
        }
        private void AbrirConexionVieja()
        {
            conn = new NpgsqlConnection(conexion + base_);
            conn.Open();
        }

        private void AbrirConexionNueva(string base_nueva)
        {
            conn = new NpgsqlConnection(conexion + base_nueva);
            conn.Open();
        }

        public void CerrarConexion()
        {
            if (dr != null) dr.Close();
            if(conn != null) conn.Close();
        }


        public bool Consulta(string consul)
        {
            AbrirConexionVieja();
            int cambio = 0;
            try
            {
                cmd = new NpgsqlCommand(consul, conn);
                cambio = cmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                cambio = 0;
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
            cmd = new NpgsqlCommand(consulta, conn);
            dr = cmd.ExecuteReader();

            return ConvertirTabla(dr);
        }

        /// <summary>
        /// Convierte el NpgsqlDataReader en string que
        /// se guardan en una lista y se retornan
        /// </summary>
        /// <param name="dr">NpgsqlDataReader contiene los datos a convertir</param>
        /// <returns>Lista con los datos deseados en formato de string</returns>
        private List<string> ConvertirTabla(NpgsqlDataReader dr)
        {
            List<string> bases = new List<string>();
            while (dr.Read())
            {
                bases.Add(dr.GetString(0));
            }
            CerrarConexion();
            return bases;
        }

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
                    tablas += "|" + dr.GetString(0);
                }
            }
            CerrarConexion();

            return tablas;
        }
    }
}
