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
    }
}
