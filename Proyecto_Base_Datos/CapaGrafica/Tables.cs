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
    public partial class Tables : Form
    {
        private bdBOL bdbol;
        private string bd;
        private string consulta;
        private DataSet ds;
        public Tables(string bd, string consulta)
        {
            InitializeComponent();
            this.CenterToParent();
            this.bd = bd;
            this.consulta = consulta;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            try
            {
                bdbol = new bdBOL();
                ds = new DataSet();
                DataTable table = new DataTable();
                ds.Tables.Add(table);

                //Crear transportador

                bdbol.ConsultaSelect(consulta, bd).Fill(table);

                dataGridView1.DataSource = table;
                bdbol.CerrarConsulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                
            }
      
        }
    }
}
