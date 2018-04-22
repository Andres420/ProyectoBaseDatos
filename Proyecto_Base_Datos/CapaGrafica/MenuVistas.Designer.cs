namespace CapaGrafica
{
    partial class MenuVistas
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreVista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearVista = new System.Windows.Forms.Button();
            this.rtbCrearVista = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnModificarVista = new System.Windows.Forms.Button();
            this.rtbModificarVista = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModificarVista = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarVista = new System.Windows.Forms.Button();
            this.cbEliminarVista = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(526, 239);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNombreVista);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCrearVista);
            this.tabPage1.Controls.Add(this.rtbCrearVista);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Vista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consulta para la vista: ";
            // 
            // txtNombreVista
            // 
            this.txtNombreVista.Location = new System.Drawing.Point(122, 7);
            this.txtNombreVista.Name = "txtNombreVista";
            this.txtNombreVista.Size = new System.Drawing.Size(218, 20);
            this.txtNombreVista.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre para la vista: ";
            // 
            // btnCrearVista
            // 
            this.btnCrearVista.Location = new System.Drawing.Point(384, 5);
            this.btnCrearVista.Name = "btnCrearVista";
            this.btnCrearVista.Size = new System.Drawing.Size(128, 23);
            this.btnCrearVista.TabIndex = 2;
            this.btnCrearVista.Text = "Crear Vista";
            this.btnCrearVista.UseVisualStyleBackColor = true;
            this.btnCrearVista.Click += new System.EventHandler(this.btnCrearVista_Click);
            // 
            // rtbCrearVista
            // 
            this.rtbCrearVista.Location = new System.Drawing.Point(7, 46);
            this.rtbCrearVista.Name = "rtbCrearVista";
            this.rtbCrearVista.Size = new System.Drawing.Size(505, 161);
            this.rtbCrearVista.TabIndex = 1;
            this.rtbCrearVista.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnModificarVista);
            this.tabPage2.Controls.Add(this.rtbModificarVista);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbModificarVista);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Vista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModificarVista
            // 
            this.btnModificarVista.Location = new System.Drawing.Point(382, 4);
            this.btnModificarVista.Name = "btnModificarVista";
            this.btnModificarVista.Size = new System.Drawing.Size(130, 23);
            this.btnModificarVista.TabIndex = 3;
            this.btnModificarVista.Text = "Modificar Vista";
            this.btnModificarVista.UseVisualStyleBackColor = true;
            this.btnModificarVista.Click += new System.EventHandler(this.btnModificarVista_Click);
            // 
            // rtbModificarVista
            // 
            this.rtbModificarVista.Location = new System.Drawing.Point(9, 46);
            this.rtbModificarVista.Name = "rtbModificarVista";
            this.rtbModificarVista.Size = new System.Drawing.Size(506, 161);
            this.rtbModificarVista.TabIndex = 2;
            this.rtbModificarVista.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nueva consulta para la vista: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecciona la vista: ";
            // 
            // cbModificarVista
            // 
            this.cbModificarVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModificarVista.FormattingEnabled = true;
            this.cbModificarVista.Location = new System.Drawing.Point(114, 6);
            this.cbModificarVista.Name = "cbModificarVista";
            this.cbModificarVista.Size = new System.Drawing.Size(262, 21);
            this.cbModificarVista.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnEliminarVista);
            this.tabPage3.Controls.Add(this.cbEliminarVista);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(518, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Vista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Seleccione vista para eliminar: ";
            // 
            // btnEliminarVista
            // 
            this.btnEliminarVista.Location = new System.Drawing.Point(437, 4);
            this.btnEliminarVista.Name = "btnEliminarVista";
            this.btnEliminarVista.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVista.TabIndex = 1;
            this.btnEliminarVista.Text = "Eliminar";
            this.btnEliminarVista.UseVisualStyleBackColor = true;
            this.btnEliminarVista.Click += new System.EventHandler(this.btnEliminarVista_Click);
            // 
            // cbEliminarVista
            // 
            this.cbEliminarVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminarVista.FormattingEnabled = true;
            this.cbEliminarVista.Location = new System.Drawing.Point(162, 6);
            this.cbEliminarVista.Name = "cbEliminarVista";
            this.cbEliminarVista.Size = new System.Drawing.Size(269, 21);
            this.cbEliminarVista.TabIndex = 0;
            // 
            // MenuVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 263);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuVistas";
            this.Text = "Menu Vistas";
            this.Load += new System.EventHandler(this.MenuVistas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreVista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearVista;
        private System.Windows.Forms.RichTextBox rtbCrearVista;
        private System.Windows.Forms.Button btnModificarVista;
        private System.Windows.Forms.RichTextBox rtbModificarVista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbModificarVista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarVista;
        private System.Windows.Forms.ComboBox cbEliminarVista;
    }
}