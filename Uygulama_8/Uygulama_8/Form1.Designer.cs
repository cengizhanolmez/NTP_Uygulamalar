namespace Uygulama_8
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
            this.buttonYuzde10 = new System.Windows.Forms.Button();
            this.buttonYuzde25 = new System.Windows.Forms.Button();
            this.buttonYuzde50 = new System.Windows.Forms.Button();
            this.buttonYuzde75 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelİndirimliFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket Fiyatı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 1;
            // 
            // buttonYuzde10
            // 
            this.buttonYuzde10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonYuzde10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonYuzde10.Location = new System.Drawing.Point(13, 79);
            this.buttonYuzde10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonYuzde10.Name = "buttonYuzde10";
            this.buttonYuzde10.Size = new System.Drawing.Size(78, 73);
            this.buttonYuzde10.TabIndex = 2;
            this.buttonYuzde10.Text = "Yüzde 10 İNDİRİM";
            this.buttonYuzde10.UseVisualStyleBackColor = false;
            this.buttonYuzde10.Click += new System.EventHandler(this.buttonYuzde10_Click);
            // 
            // buttonYuzde25
            // 
            this.buttonYuzde25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonYuzde25.Location = new System.Drawing.Point(117, 79);
            this.buttonYuzde25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonYuzde25.Name = "buttonYuzde25";
            this.buttonYuzde25.Size = new System.Drawing.Size(78, 73);
            this.buttonYuzde25.TabIndex = 3;
            this.buttonYuzde25.Text = "Yüzde 25 İNDİRİM";
            this.buttonYuzde25.UseVisualStyleBackColor = false;
            this.buttonYuzde25.Click += new System.EventHandler(this.buttonYuzde25_Click);
            // 
            // buttonYuzde50
            // 
            this.buttonYuzde50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonYuzde50.Location = new System.Drawing.Point(221, 79);
            this.buttonYuzde50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonYuzde50.Name = "buttonYuzde50";
            this.buttonYuzde50.Size = new System.Drawing.Size(87, 73);
            this.buttonYuzde50.TabIndex = 4;
            this.buttonYuzde50.Text = "Yüzde 50 İNDİRİM";
            this.buttonYuzde50.UseVisualStyleBackColor = false;
            this.buttonYuzde50.Click += new System.EventHandler(this.buttonYuzde50_Click);
            // 
            // buttonYuzde75
            // 
            this.buttonYuzde75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonYuzde75.Location = new System.Drawing.Point(325, 79);
            this.buttonYuzde75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonYuzde75.Name = "buttonYuzde75";
            this.buttonYuzde75.Size = new System.Drawing.Size(88, 73);
            this.buttonYuzde75.TabIndex = 5;
            this.buttonYuzde75.Text = "Yüzde 75 İNDİRİM";
            this.buttonYuzde75.UseVisualStyleBackColor = false;
            this.buttonYuzde75.Click += new System.EventHandler(this.buttonYuzde75_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İndirimli Fiyatı:";
            // 
            // labelİndirimliFiyat
            // 
            this.labelİndirimliFiyat.AutoSize = true;
            this.labelİndirimliFiyat.Location = new System.Drawing.Point(154, 179);
            this.labelİndirimliFiyat.Name = "labelİndirimliFiyat";
            this.labelİndirimliFiyat.Size = new System.Drawing.Size(0, 20);
            this.labelİndirimliFiyat.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 210);
            this.Controls.Add(this.labelİndirimliFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonYuzde75);
            this.Controls.Add(this.buttonYuzde50);
            this.Controls.Add(this.buttonYuzde25);
            this.Controls.Add(this.buttonYuzde10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "İndirimli Ürün";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonYuzde10;
        private System.Windows.Forms.Button buttonYuzde25;
        private System.Windows.Forms.Button buttonYuzde50;
        private System.Windows.Forms.Button buttonYuzde75;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelİndirimliFiyat;
    }
}

