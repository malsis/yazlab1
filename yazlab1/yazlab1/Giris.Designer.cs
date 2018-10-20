namespace yazlab1
{
    partial class Giris
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
            this.K_adi = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.uyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // K_adi
            // 
            this.K_adi.AutoSize = true;
            this.K_adi.Location = new System.Drawing.Point(82, 83);
            this.K_adi.Name = "K_adi";
            this.K_adi.Size = new System.Drawing.Size(64, 13);
            this.K_adi.TabIndex = 0;
            this.K_adi.Text = "Kullanıcı Adı";
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.Location = new System.Drawing.Point(109, 117);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(37, 13);
            this.parola.TabIndex = 1;
            this.parola.Text = "Parola";
            this.parola.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(112, 152);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(75, 23);
            this.giris_btn.TabIndex = 4;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // uyeOl
            // 
            this.uyeOl.AutoSize = true;
            this.uyeOl.Location = new System.Drawing.Point(229, 157);
            this.uyeOl.Name = "uyeOl";
            this.uyeOl.Size = new System.Drawing.Size(43, 13);
            this.uyeOl.TabIndex = 5;
            this.uyeOl.TabStop = true;
            this.uyeOl.Text = "Üye ol?";
            this.uyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 295);
            this.Controls.Add(this.uyeOl);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.K_adi);
            this.Name = "Giris";
            this.Text = "BX-BookReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label K_adi;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.LinkLabel uyeOl;
    }
}

