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
    public partial class CrearSequenceFrm : Form
    {
        private bdBOL dbbol;
        private List<String> bases;

        public CrearSequenceFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Char[] cont;
                string consulta = String.Format("CREATE SEQUENCE public.\"{0}\"" +
    "INCREMENT {1}" +
    "START {2}" +
    "MINVALUE {3}" +
    "MAXVALUE {4}" +
";" +

"ALTER SEQUENCE public.\"{5}\"" +
    "OWNER TO postgres;", txtNombre.Text, txtIncrement.Text, txtStart.Text, txtMinValue.Text, txtMaxValue.Text,txtNombre.Text);
                cont = consulta.ToCharArray();
                string s = cont[0].ToString() + cont[1].ToString() + cont[2].ToString() + cont[3].ToString() + cont[4].ToString() + cont[5].ToString();
                if (dbbol.Consulta(consulta, cbBases.SelectedItem.ToString()))
                {
                    MessageBox.Show("Sequence Created");
                    clearInfo();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void clearInfo()
        {
            txtNombre.Text = "";
            txtIncrement.Text = "";
            txtStart.Text = "";
            txtMinValue.Text = "";
            txtMaxValue.Text = "";
        }

        private void CreateSquence_Load(object sender, EventArgs e)
        {

            dbbol = new bdBOL();
            bases = dbbol.CargarNombreDB();
            foreach (var item in bases)
            {
                cbBases.Items.Add(item);
            }
            cbBases.SelectedIndex = 0;
        }
    }
}
