namespace CapaGrafica
{
    partial class MenuFunciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCrearFuncion = new System.Windows.Forms.Button();
            this.btnEliminarParametro = new System.Windows.Forms.Button();
            this.btnAgregarParametro = new System.Windows.Forms.Button();
            this.dataEntradas = new System.Windows.Forms.DataGridView();
            this.cbTipoEntrada = new System.Windows.Forms.ComboBox();
            this.cbTipoRetorno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDefinicion = new System.Windows.Forms.RichTextBox();
            this.txtLenguaje = new System.Windows.Forms.TextBox();
            this.txtNombreParametro = new System.Windows.Forms.TextBox();
            this.txtNombreFuncion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificarFuncion = new System.Windows.Forms.Button();
            this.cbModificarFuncion = new System.Windows.Forms.ComboBox();
            this.rtbModificarFuncion = new System.Windows.Forms.RichTextBox();
            this.cbEliminarFuncion = new System.Windows.Forms.ComboBox();
            this.btnEliminarFuncion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataParametroEli = new System.Windows.Forms.DataGridView();
            this.parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarParamEl = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoParamEl = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntradas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataParametroEli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCrearFuncion);
            this.tabPage1.Controls.Add(this.btnEliminarParametro);
            this.tabPage1.Controls.Add(this.btnAgregarParametro);
            this.tabPage1.Controls.Add(this.dataEntradas);
            this.tabPage1.Controls.Add(this.cbTipoEntrada);
            this.tabPage1.Controls.Add(this.cbTipoRetorno);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rtbDefinicion);
            this.tabPage1.Controls.Add(this.txtLenguaje);
            this.tabPage1.Controls.Add(this.txtNombreParametro);
            this.tabPage1.Controls.Add(this.txtNombreFuncion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Funcion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCrearFuncion
            // 
            this.btnCrearFuncion.Location = new System.Drawing.Point(658, 371);
            this.btnCrearFuncion.Name = "btnCrearFuncion";
            this.btnCrearFuncion.Size = new System.Drawing.Size(104, 23);
            this.btnCrearFuncion.TabIndex = 7;
            this.btnCrearFuncion.Text = "Crear Funcion";
            this.btnCrearFuncion.UseVisualStyleBackColor = true;
            this.btnCrearFuncion.Click += new System.EventHandler(this.btnCrearFuncion_Click);
            // 
            // btnEliminarParametro
            // 
            this.btnEliminarParametro.Location = new System.Drawing.Point(90, 327);
            this.btnEliminarParametro.Name = "btnEliminarParametro";
            this.btnEliminarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarParametro.TabIndex = 7;
            this.btnEliminarParametro.Text = "Eliminar";
            this.btnEliminarParametro.UseVisualStyleBackColor = true;
            this.btnEliminarParametro.Click += new System.EventHandler(this.btnEliminarParametro_Click);
            // 
            // btnAgregarParametro
            // 
            this.btnAgregarParametro.Location = new System.Drawing.Point(9, 327);
            this.btnAgregarParametro.Name = "btnAgregarParametro";
            this.btnAgregarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParametro.TabIndex = 7;
            this.btnAgregarParametro.Text = "Agregar";
            this.btnAgregarParametro.UseVisualStyleBackColor = true;
            this.btnAgregarParametro.Click += new System.EventHandler(this.btnAgregarParametro_Click);
            // 
            // dataEntradas
            // 
            this.dataEntradas.AllowUserToAddRows = false;
            this.dataEntradas.AllowUserToDeleteRows = false;
            this.dataEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.nombre});
            this.dataEntradas.Location = new System.Drawing.Point(9, 161);
            this.dataEntradas.MultiSelect = false;
            this.dataEntradas.Name = "dataEntradas";
            this.dataEntradas.ReadOnly = true;
            this.dataEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEntradas.Size = new System.Drawing.Size(279, 107);
            this.dataEntradas.TabIndex = 6;
            // 
            // cbTipoEntrada
            // 
            this.cbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEntrada.FormattingEnabled = true;
            this.cbTipoEntrada.Items.AddRange(new object[] {
            "integer",
            "character varying",
            "character",
            "date",
            "serial",
            "text",
            "boolean"});
            this.cbTipoEntrada.Location = new System.Drawing.Point(100, 300);
            this.cbTipoEntrada.Name = "cbTipoEntrada";
            this.cbTipoEntrada.Size = new System.Drawing.Size(188, 21);
            this.cbTipoEntrada.TabIndex = 5;
            // 
            // cbTipoRetorno
            // 
            this.cbTipoRetorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRetorno.FormattingEnabled = true;
            this.cbTipoRetorno.Items.AddRange(new object[] {
            "integer",
            "character varying",
            "character",
            "date",
            "serial",
            "text",
            "boolean",
            "bytea"});
            this.cbTipoRetorno.Location = new System.Drawing.Point(126, 32);
            this.cbTipoRetorno.Name = "cbTipoRetorno";
            this.cbTipoRetorno.Size = new System.Drawing.Size(162, 21);
            this.cbTipoRetorno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de retorno: ";
            // 
            // rtbDefinicion
            // 
            this.rtbDefinicion.BackColor = System.Drawing.SystemColors.Window;
            this.rtbDefinicion.Location = new System.Drawing.Point(350, 25);
            this.rtbDefinicion.Name = "rtbDefinicion";
            this.rtbDefinicion.Size = new System.Drawing.Size(412, 325);
            this.rtbDefinicion.TabIndex = 2;
            this.rtbDefinicion.Text = "";
            // 
            // txtLenguaje
            // 
            this.txtLenguaje.Enabled = false;
            this.txtLenguaje.Location = new System.Drawing.Point(126, 59);
            this.txtLenguaje.Name = "txtLenguaje";
            this.txtLenguaje.ReadOnly = true;
            this.txtLenguaje.Size = new System.Drawing.Size(162, 20);
            this.txtLenguaje.TabIndex = 1;
            this.txtLenguaje.Text = "plpgsql";
            // 
            // txtNombreParametro
            // 
            this.txtNombreParametro.Location = new System.Drawing.Point(129, 274);
            this.txtNombreParametro.Name = "txtNombreParametro";
            this.txtNombreParametro.Size = new System.Drawing.Size(159, 20);
            this.txtNombreParametro.TabIndex = 1;
            // 
            // txtNombreFuncion
            // 
            this.txtNombreFuncion.Location = new System.Drawing.Point(126, 6);
            this.txtNombreFuncion.Name = "txtNombreFuncion";
            this.txtNombreFuncion.Size = new System.Drawing.Size(162, 20);
            this.txtNombreFuncion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de entrada: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Definicion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parametros de entrada: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lenguaje: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre del parametro: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la funcion: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbModificarFuncion);
            this.tabPage2.Controls.Add(this.cbModificarFuncion);
            this.tabPage2.Controls.Add(this.btnModificarFuncion);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Funcion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbTipoParamEl);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnAgregarParamEl);
            this.tabPage3.Controls.Add(this.dataParametroEli);
            this.tabPage3.Controls.Add(this.cbEliminarFuncion);
            this.tabPage3.Controls.Add(this.btnEliminarFuncion);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Funcion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "Object";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Object";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccione la funcion para modificar: ";
            // 
            // btnModificarFuncion
            // 
            this.btnModificarFuncion.Location = new System.Drawing.Point(633, 371);
            this.btnModificarFuncion.Name = "btnModificarFuncion";
            this.btnModificarFuncion.Size = new System.Drawing.Size(129, 23);
            this.btnModificarFuncion.TabIndex = 1;
            this.btnModificarFuncion.Text = "Modificar Funcion";
            this.btnModificarFuncion.UseVisualStyleBackColor = true;
            this.btnModificarFuncion.Click += new System.EventHandler(this.btnModificarFuncion_Click);
            // 
            // cbModificarFuncion
            // 
            this.cbModificarFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModificarFuncion.FormattingEnabled = true;
            this.cbModificarFuncion.Location = new System.Drawing.Point(196, 6);
            this.cbModificarFuncion.Name = "cbModificarFuncion";
            this.cbModificarFuncion.Size = new System.Drawing.Size(222, 21);
            this.cbModificarFuncion.TabIndex = 2;
            this.cbModificarFuncion.SelectedIndexChanged += new System.EventHandler(this.cbModificarFuncion_SelectedIndexChanged);
            // 
            // rtbModificarFuncion
            // 
            this.rtbModificarFuncion.Location = new System.Drawing.Point(6, 33);
            this.rtbModificarFuncion.Name = "rtbModificarFuncion";
            this.rtbModificarFuncion.Size = new System.Drawing.Size(756, 332);
            this.rtbModificarFuncion.TabIndex = 3;
            this.rtbModificarFuncion.Text = "";
            // 
            // cbEliminarFuncion
            // 
            this.cbEliminarFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminarFuncion.FormattingEnabled = true;
            this.cbEliminarFuncion.Location = new System.Drawing.Point(218, 6);
            this.cbEliminarFuncion.Name = "cbEliminarFuncion";
            this.cbEliminarFuncion.Size = new System.Drawing.Size(212, 21);
            this.cbEliminarFuncion.TabIndex = 5;
            // 
            // btnEliminarFuncion
            // 
            this.btnEliminarFuncion.Location = new System.Drawing.Point(648, 371);
            this.btnEliminarFuncion.Name = "btnEliminarFuncion";
            this.btnEliminarFuncion.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarFuncion.TabIndex = 4;
            this.btnEliminarFuncion.Text = "Eliminar Funcion";
            this.btnEliminarFuncion.UseVisualStyleBackColor = true;
            this.btnEliminarFuncion.Click += new System.EventHandler(this.btnEliminarFuncion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seleccione la funcion que desea eliminar: ";
            // 
            // dataParametroEli
            // 
            this.dataParametroEli.AllowUserToAddRows = false;
            this.dataParametroEli.AllowUserToDeleteRows = false;
            this.dataParametroEli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataParametroEli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParametroEli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parametro});
            this.dataParametroEli.Location = new System.Drawing.Point(6, 68);
            this.dataParametroEli.Name = "dataParametroEli";
            this.dataParametroEli.ReadOnly = true;
            this.dataParametroEli.Size = new System.Drawing.Size(424, 162);
            this.dataParametroEli.TabIndex = 6;
            // 
            // parametro
            // 
            this.parametro.HeaderText = "Parametro";
            this.parametro.Name = "parametro";
            this.parametro.ReadOnly = true;
            this.parametro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnAgregarParamEl
            // 
            this.btnAgregarParamEl.Location = new System.Drawing.Point(313, 235);
            this.btnAgregarParamEl.Name = "btnAgregarParamEl";
            this.btnAgregarParamEl.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParamEl.TabIndex = 7;
            this.btnAgregarParamEl.Text = "Agregar";
            this.btnAgregarParamEl.UseVisualStyleBackColor = true;
            this.btnAgregarParamEl.Click += new System.EventHandler(this.btnAgregarParamEl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Seleccione el parametro: ";
            // 
            // cbTipoParamEl
            // 
            this.cbTipoParamEl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoParamEl.FormattingEnabled = true;
            this.cbTipoParamEl.Items.AddRange(new object[] {
            "integer",
            "character varying",
            "character",
            "date",
            "serial",
            "text",
            "boolean"});
            this.cbTipoParamEl.Location = new System.Drawing.Point(139, 236);
            this.cbTipoParamEl.Name = "cbTipoParamEl";
            this.cbTipoParamEl.Size = new System.Drawing.Size(168, 21);
            this.cbTipoParamEl.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Parametros de la funcion: ";
            // 
            // MenuFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuFunciones";
            this.Text = "Menu Funciones";
            this.Load += new System.EventHandler(this.MenuFunciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntradas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataParametroEli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCrearFuncion;
        private System.Windows.Forms.Button btnAgregarParametro;
        private System.Windows.Forms.DataGridView dataEntradas;
        private System.Windows.Forms.ComboBox cbTipoEntrada;
        private System.Windows.Forms.ComboBox cbTipoRetorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDefinicion;
        private System.Windows.Forms.TextBox txtLenguaje;
        private System.Windows.Forms.TextBox txtNombreFuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreParametro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.RichTextBox rtbModificarFuncion;
        private System.Windows.Forms.ComboBox cbModificarFuncion;
        private System.Windows.Forms.Button btnModificarFuncion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEliminarFuncion;
        private System.Windows.Forms.Button btnEliminarFuncion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoParamEl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarParamEl;
        private System.Windows.Forms.DataGridView dataParametroEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametro;
        private System.Windows.Forms.Label label11;
    }
}