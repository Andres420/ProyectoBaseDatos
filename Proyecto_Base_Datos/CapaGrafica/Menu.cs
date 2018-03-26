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

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbbol = new bdBOL();
            ActualizarArbol();
        }
        /// <summary>
        /// Se encarga de cargar los nombres de las bases de datos
        /// y los agrega como strings al arbol
        /// </summary>
        private void ActualizarArbol()
        {
            // treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add() linea para agregar las bases de datos al arbol
            List<string> bases = dbbol.CargarNombreDB();
            foreach (var item in bases)
            {
                treeDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item);
                //TODO: Implementar metodo para agregar todas las opciones a cada base de datos
            }
    
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearBaseDatos cbd = new CrearBaseDatos();
            cbd.ShowDialog();
        }
    }
}
