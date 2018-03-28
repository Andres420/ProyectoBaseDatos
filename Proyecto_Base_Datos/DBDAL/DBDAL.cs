using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return conexion.Consulta(crearbasedatos);
        }

        public List<string> CargarNombres(string consulta)
        {
            return conexion.LeerTabla(consulta);
        }

        public string BuscarTablas(string baseDatos)
        {
            return conexion.BuscarTablas(baseDatos);
        }
    }
}
