
namespace EticaretWFA
{
    partial class Sepetim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdSepet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnProductCountUp = new System.Windows.Forms.Button();
            this.btnProductCountDown = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.btnSiparisVer);
            this.panel2.Controls.Add(this.btnProductCountDown);
            this.panel2.Controls.Add(this.btnProductCountUp);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 100);
            this.panel2.TabIndex = 1;
            // 
            // grdSepet
            // 
            this.grdSepet.BackgroundColor = System.Drawing.Color.Tomato;
            this.grdSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSepet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSepet.Location = new System.Drawing.Point(0, 100);
            this.grdSepet.MultiSelect = false;
            this.grdSepet.Name = "grdSepet";
            this.grdSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSepet.Size = new System.Drawing.Size(767, 297);
            this.grdSepet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEPETİM";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(12, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnProductCountUp
            // 
            this.btnProductCountUp.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProductCountUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductCountUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProductCountUp.Location = new System.Drawing.Point(540, 26);
            this.btnProductCountUp.Name = "btnProductCountUp";
            this.btnProductCountUp.Size = new System.Drawing.Size(104, 48);
            this.btnProductCountUp.TabIndex = 1;
            this.btnProductCountUp.Text = "Seçili Ürünü Arttır";
            this.btnProductCountUp.UseVisualStyleBackColor = false;
            // 
            // btnProductCountDown
            // 
            this.btnProductCountDown.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProductCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductCountDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProductCountDown.Location = new System.Drawing.Point(650, 26);
            this.btnProductCountDown.Name = "btnProductCountDown";
            this.btnProductCountDown.Size = new System.Drawing.Size(105, 48);
            this.btnProductCountDown.TabIndex = 2;
            this.btnProductCountDown.Text = "Seçili Ürünü Azalt";
            this.btnProductCountDown.UseVisualStyleBackColor = false;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSiparisVer.Location = new System.Drawing.Point(260, 18);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(221, 66);
            this.btnSiparisVer.TabIndex = 1;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            // 
            // Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 497);
            this.Controls.Add(this.grdSepet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sepetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.Sepetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductCountDown;
        private System.Windows.Forms.Button btnProductCountUp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSiparisVer;
    }
}