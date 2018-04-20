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
    public partial class Tables : Form
    {
        private bdBOL bdbol;
        private string bd;
        private string consulta;
        private DataSet ds;
        private NpgsqlDataAdapter ad;
        public Tables(string bd, string consulta)
        {
            InitializeComponent();
            this.CenterToParent();
            this.bd = bd;
            this.consulta = consulta;
        }

        public Tables(NpgsqlDataAdapter adap)
        {
            InitializeComponent();
            this.CenterToParent();
            this.ad = adap;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            try
            {
                if (ad == null)
                {
                    bdbol = new bdBOL();
                    ds = new DataSet();
                    DataTable table = new DataTable();
                    ds.Tables.Add(table);
                    bdbol.ConsultaSelect(consulta, bd).Fill(table);
                    dataGridView1.DataSource = table;
                    bdbol.CerrarConsulta();
                }
                else
                {
                    ds = new DataSet();
                    DataTable table = new DataTable();
                    ds.Tables.Add(table);
                    ad.Fill(table);
                    dataGridView1.DataSource = table;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                
            }
      
        }
    }
}
