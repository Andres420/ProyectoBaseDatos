using System;
using System.Collections.Generic;
using System.Data;
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
        public bool CRUDBaseDatos(string crearbasedatos)
        {
            return conexion.Consulta(crearbasedatos, "postgres");
        }

        public List<string> CargarNombres(string consulta)
        {
            return conexion.LeerTabla(consulta);
        }

        public string BuscarTablas(string baseDatos)
        {
            return conexion.BuscarTablas(baseDatos);
        }

        public string BuscarSequencias(string baseDatos)
        {
            return conexion.BuscarSequencias(baseDatos);
        }

        public bool Consulta(string consulta, string bd)
        {
            return conexion.Consulta(consulta, bd);
        }

        public NpgsqlDataAdapter ConsultaSelect(string consulta, string bd)
        {
            return conexion.ConsultaSelect(consulta, bd);
        }

        public void CerrarConsulta()
        {
            conexion.CerrarConexion();
        }

        public string BuscarSquema(string baseDatos)
        {
            return conexion.BuscarSquemas(baseDatos);
        }
    }
}
