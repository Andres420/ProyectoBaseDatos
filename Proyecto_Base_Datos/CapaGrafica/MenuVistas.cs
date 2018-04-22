using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDBOL;
namespace CapaGrafica
{
    public partial class MenuVistas : Form
    {
        
        bdBOL bdbol;
        string database;
        private string vistas_db = "SELECT table_name from INFORMATION_SCHEMA.views WHERE table_schema = 'public';";
        public MenuVistas(string database)
        {
            InitializeComponent();
            this.database = database;
        }
        private void CargarCombos()
        {
            //cbModificarVista.Items.Clear();cbEliminarVista.Items.Clear();
            //cbModificarVista.SelectedIndex = 0;cbEliminarVista.SelectedIndex = 0;
            //List<string> vistas = bdbol.CargarVistas(vistas_db, database);
            //vistas.ForEach(delegate(string vista) { cbModificarVista.Items.Add(vista); cbEliminarVista.Items.Add(vista);});
        }
        private void btnCrearVista_Click(object sender, EventArgs e)
        {
            try
            {
                string vista = "CREATE VIEW " + txtNombreVista.Text + " AS " + rtbCrearVista.Text;
                bool vistacreada = bdbol.Consulta(vista, database);
                if (vistacreada) MessageBox.Show("Vista creada");
                else MessageBox.Show("No se pudo crear la vista");
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CargarCombos();
            }
        }

        private void MenuVistas_Load(object sender, EventArgs e)
        {
            bdbol = new bdBOL();
            CargarCombos();
        }

        private void btnModificarVista_Click(object sender, EventArgs e)
        {
            try
            {
                string vista = "REPLACE " + cbModificarVista.SelectedItem + " AS " + rtbModificarVista.Text;
                bool vistamodificada = bdbol.Consulta(vista, database);
                if (vistamodificada) MessageBox.Show("Vista Modificada");
                else MessageBox.Show("No se pudo modificar la vista");
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CargarCombos();
            }
        }

        private void btnEliminarVista_Click(object sender, EventArgs e)
        {
            try
            {
                string vista = "DROP VIEW " + cbEliminarVista.SelectedItem + ";";
                bool vistaeliminada = bdbol.Consulta(vista, database);
                if (vistaeliminada) MessageBox.Show("Vista Eliminada");
                else MessageBox.Show("No se pudo eliminar la vista");
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CargarCombos();
            }
        }
    }
}
