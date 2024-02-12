namespace Personel_Kayit
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabaniDataSet = new Personel_Kayit.personelveritabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.personelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRaporlar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel id:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(106, 108);
            this.Txtid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(185, 27);
            this.Txtid.TabIndex = 0;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(106, 141);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(185, 27);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(106, 174);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(185, 27);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(106, 208);
            this.CmbSehir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(185, 29);
            this.CmbSehir.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Meslek:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(113, 286);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(188, 286);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MskMaas);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmbSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(376, 416);
            this.groupBox1.TabIndex = 222;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(106, 324);
            this.TxtMeslek.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(185, 27);
            this.TxtMeslek.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maaş:";
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(106, 253);
            this.MskMaas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MskMaas.Mask = "00000";
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(185, 27);
            this.MskMaas.TabIndex = 5;
            this.MskMaas.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRaporlar);
            this.groupBox2.Controls.Add(this.BtnGrafikler);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Location = new System.Drawing.Point(409, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(315, 416);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Location = new System.Drawing.Point(76, 315);
            this.BtnGrafikler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(125, 30);
            this.BtnGrafikler.TabIndex = 14;
            this.BtnGrafikler.Text = "Grafikler";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.Location = new System.Drawing.Point(76, 271);
            this.Btnİstatistik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(125, 30);
            this.Btnİstatistik.TabIndex = 13;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            this.Btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(76, 226);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(125, 30);
            this.BtnTemizle.TabIndex = 12;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(76, 181);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(125, 30);
            this.BtnGüncelle.TabIndex = 12;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(76, 135);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(125, 30);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(76, 91);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 30);
            this.BtnKaydet.TabIndex = 10;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(76, 48);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(125, 30);
            this.BtnListele.TabIndex = 9;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 465);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(963, 279);
            this.groupBox3.TabIndex = 223;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perİdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(959, 253);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perİdDataGridViewTextBoxColumn
            // 
            this.perİdDataGridViewTextBoxColumn.DataPropertyName = "Perİd";
            this.perİdDataGridViewTextBoxColumn.HeaderText = "Perİd";
            this.perİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perİdDataGridViewTextBoxColumn.Name = "perİdDataGridViewTextBoxColumn";
            this.perİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perİdDataGridViewTextBoxColumn.Width = 125;
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
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelveritabaniDataSetBindingSource;
            // 
            // personelveritabaniDataSetBindingSource
            // 
            this.personelveritabaniDataSetBindingSource.DataSource = this.personelveritabaniDataSet;
            this.personelveritabaniDataSetBindingSource.Position = 0;
            // 
            // personelveritabaniDataSet
            // 
            this.personelveritabaniDataSet.DataSetName = "personelveritabaniDataSet";
            this.personelveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 224;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personel_Kayit.Properties.Resources.image_processing20210901_2342_d4346b;
            this.pictureBox1.Location = new System.Drawing.Point(754, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRaporlar
            // 
            this.BtnRaporlar.Location = new System.Drawing.Point(76, 359);
            this.BtnRaporlar.Name = "BtnRaporlar";
            this.BtnRaporlar.Size = new System.Drawing.Size(125, 32);
            this.BtnRaporlar.TabIndex = 15;
            this.BtnRaporlar.Text = "Raporlar";
            this.BtnRaporlar.UseVisualStyleBackColor = true;
            this.BtnRaporlar.Click += new System.EventHandler(this.BtnRaporlar_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1004, 769);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAnaForm";
            this.Text = "FrmAnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskMaas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtMeslek;
        private personelveritabaniDataSet personelveritabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private personelveritabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personelveritabaniDataSetBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRaporlar;
    }
}

