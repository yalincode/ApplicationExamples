
namespace CoffeOrderingApp_wfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.MenuYenileme = new System.Windows.Forms.GroupBox();
            this.btnRemoveMenu = new System.Windows.Forms.Button();
            this.btnEkleMenu = new System.Windows.Forms.Button();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.txtMenuCoffee = new System.Windows.Forms.TextBox();
            this.labell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbCake = new System.Windows.Forms.CheckBox();
            this.cbCookie = new System.Windows.Forms.CheckBox();
            this.cbCoffee = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbTall = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoffeeChoice = new System.Windows.Forms.TextBox();
            this.labelll = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSiparisDurumEkrani = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuYenileme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CoffeeTree Coffee Ordering App";
            // 
            // MenuYenileme
            // 
            this.MenuYenileme.BackColor = System.Drawing.Color.DarkSalmon;
            this.MenuYenileme.Controls.Add(this.btnRemoveMenu);
            this.MenuYenileme.Controls.Add(this.btnEkleMenu);
            this.MenuYenileme.Controls.Add(this.txtMenuPrice);
            this.MenuYenileme.Controls.Add(this.txtMenuCoffee);
            this.MenuYenileme.Controls.Add(this.labell);
            this.MenuYenileme.Controls.Add(this.label2);
            this.MenuYenileme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuYenileme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuYenileme.Location = new System.Drawing.Point(16, 50);
            this.MenuYenileme.Name = "MenuYenileme";
            this.MenuYenileme.Size = new System.Drawing.Size(590, 164);
            this.MenuYenileme.TabIndex = 1;
            this.MenuYenileme.TabStop = false;
            this.MenuYenileme.Text = "Menü Yenileme (Yönetici)";
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.BackColor = System.Drawing.Color.Blue;
            this.btnRemoveMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveMenu.Location = new System.Drawing.Point(281, 90);
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.Size = new System.Drawing.Size(189, 39);
            this.btnRemoveMenu.TabIndex = 6;
            this.btnRemoveMenu.Text = "Menüden Sil";
            this.btnRemoveMenu.UseVisualStyleBackColor = false;
            this.btnRemoveMenu.Click += new System.EventHandler(this.btnSilMenu_Click);
            // 
            // btnEkleMenu
            // 
            this.btnEkleMenu.BackColor = System.Drawing.Color.Blue;
            this.btnEkleMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEkleMenu.Location = new System.Drawing.Point(61, 90);
            this.btnEkleMenu.Name = "btnEkleMenu";
            this.btnEkleMenu.Size = new System.Drawing.Size(189, 39);
            this.btnEkleMenu.TabIndex = 5;
            this.btnEkleMenu.Text = "Munüye Ekle";
            this.btnEkleMenu.UseVisualStyleBackColor = false;
            this.btnEkleMenu.Click += new System.EventHandler(this.btnEkleMunu_Click);
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(281, 58);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(189, 26);
            this.txtMenuPrice.TabIndex = 4;
            // 
            // txtMenuCoffee
            // 
            this.txtMenuCoffee.Location = new System.Drawing.Point(61, 58);
            this.txtMenuCoffee.Name = "txtMenuCoffee";
            this.txtMenuCoffee.Size = new System.Drawing.Size(189, 26);
            this.txtMenuCoffee.TabIndex = 3;
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.ForeColor = System.Drawing.Color.Blue;
            this.labell.Location = new System.Drawing.Point(322, 35);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(106, 20);
            this.labell.TabIndex = 2;
            this.labell.Text = "Kahve Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(107, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kahve İsmi";
            // 
            // lstMenu
            // 
            this.lstMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.lstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 20;
            this.lstMenu.Location = new System.Drawing.Point(613, 70);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(570, 264);
            this.lstMenu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.cbCake);
            this.groupBox1.Controls.Add(this.cbCookie);
            this.groupBox1.Controls.Add(this.cbCoffee);
            this.groupBox1.Controls.Add(this.cbChocolate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rbGrande);
            this.groupBox1.Controls.Add(this.rbTall);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCoffeeChoice);
            this.groupBox1.Controls.Add(this.labelll);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 586);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Verme Ekranı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(252, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kahve Sipariş Özet";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Wheat;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(256, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 384);
            this.listBox1.TabIndex = 22;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalPrice.Location = new System.Drawing.Point(208, 535);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(30, 31);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Toplam Tutar:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(10, 465);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(409, 57);
            this.btnOrder.TabIndex = 19;
            this.btnOrder.Text = "Sipariş Ver";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cbCake
            // 
            this.cbCake.AutoSize = true;
            this.cbCake.Location = new System.Drawing.Point(10, 435);
            this.cbCake.Name = "cbCake";
            this.cbCake.Size = new System.Drawing.Size(114, 24);
            this.cbCake.TabIndex = 18;
            this.cbCake.Text = "Kek - 20TL";
            this.cbCake.UseVisualStyleBackColor = true;
            // 
            // cbCookie
            // 
            this.cbCookie.AutoSize = true;
            this.cbCookie.Location = new System.Drawing.Point(10, 405);
            this.cbCookie.Name = "cbCookie";
            this.cbCookie.Size = new System.Drawing.Size(153, 24);
            this.cbCookie.TabIndex = 17;
            this.cbCookie.Text = "Kurabiye - 15TL";
            this.cbCookie.UseVisualStyleBackColor = true;
            // 
            // cbCoffee
            // 
            this.cbCoffee.AutoSize = true;
            this.cbCoffee.Location = new System.Drawing.Point(10, 375);
            this.cbCoffee.Name = "cbCoffee";
            this.cbCoffee.Size = new System.Drawing.Size(184, 24);
            this.cbCoffee.TabIndex = 16;
            this.cbCoffee.Text = "Poşet Kahve - 10TL";
            this.cbCoffee.UseVisualStyleBackColor = true;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(10, 345);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(139, 24);
            this.cbChocolate.TabIndex = 15;
            this.cbChocolate.Text = "Çikolata - 5TL";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(6, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ekstra Ürün Seçimi";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(77, 239);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 49);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(10, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 49);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(163, 198);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(87, 24);
            this.rbGrande.TabIndex = 10;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbTall
            // 
            this.rbTall.AutoSize = true;
            this.rbTall.Location = new System.Drawing.Point(96, 198);
            this.rbTall.Name = "rbTall";
            this.rbTall.Size = new System.Drawing.Size(55, 24);
            this.rbTall.TabIndex = 9;
            this.rbTall.TabStop = true;
            this.rbTall.Text = "Tall";
            this.rbTall.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(10, 198);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(71, 24);
            this.rbSmall.TabIndex = 8;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Boy Seçimi";
            // 
            // txtCoffeeChoice
            // 
            this.txtCoffeeChoice.Location = new System.Drawing.Point(10, 123);
            this.txtCoffeeChoice.Name = "txtCoffeeChoice";
            this.txtCoffeeChoice.Size = new System.Drawing.Size(240, 26);
            this.txtCoffeeChoice.TabIndex = 6;
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelll.ForeColor = System.Drawing.Color.Navy;
            this.labelll.Location = new System.Drawing.Point(6, 100);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(232, 24);
            this.labelll.TabIndex = 5;
            this.labelll.Text = "Kahve Seçimi (Number)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 26);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adınız";
            // 
            // lstSiparisDurumEkrani
            // 
            this.lstSiparisDurumEkrani.BackColor = System.Drawing.Color.DarkKhaki;
            this.lstSiparisDurumEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisDurumEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.lstSiparisDurumEkrani.FormattingEnabled = true;
            this.lstSiparisDurumEkrani.ItemHeight = 20;
            this.lstSiparisDurumEkrani.Location = new System.Drawing.Point(613, 380);
            this.lstSiparisDurumEkrani.Name = "lstSiparisDurumEkrani";
            this.lstSiparisDurumEkrani.Size = new System.Drawing.Size(570, 424);
            this.lstSiparisDurumEkrani.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(612, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(612, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sipariş Durumu";
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenew.Location = new System.Drawing.Point(1007, 743);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(162, 49);
            this.btnRenew.TabIndex = 20;
            this.btnRenew.Text = "Yenile";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.Blue;
            this.btnReady.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReady.Location = new System.Drawing.Point(671, 25);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(189, 39);
            this.btnReady.TabIndex = 21;
            this.btnReady.Text = "Hazır Menü";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Red;
            this.lblSaniye.Location = new System.Drawing.Point(1140, 353);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(43, 24);
            this.lblSaniye.TabIndex = 22;
            this.lblSaniye.Text = "- - -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(802, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sipariş Hazırlanmasına Kalan süre:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1207, 822);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSiparisDurumEkrani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.MenuYenileme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeTree V.1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuYenileme.ResumeLayout(false);
            this.MenuYenileme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox MenuYenileme;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.TextBox txtMenuCoffee;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSiparisDurumEkrani;
        private System.Windows.Forms.Button btnRemoveMenu;
        private System.Windows.Forms.Button btnEkleMenu;
        private System.Windows.Forms.TextBox txtCoffeeChoice;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbTall;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.CheckBox cbCake;
        private System.Windows.Forms.CheckBox cbCookie;
        private System.Windows.Forms.CheckBox cbCoffee;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}

