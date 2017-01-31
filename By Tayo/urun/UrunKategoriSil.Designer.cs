namespace By_Tayo
{
    partial class UrunKategoriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategoriSil));
            this.label2 = new System.Windows.Forms.Label();
            this.SilHayir = new System.Windows.Forms.Button();
            this.SilEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün kategorisinin silinmesini onaylıyor musunuz ?";
            // 
            // SilHayir
            // 
            this.SilHayir.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilHayir.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.SilHayir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilHayir.Location = new System.Drawing.Point(181, 61);
            this.SilHayir.Name = "SilHayir";
            this.SilHayir.Size = new System.Drawing.Size(95, 42);
            this.SilHayir.TabIndex = 6;
            this.SilHayir.Text = "    Hayır";
            this.SilHayir.UseVisualStyleBackColor = true;
            this.SilHayir.Click += new System.EventHandler(this.SilHayir_Click);
            // 
            // SilEvet
            // 
            this.SilEvet.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilEvet.Image = global::By_Tayo.Properties.Resources.tik32;
            this.SilEvet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilEvet.Location = new System.Drawing.Point(80, 61);
            this.SilEvet.Name = "SilEvet";
            this.SilEvet.Size = new System.Drawing.Size(95, 42);
            this.SilEvet.TabIndex = 5;
            this.SilEvet.Text = "    Evet";
            this.SilEvet.UseVisualStyleBackColor = true;
            this.SilEvet.Click += new System.EventHandler(this.SilEvet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // UrunKategoriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 105);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SilHayir);
            this.Controls.Add(this.SilEvet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 144);
            this.Name = "UrunKategoriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunKategoriSil";
            this.Load += new System.EventHandler(this.UrunKategoriSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SilHayir;
        private System.Windows.Forms.Button SilEvet;
        private System.Windows.Forms.Label label1;
    }
}