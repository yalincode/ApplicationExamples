﻿
namespace WareHouseProject
{
    partial class WarehouseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse Name";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(180, 64);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(254, 23);
            this.txtWarehouseName.TabIndex = 1;
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(180, 102);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(254, 43);
            this.btnAddWarehouse.TabIndex = 2;
            this.btnAddWarehouse.Text = "Save New Warehouse";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // WharehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 217);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WharehouseForm";
            this.Text = "Warehouse Operation";
            this.Load += new System.EventHandler(this.WharehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Button btnAddWarehouse;
    }
}