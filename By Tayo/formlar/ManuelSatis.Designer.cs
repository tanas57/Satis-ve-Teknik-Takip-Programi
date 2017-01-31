namespace By_Tayo
{
    partial class ManuelSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuelSatis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlisFiyat = new System.Windows.Forms.TextBox();
            this.UrunFiyat = new System.Windows.Forms.TextBox();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.not = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.musara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SatisMusteri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KayitliMi1 = new System.Windows.Forms.CheckBox();
            this.ekle = new System.Windows.Forms.Button();
            this.formukapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Alış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Satış Fiyatı:";
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlisFiyat.Location = new System.Drawing.Point(105, 55);
            this.AlisFiyat.MaxLength = 25;
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Size = new System.Drawing.Size(160, 20);
            this.AlisFiyat.TabIndex = 2;
            this.AlisFiyat.TextChanged += new System.EventHandler(this.AlisFiyat_TextChanged);
            this.AlisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlisFiyat_KeyPress);
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UrunFiyat.Location = new System.Drawing.Point(105, 92);
            this.UrunFiyat.MaxLength = 25;
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Size = new System.Drawing.Size(160, 20);
            this.UrunFiyat.TabIndex = 3;
            this.UrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunFiyat_KeyPress);
            // 
            // UrunAdi
            // 
            this.UrunAdi.Location = new System.Drawing.Point(105, 21);
            this.UrunAdi.MaxLength = 100;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(160, 20);
            this.UrunAdi.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.not);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AlisFiyat);
            this.groupBox1.Controls.Add(this.UrunFiyat);
            this.groupBox1.Controls.Add(this.UrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgi";
            // 
            // not
            // 
            this.not.Location = new System.Drawing.Point(105, 119);
            this.not.MaxLength = 500;
            this.not.Multiline = true;
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(160, 47);
            this.not.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Not:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.KayitliMi1);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.musara);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.SatisMusteri);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(5, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 107);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // musara
            // 
            this.musara.Location = new System.Drawing.Point(66, 14);
            this.musara.Name = "musara";
            this.musara.Size = new System.Drawing.Size(163, 20);
            this.musara.TabIndex = 6;
            this.musara.TextChanged += new System.EventHandler(this.musara_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Arama:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Bakiyeye eklensin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SatisMusteri
            // 
            this.SatisMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SatisMusteri.FormattingEnabled = true;
            this.SatisMusteri.Location = new System.Drawing.Point(66, 40);
            this.SatisMusteri.Name = "SatisMusteri";
            this.SatisMusteri.Size = new System.Drawing.Size(163, 21);
            this.SatisMusteri.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Müşteri:";
            // 
            // KayitliMi1
            // 
            this.KayitliMi1.AutoSize = true;
            this.KayitliMi1.Location = new System.Drawing.Point(21, 21);
            this.KayitliMi1.Name = "KayitliMi1";
            this.KayitliMi1.Size = new System.Drawing.Size(228, 17);
            this.KayitliMi1.TabIndex = 5;
            this.KayitliMi1.Text = "Ürünü satın alan kişi müşterilerde kayıtlı mı?";
            this.KayitliMi1.UseVisualStyleBackColor = true;
            this.KayitliMi1.CheckedChanged += new System.EventHandler(this.KayitliMi1_CheckedChanged);
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.Image = global::By_Tayo.Properties.Resources.ekle;
            this.ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle.Location = new System.Drawing.Point(225, 190);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(138, 43);
            this.ekle.TabIndex = 9;
            this.ekle.Text = "   Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // formukapat
            // 
            this.formukapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.formukapat.Location = new System.Drawing.Point(527, 210);
            this.formukapat.Name = "formukapat";
            this.formukapat.Size = new System.Drawing.Size(75, 23);
            this.formukapat.TabIndex = 12;
            this.formukapat.Text = "formukapat";
            this.formukapat.UseVisualStyleBackColor = true;
            this.formukapat.Visible = false;
            this.formukapat.Click += new System.EventHandler(this.formukapat_Click);
            // 
            // ManuelSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.formukapat;
            this.ClientSize = new System.Drawing.Size(610, 237);
            this.Controls.Add(this.formukapat);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 276);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 276);
            this.Name = "ManuelSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuel Satış";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlisFiyat;
        private System.Windows.Forms.TextBox UrunFiyat;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox KayitliMi1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox SatisMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox musara;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox not;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button formukapat;
    }
}