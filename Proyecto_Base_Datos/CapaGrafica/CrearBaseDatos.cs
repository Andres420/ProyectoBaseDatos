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
    public partial class CrearBaseDatos : Form
    {

        private bdBOL crearbol;
        public CrearBaseDatos()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        /// <summary>
        /// Este metodo carga todas las bases de datos a los combobox
        /// </summary>
        private void cargarCombos()
        {
            cbBaseDatos_mod.Items.Clear();
            cbBaseDatos_eli.Items.Clear();
            crearbol.CargarNombreDB().ForEach(delegate (string namedb)
            {
                cbBaseDatos_mod.Items.Add(namedb);
                cbBaseDatos_eli.Items.Add(namedb);
            });
            cbBaseDatos_mod.SelectedIndex = 0;
            cbBaseDatos_eli.SelectedIndex = 0;
        }
        private void CrearBaseDatos_Load(object sender, EventArgs e)
        {
            crearbol = new bdBOL();
            cargarCombos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            if (!txtNombrebase.Equals(String.Empty))
            {
                bool basecreada = crearbol.CRUDBaseDatos("CREATE DATABASE " + txtNombrebase.Text + ";");
                if (basecreada) MessageBox.Show("Base datos creada");
                else MessageBox.Show("No se pudo crear la base de datos");
            }
            cargarCombos();
            btnCrear.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            if (!txtModificarBase.Text.Equals(String.Empty))
            {
                if (crearbol.CRUDBaseDatos("ALTER DATABASE " + cbBaseDatos_mod.SelectedItem + " RENAME TO " + txtModificarBase.Text + ";")) MessageBox.Show("Base de datos modificada");
                else MessageBox.Show("La base de datos no pudo ser modificada");
                cargarCombos();
            }
            else
            {
                MessageBox.Show("Escriba un nuevo nombre");
            }
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            if (crearbol.CRUDBaseDatos("DROP DATABASE " + cbBaseDatos_eli.SelectedItem + ";")) MessageBox.Show("Base de datos eliminada");
            else MessageBox.Show("La base de datos no pudo ser eliminada");
            cargarCombos();
            btnEliminar.Enabled = false;
        }
    }
}