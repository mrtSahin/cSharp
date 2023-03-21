namespace SiirApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yazarText = new System.Windows.Forms.TextBox();
            this.siirAdiText = new System.Windows.Forms.TextBox();
            this.satirSayisiText = new System.Windows.Forms.TextBox();
            this.besteleyenText = new System.Windows.Forms.TextBox();
            this.tarihText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şiir Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şiir Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satır Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Besteleyen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bestelendiği Tarih";
            // 
            // yazarText
            // 
            this.yazarText.Location = new System.Drawing.Point(229, 65);
            this.yazarText.Name = "yazarText";
            this.yazarText.Size = new System.Drawing.Size(100, 20);
            this.yazarText.TabIndex = 5;
            // 
            // siirAdiText
            // 
            this.siirAdiText.Location = new System.Drawing.Point(229, 111);
            this.siirAdiText.Name = "siirAdiText";
            this.siirAdiText.Size = new System.Drawing.Size(100, 20);
            this.siirAdiText.TabIndex = 6;
            // 
            // satirSayisiText
            // 
            this.satirSayisiText.Location = new System.Drawing.Point(229, 149);
            this.satirSayisiText.Name = "satirSayisiText";
            this.satirSayisiText.Size = new System.Drawing.Size(100, 20);
            this.satirSayisiText.TabIndex = 7;
            // 
            // besteleyenText
            // 
            this.besteleyenText.Location = new System.Drawing.Point(229, 189);
            this.besteleyenText.Name = "besteleyenText";
            this.besteleyenText.Size = new System.Drawing.Size(100, 20);
            this.besteleyenText.TabIndex = 8;
            // 
            // tarihText
            // 
            this.tarihText.Location = new System.Drawing.Point(229, 236);
            this.tarihText.Name = "tarihText";
            this.tarihText.Size = new System.Drawing.Size(100, 20);
            this.tarihText.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Şiiri Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(399, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 264);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarihText);
            this.Controls.Add(this.besteleyenText);
            this.Controls.Add(this.satirSayisiText);
            this.Controls.Add(this.siirAdiText);
            this.Controls.Add(this.yazarText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Murat Şahin 2020123019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yazarText;
        private System.Windows.Forms.TextBox siirAdiText;
        private System.Windows.Forms.TextBox satirSayisiText;
        private System.Windows.Forms.TextBox besteleyenText;
        private System.Windows.Forms.TextBox tarihText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

