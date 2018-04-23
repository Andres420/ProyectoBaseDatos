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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFuncion = new System.Windows.Forms.TextBox();
            this.rtbDefinicion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataEntradas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarParametro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLenguaje = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreParametro = new System.Windows.Forms.TextBox();
            this.btnEliminarParametro = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntradas)).BeginInit();
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
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnEliminarParametro);
            this.tabPage1.Controls.Add(this.btnAgregarParametro);
            this.tabPage1.Controls.Add(this.dataEntradas);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
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
            // tabPage2
            // 
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Funcion";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // txtNombreFuncion
            // 
            this.txtNombreFuncion.Location = new System.Drawing.Point(126, 6);
            this.txtNombreFuncion.Name = "txtNombreFuncion";
            this.txtNombreFuncion.Size = new System.Drawing.Size(162, 20);
            this.txtNombreFuncion.TabIndex = 1;
            // 
            // rtbDefinicion
            // 
            this.rtbDefinicion.Location = new System.Drawing.Point(350, 25);
            this.rtbDefinicion.Name = "rtbDefinicion";
            this.rtbDefinicion.Size = new System.Drawing.Size(412, 170);
            this.rtbDefinicion.TabIndex = 2;
            this.rtbDefinicion.Text = "";
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "integer",
            "character varying",
            "character",
            "date",
            "serial",
            "text",
            "boolean",
            "bytea",
            "table"});
            this.comboBox1.Location = new System.Drawing.Point(126, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "integer",
            "character varying",
            "character",
            "date",
            "serial",
            "text",
            "boolean"});
            this.comboBox2.Location = new System.Drawing.Point(100, 300);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 5;
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
            this.dataEntradas.Name = "dataEntradas";
            this.dataEntradas.ReadOnly = true;
            this.dataEntradas.Size = new System.Drawing.Size(279, 107);
            this.dataEntradas.TabIndex = 6;
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
            // btnAgregarParametro
            // 
            this.btnAgregarParametro.Location = new System.Drawing.Point(9, 327);
            this.btnAgregarParametro.Name = "btnAgregarParametro";
            this.btnAgregarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParametro.TabIndex = 7;
            this.btnAgregarParametro.Text = "Agregar";
            this.btnAgregarParametro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Agregar Funcion";
            this.button2.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lenguaje: ";
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
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
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
            // txtNombreParametro
            // 
            this.txtNombreParametro.Location = new System.Drawing.Point(129, 274);
            this.txtNombreParametro.Name = "txtNombreParametro";
            this.txtNombreParametro.Size = new System.Drawing.Size(159, 20);
            this.txtNombreParametro.TabIndex = 1;
            // 
            // btnEliminarParametro
            // 
            this.btnEliminarParametro.Location = new System.Drawing.Point(90, 327);
            this.btnEliminarParametro.Name = "btnEliminarParametro";
            this.btnEliminarParametro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarParametro.TabIndex = 7;
            this.btnEliminarParametro.Text = "Eliminar";
            this.btnEliminarParametro.UseVisualStyleBackColor = true;
            // 
            // MenuFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuFunciones";
            this.Text = "Menu Funciones";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarParametro;
        private System.Windows.Forms.DataGridView dataEntradas;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDefinicion;
        private System.Windows.Forms.TextBox txtLenguaje;
        private System.Windows.Forms.TextBox txtNombreFuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.TextBox txtNombreParametro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarParametro;
    }
}