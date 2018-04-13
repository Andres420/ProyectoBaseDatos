namespace CapaGrafica
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DataBases");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LocalHost", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Server", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.cmsMenuDataBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDB = new System.Windows.Forms.TreeView();
            this.rtboxConsulta = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBases = new System.Windows.Forms.ComboBox();
            this.rcOutPut = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btbEjecutar = new System.Windows.Forms.Button();
            this.updateDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.npgsqlDbColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsMenuDataBase.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npgsqlDbColumnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMenuDataBase
            // 
            this.cmsMenuDataBase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuDataBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.updateDatabaseToolStripMenuItem});
            this.cmsMenuDataBase.Name = "cmsMenuDataBase";
            this.cmsMenuDataBase.Size = new System.Drawing.Size(164, 48);
            this.cmsMenuDataBase.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuDataBase_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Create Database";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // treeDB
            // 
            this.treeDB.Location = new System.Drawing.Point(11, 34);
            this.treeDB.Margin = new System.Windows.Forms.Padding(2);
            this.treeDB.Name = "treeDB";
            treeNode1.ContextMenuStrip = this.cmsMenuDataBase;
            treeNode1.Name = "nBD";
            treeNode1.Text = "DataBases";
            treeNode2.Name = "nlh";
            treeNode2.Text = "LocalHost";
            treeNode3.Name = "nServer";
            treeNode3.Text = "Server";
            this.treeDB.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeDB.Size = new System.Drawing.Size(342, 429);
            this.treeDB.TabIndex = 0;
            this.treeDB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDB_AfterSelect);
            // 
            // rtboxConsulta
            // 
            this.rtboxConsulta.Location = new System.Drawing.Point(387, 83);
            this.rtboxConsulta.Name = "rtboxConsulta";
            this.rtboxConsulta.Size = new System.Drawing.Size(488, 325);
            this.rtboxConsulta.TabIndex = 1;
            this.rtboxConsulta.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolsToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.herramientasToolStripMenuItem.Text = "Tools";
            // 
            // queryToolsToolStripMenuItem
            // 
            this.queryToolsToolStripMenuItem.Name = "queryToolsToolStripMenuItem";
            this.queryToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryToolsToolStripMenuItem.Text = "Open Query";
            this.queryToolsToolStripMenuItem.Click += new System.EventHandler(this.queryToolsToolStripMenuItem_Click);
            // 
            // cbBases
            // 
            this.cbBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBases.FormattingEnabled = true;
            this.cbBases.Location = new System.Drawing.Point(387, 31);
            this.cbBases.Name = "cbBases";
            this.cbBases.Size = new System.Drawing.Size(239, 21);
            this.cbBases.TabIndex = 5;
            // 
            // rcOutPut
            // 
            this.rcOutPut.Location = new System.Drawing.Point(387, 432);
            this.rcOutPut.Margin = new System.Windows.Forms.Padding(2);
            this.rcOutPut.Name = "rcOutPut";
            this.rcOutPut.Size = new System.Drawing.Size(488, 109);
            this.rcOutPut.TabIndex = 6;
            this.rcOutPut.Text = "";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CapaGrafica.Properties.Resources.if_button_close_352915;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(689, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbEjecutar
            // 
            this.btbEjecutar.BackgroundImage = global::CapaGrafica.Properties.Resources.if_icon_ios7_bolt_211696;
            this.btbEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEjecutar.Location = new System.Drawing.Point(632, 29);
            this.btbEjecutar.Name = "btbEjecutar";
            this.btbEjecutar.Size = new System.Drawing.Size(50, 50);
            this.btbEjecutar.TabIndex = 3;
            this.btbEjecutar.UseVisualStyleBackColor = true;
            this.btbEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateDatabaseToolStripMenuItem
            // 
            this.updateDatabaseToolStripMenuItem.Name = "updateDatabaseToolStripMenuItem";
            this.updateDatabaseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateDatabaseToolStripMenuItem.Text = "Update Database";
            this.updateDatabaseToolStripMenuItem.Click += new System.EventHandler(this.updateDatabaseToolStripMenuItem_Click);
            // 
            // npgsqlDbColumnBindingSource
            // 
            this.npgsqlDbColumnBindingSource.DataSource = typeof(Npgsql.Schema.NpgsqlDbColumn);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 558);
            this.Controls.Add(this.rcOutPut);
            this.Controls.Add(this.cbBases);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btbEjecutar);
            this.Controls.Add(this.rtboxConsulta);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "PgAdmin 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsMenuDataBase.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npgsqlDbColumnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeDB;
        private System.Windows.Forms.ContextMenuStrip cmsMenuDataBase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox rtboxConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolsToolStripMenuItem;
        private System.Windows.Forms.Button btbEjecutar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbBases;
        private System.Windows.Forms.RichTextBox rcOutPut;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseToolStripMenuItem;
        private System.Windows.Forms.BindingSource npgsqlDbColumnBindingSource;
    }
}

