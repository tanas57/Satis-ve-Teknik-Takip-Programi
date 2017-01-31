namespace By_Tayo
{
    partial class KontrolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolForm));
            this.ilerleme = new System.Windows.Forms.ProgressBar();
            this.say = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.yenile = new System.Windows.Forms.PictureBox();
            this.resim = new System.Windows.Forms.PictureBox();
            this.server = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ldurum = new System.Windows.Forms.Label();
            this.ligir = new System.Windows.Forms.Button();
            this.iletisim = new System.Windows.Forms.Button();
            this.Giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.server)).BeginInit();
            this.SuspendLayout();
            // 
            // ilerleme
            // 
            this.ilerleme.Location = new System.Drawing.Point(10, 13);
            this.ilerleme.Name = "ilerleme";
            this.ilerleme.Size = new System.Drawing.Size(425, 23);
            this.ilerleme.TabIndex = 0;
            // 
            // say
            // 
            this.say.Interval = 11;
            this.say.Tick += new System.EventHandler(this.say_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Durumu:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(129, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © Muslu Yazılım";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.Transparent;
            this.yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yenile.Image = global::By_Tayo.Properties.Resources.yenile;
            this.yenile.Location = new System.Drawing.Point(403, 58);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(32, 32);
            this.yenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yenile.TabIndex = 13;
            this.yenile.TabStop = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // resim
            // 
            this.resim.BackColor = System.Drawing.Color.Transparent;
            this.resim.Image = global::By_Tayo.Properties.Resources.bekle1;
            this.resim.Location = new System.Drawing.Point(149, 58);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(33, 33);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resim.TabIndex = 2;
            this.resim.TabStop = false;
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.Color.Transparent;
            this.server.Image = global::By_Tayo.Properties.Resources.bekle1;
            this.server.Location = new System.Drawing.Point(340, 57);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(33, 33);
            this.server.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.server.TabIndex = 15;
            this.server.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(196, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Server Bağlantısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lisans Durumu:";
            // 
            // ldurum
            // 
            this.ldurum.AutoSize = true;
            this.ldurum.BackColor = System.Drawing.Color.Transparent;
            this.ldurum.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldurum.Location = new System.Drawing.Point(155, 119);
            this.ldurum.Name = "ldurum";
            this.ldurum.Size = new System.Drawing.Size(0, 23);
            this.ldurum.TabIndex = 17;
            // 
            // ligir
            // 
            this.ligir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ligir.ForeColor = System.Drawing.Color.Red;
            this.ligir.Location = new System.Drawing.Point(96, 154);
            this.ligir.Name = "ligir";
            this.ligir.Size = new System.Drawing.Size(103, 23);
            this.ligir.TabIndex = 18;
            this.ligir.Text = "Lisans Girişi";
            this.ligir.UseVisualStyleBackColor = true;
            this.ligir.Visible = false;
            this.ligir.Click += new System.EventHandler(this.ligir_Click);
            // 
            // iletisim
            // 
            this.iletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iletisim.ForeColor = System.Drawing.Color.Blue;
            this.iletisim.Location = new System.Drawing.Point(15, 154);
            this.iletisim.Name = "iletisim";
            this.iletisim.Size = new System.Drawing.Size(75, 23);
            this.iletisim.TabIndex = 20;
            this.iletisim.Text = "İletişim";
            this.iletisim.UseVisualStyleBackColor = true;
            this.iletisim.Click += new System.EventHandler(this.iletisim_Click);
            // 
            // Giris
            // 
            this.Giris.Enabled = false;
            this.Giris.Location = new System.Drawing.Point(340, 154);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(95, 42);
            this.Giris.TabIndex = 21;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // KontrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.iletisim);
            this.Controls.Add(this.ligir);
            this.Controls.Add(this.ldurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilerleme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 235);
            this.Name = "KontrolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Form";
            this.Load += new System.EventHandler(this.KontrolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.server)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Timer say;
        public System.Windows.Forms.ProgressBar ilerleme;
        private System.Windows.Forms.PictureBox yenile;
        private System.Windows.Forms.PictureBox server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ldurum;
        private System.Windows.Forms.Button ligir;
        private System.Windows.Forms.Button iletisim;
        private System.Windows.Forms.Button Giris;

    }
}