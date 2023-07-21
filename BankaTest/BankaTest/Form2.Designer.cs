
namespace BankaTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblHesapNo = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblTcKimlikNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.LblBakiye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHareketler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC Kimlik No:";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(122, 33);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(35, 20);
            this.LblAdSoyad.TabIndex = 8;
            this.LblAdSoyad.Text = "Null";
            // 
            // LblHesapNo
            // 
            this.LblHesapNo.AutoSize = true;
            this.LblHesapNo.Location = new System.Drawing.Point(122, 72);
            this.LblHesapNo.Name = "LblHesapNo";
            this.LblHesapNo.Size = new System.Drawing.Size(35, 20);
            this.LblHesapNo.TabIndex = 9;
            this.LblHesapNo.Text = "Null";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(122, 111);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(35, 20);
            this.LblTelefon.TabIndex = 10;
            this.LblTelefon.Text = "Null";
            // 
            // LblTcKimlikNo
            // 
            this.LblTcKimlikNo.AutoSize = true;
            this.LblTcKimlikNo.Location = new System.Drawing.Point(122, 153);
            this.LblTcKimlikNo.Name = "LblTcKimlikNo";
            this.LblTcKimlikNo.Size = new System.Drawing.Size(35, 20);
            this.LblTcKimlikNo.TabIndex = 11;
            this.LblTcKimlikNo.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHareketler);
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.MskHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(19, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hesap No:";
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(103, 36);
            this.MskHesapNo.Mask = "000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(145, 26);
            this.MskHesapNo.TabIndex = 1;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(103, 68);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(145, 26);
            this.TxtTutar.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tutar:";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(103, 100);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(145, 34);
            this.BtnGonder.TabIndex = 3;
            this.BtnGonder.Text = "GÖNDER";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // LblBakiye
            // 
            this.LblBakiye.AutoSize = true;
            this.LblBakiye.Location = new System.Drawing.Point(349, 33);
            this.LblBakiye.Name = "LblBakiye";
            this.LblBakiye.Size = new System.Drawing.Size(35, 20);
            this.LblBakiye.TabIndex = 14;
            this.LblBakiye.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bakiye:";
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Location = new System.Drawing.Point(103, 140);
            this.BtnHareketler.Name = "BtnHareketler";
            this.BtnHareketler.Size = new System.Drawing.Size(145, 34);
            this.BtnHareketler.TabIndex = 17;
            this.BtnHareketler.Text = "HAREKETLER";
            this.BtnHareketler.UseVisualStyleBackColor = true;
            this.BtnHareketler.Click += new System.EventHandler(this.BtnHareketler_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.LblBakiye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTcKimlikNo);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblHesapNo);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havale Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblHesapNo;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblTcKimlikNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label LblBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnHareketler;
    }
}