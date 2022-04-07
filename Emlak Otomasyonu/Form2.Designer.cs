namespace Emlak_Otomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnKayitekle = new System.Windows.Forms.Button();
            this.btnGayrimenkulara = new System.Windows.Forms.Button();
            this.btnKayitguncelle = new System.Windows.Forms.Button();
            this.btnMusteriekle = new System.Windows.Forms.Button();
            this.btnKredisorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKayitekle
            // 
            this.btnKayitekle.BackColor = System.Drawing.Color.Transparent;
            this.btnKayitekle.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.kayıtekle1;
            this.btnKayitekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayitekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitekle.Location = new System.Drawing.Point(5, 5);
            this.btnKayitekle.Name = "btnKayitekle";
            this.btnKayitekle.Size = new System.Drawing.Size(156, 114);
            this.btnKayitekle.TabIndex = 0;
            this.btnKayitekle.Text = "Kayıt Ekle";
            this.btnKayitekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayitekle.UseVisualStyleBackColor = false;
            this.btnKayitekle.Click += new System.EventHandler(this.btnKayitekle_Click);
            // 
            // btnGayrimenkulara
            // 
            this.btnGayrimenkulara.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.gayrimenkulara;
            this.btnGayrimenkulara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGayrimenkulara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGayrimenkulara.Location = new System.Drawing.Point(329, 5);
            this.btnGayrimenkulara.Name = "btnGayrimenkulara";
            this.btnGayrimenkulara.Size = new System.Drawing.Size(156, 114);
            this.btnGayrimenkulara.TabIndex = 1;
            this.btnGayrimenkulara.Text = "Gayrimenkul Ara";
            this.btnGayrimenkulara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGayrimenkulara.UseVisualStyleBackColor = true;
            // 
            // btnKayitguncelle
            // 
            this.btnKayitguncelle.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.kayıtguncelle;
            this.btnKayitguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayitguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitguncelle.Location = new System.Drawing.Point(167, 5);
            this.btnKayitguncelle.Name = "btnKayitguncelle";
            this.btnKayitguncelle.Size = new System.Drawing.Size(156, 114);
            this.btnKayitguncelle.TabIndex = 2;
            this.btnKayitguncelle.Text = "Kayıt Güncelle";
            this.btnKayitguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayitguncelle.UseVisualStyleBackColor = true;
            this.btnKayitguncelle.Click += new System.EventHandler(this.btnKayitguncelle_Click);
            // 
            // btnMusteriekle
            // 
            this.btnMusteriekle.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.musteriekle;
            this.btnMusteriekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriekle.Location = new System.Drawing.Point(491, 5);
            this.btnMusteriekle.Name = "btnMusteriekle";
            this.btnMusteriekle.Size = new System.Drawing.Size(156, 114);
            this.btnMusteriekle.TabIndex = 3;
            this.btnMusteriekle.Text = "Müşteri Ekle";
            this.btnMusteriekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriekle.UseVisualStyleBackColor = true;
            // 
            // btnKredisorgula
            // 
            this.btnKredisorgula.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.kredisorgula;
            this.btnKredisorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKredisorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKredisorgula.Location = new System.Drawing.Point(653, 5);
            this.btnKredisorgula.Name = "btnKredisorgula";
            this.btnKredisorgula.Size = new System.Drawing.Size(156, 114);
            this.btnKredisorgula.TabIndex = 4;
            this.btnKredisorgula.Text = "Kredi Sorgula";
            this.btnKredisorgula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKredisorgula.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.Ana_Menü_Arka_Plan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 454);
            this.Controls.Add(this.btnKredisorgula);
            this.Controls.Add(this.btnMusteriekle);
            this.Controls.Add(this.btnKayitguncelle);
            this.Controls.Add(this.btnGayrimenkulara);
            this.Controls.Add(this.btnKayitekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayitekle;
        private System.Windows.Forms.Button btnGayrimenkulara;
        private System.Windows.Forms.Button btnKayitguncelle;
        private System.Windows.Forms.Button btnMusteriekle;
        private System.Windows.Forms.Button btnKredisorgula;
    }
}