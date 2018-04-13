using BDBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGrafica
{
    public partial class Menu : Form
    {
        private bdBOL dbbol;
        private string baseDatos;
        private List<String> bases;

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbbol = new bdBOL();
            cbBases.Visible = false;
            rtboxConsulta.Visible = false;
            btbEjecutar.Visible = false;
            button2.Visible = false;
            ActualizarArbol();
        }
        /// <summary>
        /// Se encarga de cargar los nombres de las bases de datos
        /// y los agrega como strings al arbol
        /// </summary>
        private void ActualizarArbol()
        {
            // treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add() linea para agregar las bases de datos al arbol
            bases = dbbol.CargarNombreDB();
            int cont = 0;
            foreach (var item in bases)
            {
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item);
                baseDatos = item;
                AgregarCompo(cont);


                cont++;
                //TODO: Implementar metodo para agregar todas las opciones a cada base de datos
            }

        }

        /// <summary>
        /// Agrega los componentes basicos a cada base de datos
        /// </summary>
        /// <param name="cont">int que hace referencia al nodo que
        /// debe agregar los componentes</param>
        private void AgregarCompo(int cont)
        {
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Casts");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Catalogs");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Event Triggers");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Extensions");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Foreign Data Wrappers");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Languages");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Schemas");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes.Add("public");
            AgregarSquemas(cont);
        }

        /// <summary>
        /// Se encargar de colocar los componentes basicos 
        /// de un esquema de la base de datos
        /// </summary>
        /// <param name="cont"></param>
        private void AgregarSquemas(int cont)
        {
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Collations");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Domains");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("FTS Configurations");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("FTS Dictionaries");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("FTS Parsers");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("FTS Templates");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Foreign Tables");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Functions");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Materialized Views");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Sequences");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Tables");
            //int cont, int v ?
            string[] tablas = AgregarTablas(baseDatos);
            foreach (string tabla in tablas)
            {
                //Agregue la tabla
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes[10].Nodes.Add(tabla);

                //Console.WriteLine(tabla);
            }
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Trigger Functions");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Type");
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Views");
            //Faltan metodos que carguen las vistas, las funciones, las tablas...
        }
        //int cont, int v ?
        private string[] AgregarTablas(string baseDatos)
        {
            string tablas = dbbol.BuscarTablas(baseDatos);

            string[] tablas_;
            if (!tablas.Equals(String.Empty))
            {
                tablas = tablas.Remove(tablas.Length - 1);
                tablas_ = tablas.Split('|');
            }
            else
            {
                tablas_ = new string[] { "" };
            }

            return tablas_;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearBaseDatos cbd = new CrearBaseDatos();
            cbd.ShowDialog();
            ActualizarArbol();
        }
        private void treeDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //se pide la clave del servidor
        }

        private void queryToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbBases.Visible = true;
            rtboxConsulta.Visible = true;
            btbEjecutar.Visible = true;
            button2.Visible = true;
            CargarBaseDatos();
            cbBases.SelectedIndex = 0;
        }

        private void CargarBaseDatos()
        {
            foreach (var item in bases)
            {
                cbBases.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbBases.Visible = false;
            rtboxConsulta.Visible = false;
            btbEjecutar.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = rtboxConsulta.Text;
                if (dbbol.Consulta(consulta, cbBases.Text))
                {
                    rcOutPut.Text = "BIEN"; 
                }
            }
            catch (Exception ex)
            {

                rcOutPut.Text = ex.Message;
            }
            



        }
    }
}
