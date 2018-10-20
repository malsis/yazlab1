namespace yazlab1
{
    partial class UyeOl
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
            this.K_adi_box = new System.Windows.Forms.TextBox();
            this.parola_box = new System.Windows.Forms.TextBox();
            this.bolge_box = new System.Windows.Forms.TextBox();
            this.K_adi_lbl = new System.Windows.Forms.Label();
            this.parola_lbl = new System.Windows.Forms.Label();
            this.bolge_lbl = new System.Windows.Forms.Label();
            this.yas_box = new System.Windows.Forms.TextBox();
            this.yas_lbl = new System.Windows.Forms.Label();
            this.ileri_btn = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // K_adi_box
            // 
            this.K_adi_box.Location = new System.Drawing.Point(174, 74);
            this.K_adi_box.Name = "K_adi_box";
            this.K_adi_box.Size = new System.Drawing.Size(100, 20);
            this.K_adi_box.TabIndex = 0;
            // 
            // parola_box
            // 
            this.parola_box.Location = new System.Drawing.Point(174, 100);
            this.parola_box.Name = "parola_box";
            this.parola_box.Size = new System.Drawing.Size(100, 20);
            this.parola_box.TabIndex = 1;
            // 
            // bolge_box
            // 
            this.bolge_box.Location = new System.Drawing.Point(174, 126);
            this.bolge_box.Name = "bolge_box";
            this.bolge_box.Size = new System.Drawing.Size(100, 20);
            this.bolge_box.TabIndex = 2;
            // 
            // K_adi_lbl
            // 
            this.K_adi_lbl.AutoSize = true;
            this.K_adi_lbl.Location = new System.Drawing.Point(101, 80);
            this.K_adi_lbl.Name = "K_adi_lbl";
            this.K_adi_lbl.Size = new System.Drawing.Size(64, 13);
            this.K_adi_lbl.TabIndex = 3;
            this.K_adi_lbl.Text = "Kullanıcı Adı";
            // 
            // parola_lbl
            // 
            this.parola_lbl.AutoSize = true;
            this.parola_lbl.Location = new System.Drawing.Point(101, 107);
            this.parola_lbl.Name = "parola_lbl";
            this.parola_lbl.Size = new System.Drawing.Size(37, 13);
            this.parola_lbl.TabIndex = 4;
            this.parola_lbl.Text = "Parola";
            this.parola_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // bolge_lbl
            // 
            this.bolge_lbl.AutoSize = true;
            this.bolge_lbl.Location = new System.Drawing.Point(101, 133);
            this.bolge_lbl.Name = "bolge_lbl";
            this.bolge_lbl.Size = new System.Drawing.Size(34, 13);
            this.bolge_lbl.TabIndex = 5;
            this.bolge_lbl.Text = "Bölge";
            this.bolge_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // yas_box
            // 
            this.yas_box.Location = new System.Drawing.Point(174, 152);
            this.yas_box.Name = "yas_box";
            this.yas_box.Size = new System.Drawing.Size(100, 20);
            this.yas_box.TabIndex = 6;
            // 
            // yas_lbl
            // 
            this.yas_lbl.AutoSize = true;
            this.yas_lbl.Location = new System.Drawing.Point(101, 159);
            this.yas_lbl.Name = "yas_lbl";
            this.yas_lbl.Size = new System.Drawing.Size(25, 13);
            this.yas_lbl.TabIndex = 8;
            this.yas_lbl.Text = "Yaş";
            // 
            // ileri_btn
            // 
            this.ileri_btn.Location = new System.Drawing.Point(199, 190);
            this.ileri_btn.Name = "ileri_btn";
            this.ileri_btn.Size = new System.Drawing.Size(75, 23);
            this.ileri_btn.TabIndex = 9;
            this.ileri_btn.Text = "İleri";
            this.ileri_btn.UseVisualStyleBackColor = true;
            this.ileri_btn.Click += new System.EventHandler(this.ileri_btn_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(344, 12);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 10;
            this.geri.Text = "geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 299);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.ileri_btn);
            this.Controls.Add(this.yas_lbl);
            this.Controls.Add(this.yas_box);
            this.Controls.Add(this.bolge_lbl);
            this.Controls.Add(this.parola_lbl);
            this.Controls.Add(this.K_adi_lbl);
            this.Controls.Add(this.bolge_box);
            this.Controls.Add(this.parola_box);
            this.Controls.Add(this.K_adi_box);
            this.Name = "UyeOl";
            this.Text = "Üye Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox K_adi_box;
        private System.Windows.Forms.TextBox parola_box;
        private System.Windows.Forms.TextBox bolge_box;
        private System.Windows.Forms.Label K_adi_lbl;
        private System.Windows.Forms.Label parola_lbl;
        private System.Windows.Forms.Label bolge_lbl;
        private System.Windows.Forms.TextBox yas_box;
        private System.Windows.Forms.Label yas_lbl;
        private System.Windows.Forms.Button ileri_btn;
        private System.Windows.Forms.Button geri;
    }
}