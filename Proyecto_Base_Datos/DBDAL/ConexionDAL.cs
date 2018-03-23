﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DBDAL
{

    public class ConexionDAL
    {
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        public ConexionDAL()
        {
            conn = new NpgsqlConnection(ConfiguracionDAL.ConStr);
            conn.Open();
        }

        public void CerrarConexion()
        {
            if (dr != null) dr.Close();
            conn.Close();

        }
        public bool Consulta(string consul)
        {
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
        public NpgsqlDataReader LeerTabla(string consulta)
        {
            cmd = new NpgsqlCommand(consulta,conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}