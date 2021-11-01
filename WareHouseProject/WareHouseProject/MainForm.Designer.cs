
namespace WareHouseProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.warehouseOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınAndOutOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferBetweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseOperationsToolStripMenuItem,
            this.ınAndOutOperationsToolStripMenuItem,
            this.transferOperationsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // warehouseOperationsToolStripMenuItem
            // 
            this.warehouseOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWarehouseToolStripMenuItem,
            this.warehouseListToolStripMenuItem});
            this.warehouseOperationsToolStripMenuItem.Name = "warehouseOperationsToolStripMenuItem";
            this.warehouseOperationsToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.warehouseOperationsToolStripMenuItem.Text = "Warehouse Operations";
            // 
            // newWarehouseToolStripMenuItem
            // 
            this.newWarehouseToolStripMenuItem.Name = "newWarehouseToolStripMenuItem";
            this.newWarehouseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newWarehouseToolStripMenuItem.Text = "New Warehouse";
            this.newWarehouseToolStripMenuItem.Click += new System.EventHandler(this.newWarehouseToolStripMenuItem_Click);
            // 
            // warehouseListToolStripMenuItem
            // 
            this.warehouseListToolStripMenuItem.Name = "warehouseListToolStripMenuItem";
            this.warehouseListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.warehouseListToolStripMenuItem.Text = "Warehouse List";
            this.warehouseListToolStripMenuItem.Click += new System.EventHandler(this.warehouseListToolStripMenuItem_Click);
            // 
            // ınAndOutOperationsToolStripMenuItem
            // 
            this.ınAndOutOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınOperationsToolStripMenuItem,
            this.outOperationsToolStripMenuItem});
            this.ınAndOutOperationsToolStripMenuItem.Name = "ınAndOutOperationsToolStripMenuItem";
            this.ınAndOutOperationsToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.ınAndOutOperationsToolStripMenuItem.Text = "In and Out Operations";
            // 
            // ınOperationsToolStripMenuItem
            // 
            this.ınOperationsToolStripMenuItem.Name = "ınOperationsToolStripMenuItem";
            this.ınOperationsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ınOperationsToolStripMenuItem.Text = "In Operations";
            // 
            // outOperationsToolStripMenuItem
            // 
            this.outOperationsToolStripMenuItem.Name = "outOperationsToolStripMenuItem";
            this.outOperationsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.outOperationsToolStripMenuItem.Text = "Out Operations";
            // 
            // transferOperationsToolStripMenuItem
            // 
            this.transferOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferBetweenToolStripMenuItem});
            this.transferOperationsToolStripMenuItem.Name = "transferOperationsToolStripMenuItem";
            this.transferOperationsToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.transferOperationsToolStripMenuItem.Text = "Transfer Operations";
            // 
            // transferBetweenToolStripMenuItem
            // 
            this.transferBetweenToolStripMenuItem.Name = "transferBetweenToolStripMenuItem";
            this.transferBetweenToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.transferBetweenToolStripMenuItem.Text = "Transfer Between Warehouses";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 607);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseSolitions V1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem warehouseOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınAndOutOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferBetweenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseListToolStripMenuItem;
    }
}

