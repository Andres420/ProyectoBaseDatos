using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBDAL;
using Npgsql;

namespace BDBOL
{
    public class bdBOL
    {
        dbDAL usarDAL;
        public bdBOL()
        {
            usarDAL = new dbDAL();
        }
        public bool CrearBaseDatos(string nombrenuevo)
        {
            return usarDAL.CrearBaseDatos("CREATE DATABASE " + nombrenuevo + ";");
        }

        public List<string> CargarNombreDB()
        {
            return usarDAL.CargarNombres("SELECT datname FROM pg_database WHERE datistemplate = false;");
        }

        public string BuscarTablas(string baseDatos)
        {
            return usarDAL.BuscarTablas(baseDatos);
        }

        public Boolean Consulta(string consulta, string bd)
        {
            return usarDAL.Consulta(consulta, bd);
        }

        public void CerrarConsulta()
        {
            usarDAL.CerrarConsulta();
        }

        public DataTable CargarConsulta(string consulta, string bd)
        {
            throw new NotImplementedException();
        }

        public void AbrirNuevaConexion(string v)
        {
            ConexionDAL cdal = new ConexionDAL();
            cdal.AbrirConexionNueva(v);
        }

        public NpgsqlDataAdapter ConsultaSelect(string consulta, string bd)
        {
            return usarDAL.ConsultaSelect(consulta, bd);
            

        }
    }
}
