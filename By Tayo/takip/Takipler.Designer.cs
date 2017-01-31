namespace By_Tayo
{
    partial class Takipler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Takipler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButonSil = new System.Windows.Forms.Button();
            this.ButonGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.takipno = new System.Windows.Forms.MaskedTextBox();
            this.TakipAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButonSil
            // 
            this.ButonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonSil.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonSil.Location = new System.Drawing.Point(623, 261);
            this.ButonSil.Name = "ButonSil";
            this.ButonSil.Size = new System.Drawing.Size(94, 38);
            this.ButonSil.TabIndex = 7;
            this.ButonSil.Text = "   Sil";
            this.ButonSil.UseVisualStyleBackColor = true;
            this.ButonSil.Click += new System.EventHandler(this.ButonSil_Click);
            // 
            // ButonGuncelle
            // 
            this.ButonGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonGuncelle.Location = new System.Drawing.Point(623, 202);
            this.ButonGuncelle.Name = "ButonGuncelle";
            this.ButonGuncelle.Size = new System.Drawing.Size(94, 38);
            this.ButonGuncelle.TabIndex = 6;
            this.ButonGuncelle.Text = "Güncelle ";
            this.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonGuncelle.UseVisualStyleBackColor = true;
            this.ButonGuncelle.Click += new System.EventHandler(this.ButonGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Takip No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.takipno);
            this.groupBox1.Controls.Add(this.TakipAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(162, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takip Arama";
            // 
            // takipno
            // 
            this.takipno.Location = new System.Drawing.Point(76, 32);
            this.takipno.Mask = "TKP000000000";
            this.takipno.Name = "takipno";
            this.takipno.Size = new System.Drawing.Size(138, 20);
            this.takipno.TabIndex = 12;
            // 
            // TakipAra
            // 
            this.TakipAra.Image = global::By_Tayo.Properties.Resources.ara;
            this.TakipAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TakipAra.Location = new System.Drawing.Point(229, 21);
            this.TakipAra.Name = "TakipAra";
            this.TakipAra.Size = new System.Drawing.Size(88, 40);
            this.TakipAra.TabIndex = 11;
            this.TakipAra.Text = "Arama   ";
            this.TakipAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TakipAra.UseVisualStyleBackColor = true;
            this.TakipAra.Click += new System.EventHandler(this.TakipAra_Click);
            // 
            // Takipler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButonSil);
            this.Controls.Add(this.ButonGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(738, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(738, 431);
            this.Name = "Takipler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takipler";
            this.Load += new System.EventHandler(this.Takipler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButonSil;
        private System.Windows.Forms.Button ButonGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TakipAra;
        public System.Windows.Forms.MaskedTextBox takipno;
    }
}