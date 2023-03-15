namespace recursive
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faktöriyel ve Fibonacci değeri hesaplanacak sayıyı girin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(369, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 108);
            this.listBox1.TabIndex = 2;
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.Location = new System.Drawing.Point(85, 190);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(260, 36);
            this.hesaplaButton.TabIndex = 3;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = true;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(369, 190);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(260, 36);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 271);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MEHMET FATİH KARATEPE 2020123100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Button silButton;
    }
}

