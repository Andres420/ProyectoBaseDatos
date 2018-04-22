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
        //SELECT table_name from INFORMATION_SCHEMA.views;
        bdBOL bdbol;
        string database;
        public MenuVistas(string database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnCrearVista_Click(object sender, EventArgs e)
        {
            try
            {
                string vista = "CREATE VIEW " + txtNombreVista.Text + " AS " + rtbCrearVista.Text;
                bool vistacreada = bdbol.Consulta(vista, database);
                if (vistacreada) MessageBox.Show("Vista creada");
                else MessageBox.Show("No se pudo crear la vista");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuVistas_Load(object sender, EventArgs e)
        {
            bdbol = new bdBOL();
        }

        private void btnModificarVista_Click(object sender, EventArgs e)
        {
            try
            {
                string vista = "REPLACE " + cbModificarVista.SelectedItem + " AS " + rtbModificarVista.Text;
                bool vistamodificada = bdbol.Consulta(vista, database);
                if (vistamodificada) MessageBox.Show("Vista Modificada");
                else MessageBox.Show("No se pudo modificar la vista");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
