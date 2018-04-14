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
            this.bd = bd;
            this.consulta = consulta;
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            bdbol = new bdBOL();
            //DataTableReader reader = bdbol.ConsultaSelect(consulta, bd);

            // DataSetTables.Tables.Add(bdbol.ConsultaSelect(consulta, bd));

            DataTable table = new DataTable();
            table.Load(bdbol.ConsultaSelect(consulta, bd));
            
    
            ///DataTableReader reader = new DataTableReader(table);
                DataSetTables.Load(bdbol.ConsultaSelect(consulta, bd), LoadOption.OverwriteChanges, table);
            //bdbol.ConsultaSelect(consulta, bd)

            dataGridView1.DataSource = DataSetTables;
            
            //DataSetTables.Load(bdbol.ConsultaSelect(consulta, bd),Load,);
            
            bdbol.CerrarConsulta();


        }
    }
}
