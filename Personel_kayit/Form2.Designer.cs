
namespace Personel_kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltoplampers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toplammas = new System.Windows.Forms.Label();
            this.ortmas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bekar Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Farklı Şehir Sayısı:";
            // 
            // lbltoplampers
            // 
            this.lbltoplampers.AutoSize = true;
            this.lbltoplampers.Location = new System.Drawing.Point(177, 26);
            this.lbltoplampers.Name = "lbltoplampers";
            this.lbltoplampers.Size = new System.Drawing.Size(16, 17);
            this.lbltoplampers.TabIndex = 3;
            this.lbltoplampers.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toplam Maaş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ortalama Maaş:";
            // 
            // toplammas
            // 
            this.toplammas.AutoSize = true;
            this.toplammas.Location = new System.Drawing.Point(177, 120);
            this.toplammas.Name = "toplammas";
            this.toplammas.Size = new System.Drawing.Size(16, 17);
            this.toplammas.TabIndex = 8;
            this.toplammas.Text = "0";
            // 
            // ortmas
            // 
            this.ortmas.AutoSize = true;
            this.ortmas.Location = new System.Drawing.Point(179, 148);
            this.ortmas.Name = "ortmas";
            this.ortmas.Size = new System.Drawing.Size(16, 17);
            this.ortmas.TabIndex = 9;
            this.ortmas.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 218);
            this.Controls.Add(this.ortmas);
            this.Controls.Add(this.toplammas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltoplampers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltoplampers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label toplammas;
        private System.Windows.Forms.Label ortmas;
    }
}