
namespace BankaTest
{
    partial class Form3
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnHesapNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(142, 31);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(153, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "AD:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(142, 63);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(153, 26);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "HESAP NO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ŞİFRE:";
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Enabled = false;
            this.MskHesapNo.Location = new System.Drawing.Point(142, 159);
            this.MskHesapNo.Mask = "000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(153, 26);
            this.MskHesapNo.TabIndex = 5;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(142, 191);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(153, 26);
            this.TxtSifre.TabIndex = 6;
            // 
            // MskTcKimlikNo
            // 
            this.MskTcKimlikNo.Location = new System.Drawing.Point(142, 95);
            this.MskTcKimlikNo.Mask = "00000000000";
            this.MskTcKimlikNo.Name = "MskTcKimlikNo";
            this.MskTcKimlikNo.Size = new System.Drawing.Size(153, 26);
            this.MskTcKimlikNo.TabIndex = 3;
            this.MskTcKimlikNo.ValidatingType = typeof(int);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(142, 127);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(153, 26);
            this.MskTelefon.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(142, 223);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(153, 34);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnHesapNo
            // 
            this.BtnHesapNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHesapNo.Location = new System.Drawing.Point(301, 159);
            this.BtnHesapNo.Name = "BtnHesapNo";
            this.BtnHesapNo.Size = new System.Drawing.Size(32, 26);
            this.BtnHesapNo.TabIndex = 22;
            this.BtnHesapNo.Text = "...";
            this.BtnHesapNo.UseVisualStyleBackColor = true;
            this.BtnHesapNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 293);
            this.Controls.Add(this.BtnHesapNo);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.MskTcKimlikNo);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskHesapNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTcKimlikNo;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnHesapNo;
    }
}