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

        private void CrearBaseDatos_Load(object sender, EventArgs e)
        {
             crearbol = new bdBOL();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!txtNombrebase.Equals(String.Empty))
            {
                bool basecreada = crearbol.CrearBaseDatos(txtNombrebase.Text);
                if (basecreada)
                {
                    MessageBox.Show("Base datos creada");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Se despicho");
                }
            }
            
        }

       
    }
}
