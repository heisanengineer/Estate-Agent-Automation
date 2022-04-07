namespace Emlak_Otomasyonu
{
    partial class frmKullanicigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicigiris));
            this.txtKullaniciadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciadi
            // 
            this.txtKullaniciadi.Font = new System.Drawing.Font("Segoe Print", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciadi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKullaniciadi.Location = new System.Drawing.Point(624, 250);
            this.txtKullaniciadi.Name = "txtKullaniciadi";
            this.txtKullaniciadi.Size = new System.Drawing.Size(180, 39);
            this.txtKullaniciadi.TabIndex = 0;
            this.txtKullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe Print", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSifre.Location = new System.Drawing.Point(624, 300);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(180, 39);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciadi
            // 
            this.lblKullaniciadi.AutoSize = true;
            this.lblKullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciadi.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciadi.Location = new System.Drawing.Point(482, 251);
            this.lblKullaniciadi.Name = "lblKullaniciadi";
            this.lblKullaniciadi.Size = new System.Drawing.Size(136, 33);
            this.lblKullaniciadi.TabIndex = 2;
            this.lblKullaniciadi.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(518, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre";
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.acbuton;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Location = new System.Drawing.Point(624, 345);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(88, 52);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.butoncikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(716, 345);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(88, 52);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 155);
            this.button1.TabIndex = 6;
            this.button1.Text = "özel güç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKullanicigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak_Otomasyonu.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(816, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKullaniciadi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKullanicigiris";
            this.Text = "Kullanıcı Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
    }
}

