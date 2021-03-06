﻿using BDBOL;
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
                FLabel.Click += this.FunctionView;
                ToolStripMenuItem TLabel = new ToolStripMenuItem();
                TLabel.Text = "Triggers Options";
                TLabel.Click += this.TriggerView;
                BDMenu.Items.AddRange(new ToolStripMenuItem[] { viewLabel, FLabel, TLabel });
                BDMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BD_Click);
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item).ContextMenuStrip = BDMenu;/// aqui evento
                baseDatos = item;
                AgregarCompo(cont);


                cont++;
                //TODO: Implementar metodo para agregar todas las opciones a cada base de datos
            }

        }

        ///Se llama la ventana con las funciones de las vistas
        private void ClickView(object sender, EventArgs e)
        {
            TreeNode n = treeDB.SelectedNode;
            string baseSeleccionada = n.ToString(); //Tiene que tener marcado el nodo de la base de datos
            MenuVistas mv = new MenuVistas(baseSeleccionada.Replace("TreeNode: ", ""));
            mv.ShowDialog();
            ActualizarArbol();
        }

        /// Se llama la ventana de las funciones
        private void FunctionView(object sender, EventArgs e)
        {
            TreeNode n = treeDB.SelectedNode;
            string baseSeleccionada = n.ToString(); //Tiene que tener marcado el nodo de la base de datos
            MenuFunciones mf = new MenuFunciones(baseSeleccionada.Replace("TreeNode: ", ""));
            mf.ShowDialog();
            ActualizarArbol();
        }

        ///Se llama la ventana con los triggers
        private void TriggerView(object sender, EventArgs e)
        {
            TreeNode n = treeDB.SelectedNode;
            string baseSeleccionada = n.ToString(); //Tiene que tener marcado el nodo de la base de datos
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
            ContextMenuStrip squemaMenu = new ContextMenuStrip();
            ToolStripMenuItem aLabel = new ToolStripMenuItem();
            aLabel.Text = "Create Squema";
            squemaMenu.Items.AddRange(new ToolStripMenuItem[] { aLabel });
            squemaMenu.MouseClick += new MouseEventHandler(this.CrearSquema);
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes.Add("Schemas").ContextMenuStrip = squemaMenu;
            string[] schemas = AgregarSquemas_();
            foreach (string schema in schemas)
            {
                //Agregue la tabla
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes.Add(schema);

                //Console.WriteLine(tabla);
            }


            //Agregue la tabla
            AgregarSquemas(cont);


        }

        private string[] AgregarSquemas_()
        {
            string tablas = dbbol.BuscarSequema(baseDatos);

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

        private void CrearSquema(object sender, MouseEventArgs e)
        {
            FrmCreateSquema frm = new FrmCreateSquema();
            frm.Show();
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
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Functions");//7
            List<string> functions = dbbol.CargarVistas("SELECT * FROM pg_proc WHERE pronamespace = 2200;", baseDatos);
            if (functions.Count > 0)
            {
                foreach (string funcion in functions)
                {
                    treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes[7].Nodes.Add(funcion);
                }
            }
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Materialized Views");
            ContextMenuStrip sequenceMenu = new ContextMenuStrip();
            ToolStripMenuItem aLabel = new ToolStripMenuItem();
            aLabel.Text = "Create Sequence";
            sequenceMenu.Items.AddRange(new ToolStripMenuItem[] { aLabel });
            sequenceMenu.MouseClick += new MouseEventHandler(this.CrearSequence);
            treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes.Add("Sequences").ContextMenuStrip = sequenceMenu;
            string[] sequencias = AgregarSequencias(baseDatos);
            foreach (string sequencia in sequencias)
            {
                //Agregue la tabla
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes[9].Nodes.Add(sequencia);

                //Console.WriteLine(tabla);
            }
            ContextMenuStrip tableMenu = new ContextMenuStrip();
            //Create some menu items.
            ToolStripMenuItem oLabel = new ToolStripMenuItem();
            oLabel.Text = "Table Options";
            tableMenu.Items.AddRange(new ToolStripMenuItem[] { oLabel });
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
            List<string> views = dbbol.CargarVistas("SELECT table_name from INFORMATION_SCHEMA.views WHERE table_schema = 'public';", baseDatos);
            if (views.Count > 0)
            {
                foreach (string view in views)
                {
                    treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes[cont].Nodes[6].Nodes[0].Nodes[13].Nodes.Add(view);
                }
            }
            
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

        private string[] AgregarSequencias(string baseDatos)
        {
            string tablas = dbbol.BuscarSequencias(baseDatos);

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

        private void CrearSequence(object sender, EventArgs e)
        {
            Console.WriteLine();
            CrearSequenceFrm frm = new CrearSequenceFrm();
            frm.Show();
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

                else if (a != null)
                {
                    Tables t = new Tables(a);
                    t.Show();
                }
                else if (dbbol.Consulta(consulta, cbBases.SelectedItem.ToString()))
                {
                    rcOutPut.Text = "Query successfully complete";
                    ActualizarArbol();
                }
                dbbol.CerrarConsulta();
            }
            catch (Exception ex)
            {
                dbbol.CerrarConsulta();
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