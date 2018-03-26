using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBDAL;
namespace BDBOL
{
    public class bdBOL
    {
        dbDAL crearDAL;
        public bdBOL()
        {
            crearDAL = new dbDAL();
        }
        public bool CrearBaseDatos(string nombrenuevo)
        {
            return crearDAL.CrearBaseDatos("CREATE DATABASE " + nombrenuevo + ";");
        }

        public List<string> CargarNombreDB()
        {
            return crearDAL.CargarNombres("SELECT datname FROM pg_database WHERE datname != 'template1' AND datname != 'template0';");
        }
    }
}
