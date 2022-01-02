
namespace Personel_kayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maas = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.PerMed = new System.Windows.Forms.Label();
            this.bekarbut = new System.Windows.Forms.RadioButton();
            this.evlibut = new System.Windows.Forms.RadioButton();
            this.txt_meslek = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Sehir = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grafik = new System.Windows.Forms.Button();
            this.İstatis = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeri_TabaniDataSet = new Personel_kayit.PersonelVeri_TabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personelTableAdapter = new Personel_kayit.PersonelVeri_TabaniDataSetTableAdapters.PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeri_TabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Maas);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.PerMed);
            this.groupBox1.Controls.Add(this.bekarbut);
            this.groupBox1.Controls.Add(this.evlibut);
            this.groupBox1.Controls.Add(this.txt_meslek);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.Sehir);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 365);
            this.groupBox1.TabIndex = 333;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Maas
            // 
            this.Maas.AutoSize = true;
            this.Maas.Location = new System.Drawing.Point(67, 252);
            this.Maas.Name = "Maas";
            this.Maas.Size = new System.Drawing.Size(59, 24);
            this.Maas.TabIndex = 14;
            this.Maas.Text = "Maaş:";
            this.Maas.Click += new System.EventHandler(this.label7_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 249);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(178, 32);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // PerMed
            // 
            this.PerMed.AutoSize = true;
            this.PerMed.Location = new System.Drawing.Point(6, 293);
            this.PerMed.Name = "PerMed";
            this.PerMed.Size = new System.Drawing.Size(139, 24);
            this.PerMed.TabIndex = 12;
            this.PerMed.Text = "Medeni Durum:";
            // 
            // bekarbut
            // 
            this.bekarbut.AutoSize = true;
            this.bekarbut.Location = new System.Drawing.Point(230, 293);
            this.bekarbut.Name = "bekarbut";
            this.bekarbut.Size = new System.Drawing.Size(80, 28);
            this.bekarbut.TabIndex = 7;
            this.bekarbut.TabStop = true;
            this.bekarbut.Text = "Bekar";
            this.bekarbut.UseVisualStyleBackColor = true;
            this.bekarbut.CheckedChanged += new System.EventHandler(this.bekarbut_CheckedChanged);
            // 
            // evlibut
            // 
            this.evlibut.AutoSize = true;
            this.evlibut.Location = new System.Drawing.Point(151, 293);
            this.evlibut.Name = "evlibut";
            this.evlibut.Size = new System.Drawing.Size(61, 28);
            this.evlibut.TabIndex = 6;
            this.evlibut.TabStop = true;
            this.evlibut.Text = "Evli";
            this.evlibut.UseVisualStyleBackColor = true;
            this.evlibut.CheckedChanged += new System.EventHandler(this.evlibut_CheckedChanged);
            // 
            // txt_meslek
            // 
            this.txt_meslek.AutoSize = true;
            this.txt_meslek.Location = new System.Drawing.Point(52, 330);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.Size = new System.Drawing.Size(74, 24);
            this.txt_meslek.TabIndex = 9;
            this.txt_meslek.Text = "Meslek:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 32);
            this.textBox4.TabIndex = 8;
            // 
            // Sehir
            // 
            this.Sehir.AutoSize = true;
            this.Sehir.Location = new System.Drawing.Point(67, 197);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(59, 24);
            this.Sehir.TabIndex = 6;
            this.Sehir.Text = "Şehir:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 32);
            this.textBox3.TabIndex = 3;
            // 
            // txt_soyad
            // 
            this.txt_soyad.AutoSize = true;
            this.txt_soyad.Location = new System.Drawing.Point(58, 146);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(68, 24);
            this.txt_soyad.TabIndex = 4;
            this.txt_soyad.Text = "Soyad:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 32);
            this.textBox2.TabIndex = 2;
            // 
            // txt_ad
            // 
            this.txt_ad.AutoSize = true;
            this.txt_ad.Location = new System.Drawing.Point(12, 95);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(114, 24);
            this.txt_ad.TabIndex = 2;
            this.txt_ad.Text = "Personel Ad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 32);
            this.textBox1.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(19, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(107, 24);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "Personel id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grafik);
            this.groupBox2.Controls.Add(this.İstatis);
            this.groupBox2.Controls.Add(this.Temizle);
            this.groupBox2.Controls.Add(this.Güncelle);
            this.groupBox2.Controls.Add(this.Sil);
            this.groupBox2.Controls.Add(this.Kaydet);
            this.groupBox2.Controls.Add(this.Listele);
            this.groupBox2.Location = new System.Drawing.Point(603, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 353);
            this.groupBox2.TabIndex = 222;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Grafik
            // 
            this.Grafik.Location = new System.Drawing.Point(15, 261);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(188, 33);
            this.Grafik.TabIndex = 6;
            this.Grafik.Text = "Grafik";
            this.Grafik.UseVisualStyleBackColor = true;
            // 
            // İstatis
            // 
            this.İstatis.Location = new System.Drawing.Point(15, 223);
            this.İstatis.Name = "İstatis";
            this.İstatis.Size = new System.Drawing.Size(188, 32);
            this.İstatis.TabIndex = 5;
            this.İstatis.Text = "İstatistik";
            this.İstatis.UseVisualStyleBackColor = true;
            this.İstatis.Click += new System.EventHandler(this.İstatis_Click);
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(15, 186);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(188, 31);
            this.Temizle.TabIndex = 4;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Güncelle
            // 
            this.Güncelle.Location = new System.Drawing.Point(15, 148);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(188, 32);
            this.Güncelle.TabIndex = 3;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(15, 113);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(188, 29);
            this.Sil.TabIndex = 2;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(15, 78);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(188, 29);
            this.Kaydet.TabIndex = 1;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(15, 33);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(188, 32);
            this.Listele.TabIndex = 0;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 278);
            this.groupBox3.TabIndex = 777;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 247);
            this.dataGridView1.TabIndex = 555;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "Perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personelVeri_TabaniDataSet;
            // 
            // personelVeri_TabaniDataSet
            // 
            this.personelVeri_TabaniDataSet.DataSetName = "PersonelVeri_TabaniDataSet";
            this.personelVeri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 778;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeri_TabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Maas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label PerMed;
        private System.Windows.Forms.RadioButton bekarbut;
        private System.Windows.Forms.RadioButton evlibut;
        private System.Windows.Forms.Label txt_meslek;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Sehir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txt_soyad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txt_ad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Grafik;
        private System.Windows.Forms.Button İstatis;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Güncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeri_TabaniDataSet personelVeri_TabaniDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private PersonelVeri_TabaniDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

