namespace Uygulama_2
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
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_Dogum = new System.Windows.Forms.TextBox();
            this.textBox_Alan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Alan = new System.Windows.Forms.Label();
            this.Label_Dogum = new System.Windows.Forms.Label();
            this.Label_Soyad = new System.Windows.Forms.Label();
            this.Label_Ad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(105, 20);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ad.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(105, 59);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Soyad.TabIndex = 3;
            // 
            // textBox_Dogum
            // 
            this.textBox_Dogum.Location = new System.Drawing.Point(105, 96);
            this.textBox_Dogum.Name = "textBox_Dogum";
            this.textBox_Dogum.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dogum.TabIndex = 4;
            // 
            // textBox_Alan
            // 
            this.textBox_Alan.Location = new System.Drawing.Point(105, 136);
            this.textBox_Alan.Name = "textBox_Alan";
            this.textBox_Alan.Size = new System.Drawing.Size(100, 20);
            this.textBox_Alan.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADINIZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SOYADINIZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ALANI";
            // 
            // Label_Alan
            // 
            this.Label_Alan.AutoSize = true;
            this.Label_Alan.Location = new System.Drawing.Point(371, 143);
            this.Label_Alan.Name = "Label_Alan";
            this.Label_Alan.Size = new System.Drawing.Size(38, 13);
            this.Label_Alan.TabIndex = 13;
            this.Label_Alan.Text = "ALANI";
            // 
            // Label_Dogum
            // 
            this.Label_Dogum.AutoSize = true;
            this.Label_Dogum.Location = new System.Drawing.Point(371, 99);
            this.Label_Dogum.Name = "Label_Dogum";
            this.Label_Dogum.Size = new System.Drawing.Size(76, 13);
            this.Label_Dogum.TabIndex = 12;
            this.Label_Dogum.Text = "DOĞUM YERİ";
            // 
            // Label_Soyad
            // 
            this.Label_Soyad.AutoSize = true;
            this.Label_Soyad.Location = new System.Drawing.Point(371, 62);
            this.Label_Soyad.Name = "Label_Soyad";
            this.Label_Soyad.Size = new System.Drawing.Size(65, 13);
            this.Label_Soyad.TabIndex = 11;
            this.Label_Soyad.Text = "SOYADINIZ";
            // 
            // Label_Ad
            // 
            this.Label_Ad.AutoSize = true;
            this.Label_Ad.Location = new System.Drawing.Point(371, 23);
            this.Label_Ad.Name = "Label_Ad";
            this.Label_Ad.Size = new System.Drawing.Size(43, 13);
            this.Label_Ad.TabIndex = 10;
            this.Label_Ad.Text = "ADINIZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DOĞUM YERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(517, 222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_Alan);
            this.Controls.Add(this.Label_Dogum);
            this.Controls.Add(this.Label_Soyad);
            this.Controls.Add(this.Label_Ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Alan);
            this.Controls.Add(this.textBox_Dogum);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Ad);
            this.Name = "Form1";
            this.Text = "Uygulama 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_Dogum;
        private System.Windows.Forms.TextBox textBox_Alan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Alan;
        private System.Windows.Forms.Label Label_Dogum;
        private System.Windows.Forms.Label Label_Soyad;
        private System.Windows.Forms.Label Label_Ad;
        private System.Windows.Forms.Label label5;
    }
}

