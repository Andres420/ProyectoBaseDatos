namespace CapaGrafica
{
    partial class FrmCreateSquema
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
            this.txtSquemaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSquemaName
            // 
            this.txtSquemaName.Location = new System.Drawing.Point(13, 40);
            this.txtSquemaName.Name = "txtSquemaName";
            this.txtSquemaName.Size = new System.Drawing.Size(100, 20);
            this.txtSquemaName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Squema Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBases
            // 
            this.cbBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBases.FormattingEnabled = true;
            this.cbBases.Location = new System.Drawing.Point(12, 13);
            this.cbBases.Name = "cbBases";
            this.cbBases.Size = new System.Drawing.Size(121, 21);
            this.cbBases.TabIndex = 3;
            // 
            // FrmCreateSquema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 92);
            this.Controls.Add(this.cbBases);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSquemaName);
            this.Name = "FrmCreateSquema";
            this.Text = "Creating Squema...";
            this.Load += new System.EventHandler(this.FrmCreateSquema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquemaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBases;
    }
}