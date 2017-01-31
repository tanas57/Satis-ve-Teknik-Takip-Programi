namespace By_Tayo
{
    partial class YedekYukle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YedekYukle));
            this.Grup1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yedek = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ay = new System.Windows.Forms.ComboBox();
            this.yil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YukleYol = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Grup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grup1
            // 
            this.Grup1.Controls.Add(this.button1);
            this.Grup1.Controls.Add(this.yedek);
            this.Grup1.Controls.Add(this.label3);
            this.Grup1.Controls.Add(this.ay);
            this.Grup1.Controls.Add(this.yil);
            this.Grup1.Controls.Add(this.label2);
            this.Grup1.Controls.Add(this.label1);
            this.Grup1.Location = new System.Drawing.Point(11, 29);
            this.Grup1.Name = "Grup1";
            this.Grup1.Size = new System.Drawing.Size(266, 187);
            this.Grup1.TabIndex = 0;
            this.Grup1.TabStop = false;
            this.Grup1.Text = "Hazır Yedek Seçin";
            // 
            // button1
            // 
            this.button1.Image = global::By_Tayo.Properties.Resources.yukle;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(90, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Veritabanını Geri Yükle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yedek
            // 
            this.yedek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yedek.FormattingEnabled = true;
            this.yedek.Items.AddRange(new object[] {
            "--- Ayı Seçiniz ---"});
            this.yedek.Location = new System.Drawing.Point(90, 102);
            this.yedek.Name = "yedek";
            this.yedek.Size = new System.Drawing.Size(151, 21);
            this.yedek.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yüklenilebilir\r\nYedeği Seçin:";
            // 
            // ay
            // 
            this.ay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ay.FormattingEnabled = true;
            this.ay.Items.AddRange(new object[] {
            "---Yılı Seçiniz ---"});
            this.ay.Location = new System.Drawing.Point(90, 70);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(151, 21);
            this.ay.TabIndex = 3;
            this.ay.SelectedIndexChanged += new System.EventHandler(this.ay_SelectedIndexChanged);
            // 
            // yil
            // 
            this.yil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yil.FormattingEnabled = true;
            this.yil.Location = new System.Drawing.Point(90, 36);
            this.yil.Name = "yil";
            this.yil.Size = new System.Drawing.Size(151, 21);
            this.yil.TabIndex = 2;
            this.yil.SelectedIndexChanged += new System.EventHandler(this.yil_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ayı Seçin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yılı Seçin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YukleYol);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(283, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dizinden Yükleme";
            // 
            // YukleYol
            // 
            this.YukleYol.Enabled = false;
            this.YukleYol.Location = new System.Drawing.Point(10, 106);
            this.YukleYol.Name = "YukleYol";
            this.YukleYol.Size = new System.Drawing.Size(247, 20);
            this.YukleYol.TabIndex = 9;
            this.YukleYol.Visible = false;
            this.YukleYol.WordWrap = false;
            // 
            // button3
            // 
            this.button3.Image = global::By_Tayo.Properties.Resources.dosya;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(82, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Dosya Seç";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lütfen yüklemek istediğiniz yedek dosyasını seçin";
            // 
            // button2
            // 
            this.button2.Image = global::By_Tayo.Properties.Resources.yukle;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(61, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Veritabanını Geri Yükle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(228, 8);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(0, 13);
            this.tarih.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alınan son yedek tarihi ->";
            // 
            // YedekYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 225);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(577, 245);
            this.Name = "YedekYukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekten Geri Yükleme";
            this.Load += new System.EventHandler(this.YedekYukle_Load);
            this.Grup1.ResumeLayout(false);
            this.Grup1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grup1;
        private System.Windows.Forms.ComboBox yedek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ay;
        private System.Windows.Forms.ComboBox yil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YukleYol;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label label5;
    }
}