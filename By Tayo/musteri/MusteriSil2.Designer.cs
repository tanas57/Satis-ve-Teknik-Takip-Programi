namespace By_Tayo
{
    partial class MusteriSil2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSil2));
            this.label2 = new System.Windows.Forms.Label();
            this.SilHayir = new System.Windows.Forms.Button();
            this.SilEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MusteriSil = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Musteri_adi_combo = new System.Windows.Forms.ComboBox();
            this.AramaMusteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MusteriSil.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşterinin silinmesini onaylıyor musunuz ?";
            // 
            // SilHayir
            // 
            this.SilHayir.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilHayir.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.SilHayir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilHayir.Location = new System.Drawing.Point(277, 74);
            this.SilHayir.Name = "SilHayir";
            this.SilHayir.Size = new System.Drawing.Size(93, 36);
            this.SilHayir.TabIndex = 6;
            this.SilHayir.Text = "Hayır  ";
            this.SilHayir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilHayir.UseVisualStyleBackColor = true;
            this.SilHayir.Click += new System.EventHandler(this.SilHayir_Click);
            // 
            // SilEvet
            // 
            this.SilEvet.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilEvet.Image = global::By_Tayo.Properties.Resources.tik32;
            this.SilEvet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilEvet.Location = new System.Drawing.Point(178, 74);
            this.SilEvet.Name = "SilEvet";
            this.SilEvet.Size = new System.Drawing.Size(93, 36);
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
            // MusteriSil
            // 
            this.MusteriSil.Controls.Add(this.label2);
            this.MusteriSil.Controls.Add(this.SilHayir);
            this.MusteriSil.Controls.Add(this.SilEvet);
            this.MusteriSil.Controls.Add(this.label1);
            this.MusteriSil.Enabled = false;
            this.MusteriSil.Location = new System.Drawing.Point(8, 85);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(520, 127);
            this.MusteriSil.TabIndex = 8;
            this.MusteriSil.TabStop = false;
            this.MusteriSil.Text = "Müşteri Sil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Musteri_adi_combo);
            this.groupBox2.Controls.Add(this.AramaMusteriAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 70);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Müşteriyi seçin ->";
            // 
            // Musteri_adi_combo
            // 
            this.Musteri_adi_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri_adi_combo.Enabled = false;
            this.Musteri_adi_combo.FormattingEnabled = true;
            this.Musteri_adi_combo.Location = new System.Drawing.Point(338, 30);
            this.Musteri_adi_combo.Name = "Musteri_adi_combo";
            this.Musteri_adi_combo.Size = new System.Drawing.Size(180, 21);
            this.Musteri_adi_combo.TabIndex = 36;
            this.Musteri_adi_combo.SelectedIndexChanged += new System.EventHandler(this.Musteri_adi_combo_SelectedIndexChanged);
            // 
            // AramaMusteriAdi
            // 
            this.AramaMusteriAdi.Location = new System.Drawing.Point(81, 30);
            this.AramaMusteriAdi.MaxLength = 100;
            this.AramaMusteriAdi.Name = "AramaMusteriAdi";
            this.AramaMusteriAdi.Size = new System.Drawing.Size(145, 20);
            this.AramaMusteriAdi.TabIndex = 35;
            this.AramaMusteriAdi.TextChanged += new System.EventHandler(this.AramaMusteriAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Müşteri Adı\r\nveya Soyadı:";
            // 
            // MusteriSil2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 220);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MusteriSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 259);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 259);
            this.Name = "MusteriSil2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sil";
            this.Load += new System.EventHandler(this.MusteriSil2_Load);
            this.MusteriSil.ResumeLayout(false);
            this.MusteriSil.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SilHayir;
        private System.Windows.Forms.Button SilEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MusteriSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Musteri_adi_combo;
        private System.Windows.Forms.TextBox AramaMusteriAdi;
        private System.Windows.Forms.Label label4;
    }
}