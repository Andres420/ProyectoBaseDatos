using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Conexion
{

    public class Conexion
    {
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        public Conexion()
        {
            conn = new NpgsqlConnection("");
        }

        public void CerrarConexion()
        {
            dr.Close();
            conn.Close();
        }
        public int Consulta(string consul)
        {
            cmd = new NpgsqlCommand(consul,conn);
            int cambio = cmd.ExecuteNonQuery();
            return cambio;
        }
        public NpgsqlDataReader LeerTabla(string consulta)
        {
            cmd = new NpgsqlCommand(consulta,conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
