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
    public partial class MenuFunciones : Form
    {
        string database;
        bdBOL bdbol;
        private string buscarFuncion = "SELECT proname FROM pg_proc WHERE pronamespace = 2200";
        private string buscarCuerpo = "SELECT prosrc FROM pg_proc WHERE pronamespace = 2200";

        public MenuFunciones(string database)
        {
            InitializeComponent();
            bdbol = new bdBOL();
            this.database = database;
            cbTipoEntrada.SelectedIndex = 0;
            cbTipoRetorno.SelectedIndex = 0;
            cbTipoParamEl.SelectedIndex = 0;
        }

        private void CargarFunciones()
        {
            cbModificarFuncion.Items.Clear(); cbEliminarFuncion.Items.Clear();
            List<string> funciones = bdbol.CargarVistas(buscarFuncion, database);
            if (funciones.Count > 0)
            {
                funciones.ForEach(delegate (string funcion) { cbModificarFuncion.Items.Add(funcion); cbEliminarFuncion.Items.Add(funcion); });
                cbModificarFuncion.SelectedIndex = 0; cbEliminarFuncion.SelectedIndex = 0;
                btnModificarFuncion.Enabled = true;
                btnEliminarFuncion.Enabled = true;
            }
            else
            {
                btnModificarFuncion.Enabled = false;
                btnEliminarFuncion.Enabled = false;
            }
        }

        private void btnAgregarParametro_Click(object sender, EventArgs e)
        {
            string nombre_parametro = txtNombreParametro.Text;
            string tipo_entrada = cbTipoEntrada.SelectedItem.ToString();
            if (!nombre_parametro.Equals(String.Empty))
            {
                Object[] obj = new Object[]{ tipo_entrada,nombre_parametro };
                dataEntradas.Rows.Add(obj);
                txtNombreParametro.Text = "";
            }
        }

        private void btnEliminarParametro_Click(object sender, EventArgs e)
        {
            if (dataEntradas.SelectedRows.Count > 0)
            {
                dataEntradas.Rows.RemoveAt(dataEntradas.CurrentRow.Index);
                txtNombreParametro.Text = "";
            }
        }

        private void btnCrearFuncion_Click(object sender, EventArgs e)
        {
            if (!txtNombreFuncion.Text.Equals(String.Empty) && !rtbDefinicion.Equals(String.Empty))
            {
                try
                {
                    string crearFuncion = "CREATE FUNCTION " + txtNombreFuncion.Text + "(" + listaEntradas() + ")" + " RETURNS " + 
                        cbTipoRetorno.SelectedItem + " AS $BODY$ " + rtbDefinicion.Text + 
                        " $BODY$ LANGUAGE 'plpgsql' VOLATILE;";
                    Console.WriteLine(crearFuncion);
                    bool funcion = bdbol.Consulta(crearFuncion, database);
                    if (funcion)
                    {
                        MessageBox.Show("Funcion creada");
                        this.Dispose();
                    }
                    else MessageBox.Show("No se pudo crear la funcion");
                    CargarFunciones();
                }
                catch (Exception ex)
                {
                    CargarFunciones();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string listaEntradas()
        {
            string param = "";
            foreach (DataGridViewRow row in dataEntradas.Rows)
            {
                string tipo = row.Cells[0].Value.ToString();
                string nombre = '"'+row.Cells[1].Value.ToString()+'"';
                if(!tipo.Equals(String.Empty) && !nombre.Equals(String.Empty)) param = param +"IN "+ nombre + " " + tipo +",";
            }
            if (!param.Equals(String.Empty)) param = param.Remove(param.Length - 1, 1);
            return param;
        }

        private void cbModificarFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> prosrc = bdbol.CargarVistas(buscarCuerpo + " AND proname = '" + cbModificarFuncion.SelectedItem + "'", database);
            if(prosrc.Count > 0) rtbModificarFuncion.Text = prosrc[0];
        }

        private void MenuFunciones_Load(object sender, EventArgs e)
        {
            CargarFunciones();
        }

        private void btnEliminarFuncion_Click(object sender, EventArgs e)
        {
            string funcion = cbEliminarFuncion.SelectedItem.ToString();
            try
            {
                bool eliminado = bdbol.Consulta("DROP FUNCTION " + cbEliminarFuncion.SelectedItem + '(' + listaParam() + ");", database);
                if (eliminado)
                {
                    MessageBox.Show("Funcion Eliminada");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la funcion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string listaParam()
        {
            string param = "";
            foreach (DataGridViewRow row in dataParametroEli.Rows)
            {
                string tipo = row.Cells[0].Value.ToString();
                if (!tipo.Equals(String.Empty)) param = param + tipo + ",";
            }
            if (!param.Equals(String.Empty)) param = param.Remove(param.Length - 1, 1);
            return param;
        }

        private void btnAgregarParamEl_Click(object sender, EventArgs e)
        {
            string tipoparametro = cbTipoParamEl.SelectedItem.ToString();
            if (!tipoparametro.Equals(String.Empty))
            {
                Object obj = tipoparametro;
                dataParametroEli.Rows.Add(obj);
            }
        }

        private void btnModificarFuncion_Click(object sender, EventArgs e)
        {
            string src = rtbModificarFuncion.Text;
            string modificar_consult = "UPDATE pg_proc SET prosrc = '" + src + "' WHERE proname = '" + cbModificarFuncion.SelectedItem + "'";
            try
            {
                bool modificado = bdbol.Consulta(modificar_consult, database);
                if (modificado)
                {
                    MessageBox.Show("Funcion modificada");
                    this.Dispose();
                }
                else MessageBox.Show("No se pudo modificar la funcion");
            }
            catch (Exception ex)
            {
                CargarFunciones();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
