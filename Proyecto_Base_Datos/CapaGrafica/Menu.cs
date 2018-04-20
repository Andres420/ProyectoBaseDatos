using BDBOL;
using Npgsql;
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
        private ContextMenuStrip BDMenu;

        public Menu()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbbol = new bdBOL();
            cbBases.Visible = false;
            rtboxConsulta.Visible = false;
            btbEjecutar.Visible = false;
            button2.Visible = false;
            ActualizarArbol();
            BDMenu = new ContextMenuStrip();
        }
        /// <summary>
        /// Se encarga de cargar los nombres de las bases de datos
        /// y los agrega como strings al arbol
        /// </summary>
        private void ActualizarArbol()
        {

            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            // treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add() linea para agregar las bases de datos al arbol
            bases = dbbol.CargarNombreDB();
            int cont = 0;
            foreach (var item in bases)
            {
               BDMenu = new ContextMenuStrip();

                //Create some menu items.
                ToolStripMenuItem viewLabel = new ToolStripMenuItem();
                viewLabel.Text = "View Options";
                viewLabel.Click += this.ClickView;
                ToolStripMenuItem FLabel = new ToolStripMenuItem();
                FLabel.Text = "Function Options";
                ToolStripMenuItem TLabel = new ToolStripMenuItem();
                TLabel.Text = "Triggers Options";
                BDMenu.Items.AddRange(new ToolStripMenuItem[] { viewLabel,FLabel,TLabel });
                BDMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BD_Click);
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item).ContextMenuStrip = BDMenu;/// aqui evento
                baseDatos = item;
                AgregarCompo(cont);


                cont++;
                //TODO: Implementar metodo para agregar todas las opciones a cada base de datos
            }

        }

        private void ClickView(object sender, EventArgs e)
        {
            ////Evento para mostrar la vara de las vistas
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
            

            ContextMenuStrip tableMenu = new ContextMenuStrip();

            //Create some menu items.
            ToolStripMenuItem oLabel = new ToolStripMenuItem();
            oLabel.Text = "Table Options";
            tableMenu.Items.AddRange(new ToolStripMenuItem[]{oLabel});
            tableMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Table_Click);
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Tables").ContextMenuStrip = tableMenu;
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

        /// <summary>
        /// Se debe crear la ventana para la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Table_Click(object sender, EventArgs e)
        {
            TreeNode n = treeDB.SelectedNode;
            TreeNode p1 = n.Parent;
            TreeNode p2 = p1.Parent;
            TreeNode p3 = p2.Parent;
            string based = p3.ToString();

            ActualizarArbol();
        }

        private void BD_Click(object sender, EventArgs e)
        {
           
            
        }


        private void treeDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
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
            rcOutPut.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Char[] cont;
                string consulta = rtboxConsulta.Text.Trim();
                cont = consulta.ToCharArray();
                string s = cont[0].ToString() + cont[1].ToString() + cont[2].ToString() + cont[3].ToString() + cont[4].ToString() + cont[5].ToString();
                NpgsqlDataAdapter a = dbbol.ConsultaSelect(consulta, cbBases.SelectedItem.ToString());
                if (s.ToLower().Equals("select"))
                {
                    Tables t = new Tables(cbBases.SelectedItem.ToString(), consulta);
                    t.Show();
                }
                
                else if ( a != null  )
                {
                    Tables t = new Tables(a);
                    t.Show();
                }
                else if (dbbol.Consulta(consulta, cbBases.SelectedItem.ToString()))
                {
                    rcOutPut.Text = "Query successfully complete";
                    ActualizarArbol();
                }
            }
            catch (Exception ex)
            {

                rcOutPut.Text = ex.Message;
            }
            



        }

        private void cmsMenuDataBase_Opening(object sender, CancelEventArgs e)
        {

        }

        private void updateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarArbol();
        }
    }
}
