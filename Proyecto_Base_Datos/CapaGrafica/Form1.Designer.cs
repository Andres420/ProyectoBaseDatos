namespace CapaGrafica
{
    partial class Form1
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
            this.cmsMenuDataBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDB = new System.Windows.Forms.TreeView();
            this.cmsMenuDataBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenuDataBase
            // 
            this.cmsMenuDataBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsMenuDataBase.Name = "cmsMenuDataBase";
            this.cmsMenuDataBase.Size = new System.Drawing.Size(160, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem1.Text = "Create Database";
            // 
            // treeDB
            // 
            this.treeDB.Location = new System.Drawing.Point(12, 12);
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
            this.treeDB.Size = new System.Drawing.Size(143, 327);
            this.treeDB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsMenuDataBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeDB;
        private System.Windows.Forms.ContextMenuStrip cmsMenuDataBase;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

