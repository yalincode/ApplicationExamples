
namespace WareHouseProject
{
    partial class LoginForm
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
            this.pbloginPicture = new System.Windows.Forms.PictureBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassWord = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbloginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbloginPicture
            // 
            this.pbloginPicture.Location = new System.Drawing.Point(211, 49);
            this.pbloginPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbloginPicture.Name = "pbloginPicture";
            this.pbloginPicture.Size = new System.Drawing.Size(187, 170);
            this.pbloginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbloginPicture.TabIndex = 0;
            this.pbloginPicture.TabStop = false;
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(211, 244);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(187, 23);
            this.txtuserName.TabIndex = 1;
            this.txtuserName.Leave += new System.EventHandler(this.txtuserName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(211, 333);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(187, 28);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtpassWord
            // 
            this.txtpassWord.Location = new System.Drawing.Point(211, 287);
            this.txtpassWord.Name = "txtpassWord";
            this.txtpassWord.PasswordChar = '*';
            this.txtpassWord.Size = new System.Drawing.Size(187, 23);
            this.txtpassWord.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 436);
            this.Controls.Add(this.txtpassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.pbloginPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseSolitions V1.0.0";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbloginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbloginPicture;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtpassWord;
    }
}