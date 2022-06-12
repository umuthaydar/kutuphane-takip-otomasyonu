
namespace KütüphaneTakipOtomasyonu
{
    partial class OduncTakipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncTakipForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Cikis_Icon = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.İsimArama_OduncTakip_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KitapAraOduncTakip_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OduncTakipİptal_Button = new System.Windows.Forms.Button();
            this.OduncTakipTeslimAl_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(589, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.Cikis_Icon);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, -6);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(952, 76);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // Cikis_Icon
            // 
            this.Cikis_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Cikis_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Cikis_Icon.Image")));
            this.Cikis_Icon.Location = new System.Drawing.Point(908, 18);
            this.Cikis_Icon.Name = "Cikis_Icon";
            this.Cikis_Icon.Size = new System.Drawing.Size(30, 30);
            this.Cikis_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cikis_Icon.TabIndex = 39;
            this.Cikis_Icon.TabStop = false;
            this.Cikis_Icon.Click += new System.EventHandler(this.Cikis_Icon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(373, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ödünç Takip";
            // 
            // İsimArama_OduncTakip_TextBox
            // 
            this.İsimArama_OduncTakip_TextBox.Location = new System.Drawing.Point(226, 113);
            this.İsimArama_OduncTakip_TextBox.Name = "İsimArama_OduncTakip_TextBox";
            this.İsimArama_OduncTakip_TextBox.Size = new System.Drawing.Size(196, 23);
            this.İsimArama_OduncTakip_TextBox.TabIndex = 29;
            this.İsimArama_OduncTakip_TextBox.TextChanged += new System.EventHandler(this.İsimArama_OduncTakip_TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "İsme Göre Sırala:";
            // 
            // KitapAraOduncTakip_TextBox
            // 
            this.KitapAraOduncTakip_TextBox.Location = new System.Drawing.Point(640, 116);
            this.KitapAraOduncTakip_TextBox.Name = "KitapAraOduncTakip_TextBox";
            this.KitapAraOduncTakip_TextBox.Size = new System.Drawing.Size(196, 23);
            this.KitapAraOduncTakip_TextBox.TabIndex = 31;
            this.KitapAraOduncTakip_TextBox.TextChanged += new System.EventHandler(this.KitapAraOduncTakip_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kitap Adına Göre Sıralama:";
            // 
            // OduncTakipİptal_Button
            // 
            this.OduncTakipİptal_Button.Image = ((System.Drawing.Image)(resources.GetObject("OduncTakipİptal_Button.Image")));
            this.OduncTakipİptal_Button.Location = new System.Drawing.Point(799, 498);
            this.OduncTakipİptal_Button.Name = "OduncTakipİptal_Button";
            this.OduncTakipİptal_Button.Size = new System.Drawing.Size(70, 70);
            this.OduncTakipİptal_Button.TabIndex = 33;
            this.OduncTakipİptal_Button.UseVisualStyleBackColor = true;
            this.OduncTakipİptal_Button.Click += new System.EventHandler(this.OduncTakipİptal_Button_Click);
            // 
            // OduncTakipTeslimAl_Button
            // 
            this.OduncTakipTeslimAl_Button.Image = ((System.Drawing.Image)(resources.GetObject("OduncTakipTeslimAl_Button.Image")));
            this.OduncTakipTeslimAl_Button.Location = new System.Drawing.Point(697, 498);
            this.OduncTakipTeslimAl_Button.Name = "OduncTakipTeslimAl_Button";
            this.OduncTakipTeslimAl_Button.Size = new System.Drawing.Size(70, 70);
            this.OduncTakipTeslimAl_Button.TabIndex = 32;
            this.OduncTakipTeslimAl_Button.UseVisualStyleBackColor = true;
            this.OduncTakipTeslimAl_Button.Click += new System.EventHandler(this.OduncTakipTeslimAl_Button_Click);
            // 
            // OduncTakipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.OduncTakipİptal_Button);
            this.Controls.Add(this.OduncTakipTeslimAl_Button);
            this.Controls.Add(this.KitapAraOduncTakip_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.İsimArama_OduncTakip_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OduncTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.OduncTakipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox İsimArama_OduncTakip_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KitapAraOduncTakip_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OduncTakipİptal_Button;
        private System.Windows.Forms.Button OduncTakipTeslimAl_Button;
        private System.Windows.Forms.PictureBox Cikis_Icon;
    }
}