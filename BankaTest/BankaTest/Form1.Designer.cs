
namespace BankaTest
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.LnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(150, 100);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(153, 26);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.Location = new System.Drawing.Point(150, 132);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(153, 42);
            this.BtnGirisYap.TabIndex = 3;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(150, 68);
            this.MskHesapNo.Mask = "000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(153, 26);
            this.MskHesapNo.TabIndex = 1;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // LnkKayitOl
            // 
            this.LnkKayitOl.AutoSize = true;
            this.LnkKayitOl.Location = new System.Drawing.Point(241, 191);
            this.LnkKayitOl.Name = "LnkKayitOl";
            this.LnkKayitOl.Size = new System.Drawing.Size(62, 20);
            this.LnkKayitOl.TabIndex = 4;
            this.LnkKayitOl.TabStop = true;
            this.LnkKayitOl.Text = "Kayıt Ol";
            this.LnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayitOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 245);
            this.Controls.Add(this.LnkKayitOl);
            this.Controls.Add(this.MskHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.LinkLabel LnkKayitOl;
    }
}

