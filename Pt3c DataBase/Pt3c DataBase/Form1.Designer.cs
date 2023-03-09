namespace Pt3c_DataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opciónsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETALLESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lLISTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opciónsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opciónsToolStripMenuItem
            // 
            this.opciónsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.comandesToolStripMenuItem});
            this.opciónsToolStripMenuItem.Name = "opciónsToolStripMenuItem";
            this.opciónsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opciónsToolStripMenuItem.Text = "Clients";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETALLESToolStripMenuItem1,
            this.lISTARToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // dETALLESToolStripMenuItem1
            // 
            this.dETALLESToolStripMenuItem1.Name = "dETALLESToolStripMenuItem1";
            this.dETALLESToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dETALLESToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.dETALLESToolStripMenuItem1.Text = "DETALLES";
            this.dETALLESToolStripMenuItem1.Click += new System.EventHandler(this.dETALLESToolStripMenuItem1_Click);
            // 
            // lISTARToolStripMenuItem
            // 
            this.lISTARToolStripMenuItem.Name = "lISTARToolStripMenuItem";
            this.lISTARToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lISTARToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.lISTARToolStripMenuItem.Text = "LISTAR";
            this.lISTARToolStripMenuItem.Click += new System.EventHandler(this.lLISTARToolStripMenuItem_Click);
            // 
            // comandesToolStripMenuItem
            // 
            this.comandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lLISTARToolStripMenuItem});
            this.comandesToolStripMenuItem.Name = "comandesToolStripMenuItem";
            this.comandesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.comandesToolStripMenuItem.Text = "Comandes";
            // 
            // lLISTARToolStripMenuItem
            // 
            this.lLISTARToolStripMenuItem.Name = "lLISTARToolStripMenuItem";
            this.lLISTARToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.lLISTARToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.lLISTARToolStripMenuItem.Text = "LLISTAR";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(358, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(358, 99);
            this.dataGridView1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opciónsToolStripMenuItem;
        private ListView listView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem dETALLESToolStripMenuItem1;
        private ToolStripMenuItem lISTARToolStripMenuItem;
        private ComboBox comboBox1;
        private ToolStripMenuItem comandesToolStripMenuItem;
        private ToolStripMenuItem lLISTARToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private DataGridView dataGridView1;
        private ListBox listBox1;
    }
}