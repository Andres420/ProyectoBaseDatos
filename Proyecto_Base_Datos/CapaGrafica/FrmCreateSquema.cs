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
    public partial class FrmCreateSquema : Form
    {
        private bdBOL dbbol;
        private List<String> bases;
        public FrmCreateSquema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Char[] cont;
                string consulta = String.Format("CREATE SCHEMA {0} " +
    "AUTHORIZATION postgres; ", txtSquemaName.Text);
                cont = consulta.ToCharArray();
                string s = cont[0].ToString() + cont[1].ToString() + cont[2].ToString() + cont[3].ToString() + cont[4].ToString() + cont[5].ToString();
                if (dbbol.Consulta(consulta, cbBases.SelectedItem.ToString()))
                {
                    MessageBox.Show("Squema Created Succesfully");
                    txtSquemaName.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmCreateSquema_Load(object sender, EventArgs e)
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
