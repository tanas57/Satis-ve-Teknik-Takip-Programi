namespace By_Tayo
{
    partial class Lisans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lisans));
            this.GirilenLisans = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.Button();
            this.Kontrol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GirilenLisans
            // 
            this.GirilenLisans.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirilenLisans.Location = new System.Drawing.Point(95, 120);
            this.GirilenLisans.Mask = "00000-00000-00000-00000-00000";
            this.GirilenLisans.Name = "GirilenLisans";
            this.GirilenLisans.Size = new System.Drawing.Size(288, 26);
            this.GirilenLisans.TabIndex = 0;
            this.GirilenLisans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lisans Kodu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 114);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "     Programın tüm özelliklerini sınırsız bir şekilde\r\nkullanabilmek için lütfen " +
                "satın almış olduğunuz\r\nlisans kodunu girip, lisansı doğrulaya tıklayınız.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::By_Tayo.Properties.Resources.Places_certificate_server_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.Location = new System.Drawing.Point(324, 200);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(72, 37);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Kontrol
            // 
            this.Kontrol.BackColor = System.Drawing.Color.Transparent;
            this.Kontrol.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Kontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kontrol.Location = new System.Drawing.Point(166, 152);
            this.Kontrol.Name = "Kontrol";
            this.Kontrol.Size = new System.Drawing.Size(122, 40);
            this.Kontrol.TabIndex = 1;
            this.Kontrol.Text = "Lisansı Doğrula";
            this.Kontrol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Kontrol.UseVisualStyleBackColor = false;
            this.Kontrol.Click += new System.EventHandler(this.Kontrol_Click);
            // 
            // Lisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(395, 236);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.Kontrol);
            this.Controls.Add(this.GirilenLisans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 275);
            this.Name = "Lisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox GirilenLisans;
        private System.Windows.Forms.Button Kontrol;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}