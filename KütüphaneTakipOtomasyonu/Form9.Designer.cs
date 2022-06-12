
namespace KütüphaneTakipOtomasyonu
{
    partial class AdminEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkleForm));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Cikis_Icon = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sifre_AdminEkle_TextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdi_AdminEkle_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminEkleİptal_Button = new System.Windows.Forms.Button();
            this.AdminEkleKaydet_Button = new System.Windows.Forms.Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.Cikis_Icon);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(390, 64);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // Cikis_Icon
            // 
            this.Cikis_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Cikis_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Cikis_Icon.Image")));
            this.Cikis_Icon.Location = new System.Drawing.Point(348, 12);
            this.Cikis_Icon.Name = "Cikis_Icon";
            this.Cikis_Icon.Size = new System.Drawing.Size(30, 30);
            this.Cikis_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cikis_Icon.TabIndex = 40;
            this.Cikis_Icon.TabStop = false;
            this.Cikis_Icon.Click += new System.EventHandler(this.Cikis_Icon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(127, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Admin Ekle";
            // 
            // Sifre_AdminEkle_TextBox
            // 
            this.Sifre_AdminEkle_TextBox.Location = new System.Drawing.Point(142, 217);
            this.Sifre_AdminEkle_TextBox.Name = "Sifre_AdminEkle_TextBox";
            this.Sifre_AdminEkle_TextBox.Size = new System.Drawing.Size(196, 23);
            this.Sifre_AdminEkle_TextBox.TabIndex = 18;
            // 
            // KullaniciAdi_AdminEkle_TextBox
            // 
            this.KullaniciAdi_AdminEkle_TextBox.Location = new System.Drawing.Point(142, 137);
            this.KullaniciAdi_AdminEkle_TextBox.Name = "KullaniciAdi_AdminEkle_TextBox";
            this.KullaniciAdi_AdminEkle_TextBox.Size = new System.Drawing.Size(196, 23);
            this.KullaniciAdi_AdminEkle_TextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // AdminEkleİptal_Button
            // 
            this.AdminEkleİptal_Button.Image = ((System.Drawing.Image)(resources.GetObject("AdminEkleİptal_Button.Image")));
            this.AdminEkleİptal_Button.Location = new System.Drawing.Point(222, 298);
            this.AdminEkleİptal_Button.Name = "AdminEkleİptal_Button";
            this.AdminEkleİptal_Button.Size = new System.Drawing.Size(70, 70);
            this.AdminEkleİptal_Button.TabIndex = 20;
            this.AdminEkleİptal_Button.UseVisualStyleBackColor = true;
            this.AdminEkleİptal_Button.Click += new System.EventHandler(this.AdminEkleİptal_Button_Click);
            // 
            // AdminEkleKaydet_Button
            // 
            this.AdminEkleKaydet_Button.Image = ((System.Drawing.Image)(resources.GetObject("AdminEkleKaydet_Button.Image")));
            this.AdminEkleKaydet_Button.Location = new System.Drawing.Point(101, 298);
            this.AdminEkleKaydet_Button.Name = "AdminEkleKaydet_Button";
            this.AdminEkleKaydet_Button.Size = new System.Drawing.Size(70, 70);
            this.AdminEkleKaydet_Button.TabIndex = 21;
            this.AdminEkleKaydet_Button.UseVisualStyleBackColor = true;
            this.AdminEkleKaydet_Button.Click += new System.EventHandler(this.AdminEkleKaydet_Button_Click);
            // 
            // AdminEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 409);
            this.Controls.Add(this.AdminEkleİptal_Button);
            this.Controls.Add(this.AdminEkleKaydet_Button);
            this.Controls.Add(this.Sifre_AdminEkle_TextBox);
            this.Controls.Add(this.KullaniciAdi_AdminEkle_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Sifre_AdminEkle_TextBox;
        private System.Windows.Forms.TextBox KullaniciAdi_AdminEkle_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminEkleİptal_Button;
        private System.Windows.Forms.Button AdminEkleKaydet_Button;
        private System.Windows.Forms.PictureBox Cikis_Icon;
    }
}