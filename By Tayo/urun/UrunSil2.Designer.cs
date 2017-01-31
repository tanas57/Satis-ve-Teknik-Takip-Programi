namespace By_Tayo
{
    partial class UrunSil2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSil2));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunler = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SilHayir = new System.Windows.Forms.Button();
            this.UrunSil = new System.Windows.Forms.GroupBox();
            this.SilEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.UrunSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ürünü seçin ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürünün silinmesini onaylıyor musunuz ?";
            // 
            // urunler
            // 
            this.urunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunler.Enabled = false;
            this.urunler.FormattingEnabled = true;
            this.urunler.Location = new System.Drawing.Point(338, 30);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(180, 21);
            this.urunler.TabIndex = 36;
            this.urunler.SelectedIndexChanged += new System.EventHandler(this.urunler_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.urunler);
            this.groupBox2.Controls.Add(this.urunAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 70);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Arama";
            // 
            // urunAdi
            // 
            this.urunAdi.Location = new System.Drawing.Point(81, 30);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(128, 20);
            this.urunAdi.TabIndex = 35;
            this.urunAdi.TextChanged += new System.EventHandler(this.urunAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ürün Adı:";
            // 
            // SilHayir
            // 
            this.SilHayir.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilHayir.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.SilHayir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilHayir.Location = new System.Drawing.Point(243, 74);
            this.SilHayir.Name = "SilHayir";
            this.SilHayir.Size = new System.Drawing.Size(87, 47);
            this.SilHayir.TabIndex = 6;
            this.SilHayir.Text = "Hayır  ";
            this.SilHayir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilHayir.UseVisualStyleBackColor = true;
            this.SilHayir.Click += new System.EventHandler(this.SilHayir_Click);
            // 
            // UrunSil
            // 
            this.UrunSil.Controls.Add(this.label2);
            this.UrunSil.Controls.Add(this.SilHayir);
            this.UrunSil.Controls.Add(this.SilEvet);
            this.UrunSil.Controls.Add(this.label1);
            this.UrunSil.Enabled = false;
            this.UrunSil.Location = new System.Drawing.Point(12, 88);
            this.UrunSil.Name = "UrunSil";
            this.UrunSil.Size = new System.Drawing.Size(520, 127);
            this.UrunSil.TabIndex = 37;
            this.UrunSil.TabStop = false;
            this.UrunSil.Text = "Ürün Sil";
            // 
            // SilEvet
            // 
            this.SilEvet.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilEvet.Image = global::By_Tayo.Properties.Resources.tik32;
            this.SilEvet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilEvet.Location = new System.Drawing.Point(146, 74);
            this.SilEvet.Name = "SilEvet";
            this.SilEvet.Size = new System.Drawing.Size(88, 47);
            this.SilEvet.TabIndex = 5;
            this.SilEvet.Text = "Evet   ";
            this.SilEvet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilEvet.UseVisualStyleBackColor = true;
            this.SilEvet.Click += new System.EventHandler(this.SilEvet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // UrunSil2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UrunSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(557, 263);
            this.MinimumSize = new System.Drawing.Size(557, 263);
            this.Name = "UrunSil2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Sil";
            this.Load += new System.EventHandler(this.UrunSil2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UrunSil.ResumeLayout(false);
            this.UrunSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox urunler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SilHayir;
        private System.Windows.Forms.GroupBox UrunSil;
        private System.Windows.Forms.Button SilEvet;
        private System.Windows.Forms.Label label1;
    }
}