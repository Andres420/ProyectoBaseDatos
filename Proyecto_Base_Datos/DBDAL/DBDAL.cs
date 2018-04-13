﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DBDAL
{
    public class dbDAL
    {
        ConexionDAL conexion;
        public dbDAL()
        {
            conexion = new ConexionDAL();
        }
        public bool CrearBaseDatos(string crearbasedatos)
        {
            return conexion.Consulta(crearbasedatos,null);
        }

        public List<string> CargarNombres(string consulta)
        {
            return conexion.LeerTabla(consulta);
        }

        public string BuscarTablas(string baseDatos)
        {
            return conexion.BuscarTablas(baseDatos);
        }

        public bool Consulta(string consulta, string bd)
        {
            return conexion.Consulta(consulta, bd);
        }

        public NpgsqlDataReader ConsultaSelect(string consulta, string bd)
        {
            return conexion.ConsultaSelect(consulta, bd);
        }

        public void CerrarConsulta()
        {
            conexion.CerrarConexion();
        }
    }
}
