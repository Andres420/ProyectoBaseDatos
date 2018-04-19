namespace CapaGrafica
{
    partial class CrearBaseDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearBaseDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrebase = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbBaseDatos_mod = new System.Windows.Forms.ComboBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtModificarBase = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbBaseDatos_eli = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre para la Base de Datos:";
            // 
            // txtNombrebase
            // 
            this.txtNombrebase.Location = new System.Drawing.Point(167, 9);
            this.txtNombrebase.Name = "txtNombrebase";
            this.txtNombrebase.Size = new System.Drawing.Size(194, 20);
            this.txtNombrebase.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(310, 112);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 167);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCrear);
            this.tabPage1.Controls.Add(this.txtNombrebase);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Base Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnModificar);
            this.tabPage2.Controls.Add(this.txtModificarBase);
            this.tabPage2.Controls.Add(this.lblNuevoNombre);
            this.tabPage2.Controls.Add(this.cbBaseDatos_mod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Base Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.cbBaseDatos_eli);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 141);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Base Datos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbBaseDatos_mod
            // 
            this.cbBaseDatos_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaseDatos_mod.FormattingEnabled = true;
            this.cbBaseDatos_mod.Location = new System.Drawing.Point(6, 6);
            this.cbBaseDatos_mod.Name = "cbBaseDatos_mod";
            this.cbBaseDatos_mod.Size = new System.Drawing.Size(237, 21);
            this.cbBaseDatos_mod.TabIndex = 0;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(6, 37);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(188, 13);
            this.lblNuevoNombre.TabIndex = 1;
            this.lblNuevoNombre.Text = "Nuevo nombre para la base de datos: ";
            // 
            // txtModificarBase
            // 
            this.txtModificarBase.Location = new System.Drawing.Point(200, 34);
            this.txtModificarBase.Name = "txtModificarBase";
            this.txtModificarBase.Size = new System.Drawing.Size(185, 20);
            this.txtModificarBase.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(310, 112);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbBaseDatos_eli
            // 
            this.cbBaseDatos_eli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaseDatos_eli.FormattingEnabled = true;
            this.cbBaseDatos_eli.Location = new System.Drawing.Point(6, 6);
            this.cbBaseDatos_eli.Name = "cbBaseDatos_eli";
            this.cbBaseDatos_eli.Size = new System.Drawing.Size(266, 21);
            this.cbBaseDatos_eli.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(310, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CrearBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 191);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearBaseDatos";
            this.Text = "CrearBaseDatos";
            this.Load += new System.EventHandler(this.CrearBaseDatos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrebase;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModificarBase;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.ComboBox cbBaseDatos_mod;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbBaseDatos_eli;
    }
}