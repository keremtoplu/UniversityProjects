
namespace Personel_kayit
{
    partial class frmgiris
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
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kulsif = new System.Windows.Forms.TextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txt_kad
            // 
            this.txt_kad.Location = new System.Drawing.Point(176, 36);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.Size = new System.Drawing.Size(203, 24);
            this.txt_kad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txt_kulsif
            // 
            this.txt_kulsif.Location = new System.Drawing.Point(176, 66);
            this.txt_kulsif.Name = "txt_kulsif";
            this.txt_kulsif.Size = new System.Drawing.Size(203, 24);
            this.txt_kulsif.TabIndex = 3;
            this.txt_kulsif.UseSystemPasswordChar = true;
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(292, 96);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(87, 34);
            this.giris_btn.TabIndex = 4;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "PerTakip";
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(628, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.txt_kulsif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmgiris";
            this.Text = "frmgiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kulsif;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Label label3;
    }
}