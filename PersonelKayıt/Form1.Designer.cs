namespace PersonelKayıt
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
            this.PersonelKayıt = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textsehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.meslek = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.butistatistik = new System.Windows.Forms.Button();
            this.buttemizle = new System.Windows.Forms.Button();
            this.butsil = new System.Windows.Forms.Button();
            this.butgüncelle = new System.Windows.Forms.Button();
            this.butkaydet = new System.Windows.Forms.Button();
            this.butliste = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabanıDataSet2 = new PersonelKayıt.PersonelVeriTabanıDataSet2();
            this.tbl_PersonelTableAdapter = new PersonelKayıt.PersonelVeriTabanıDataSet2TableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonelKayıt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelKayıt
            // 
            this.PersonelKayıt.Controls.Add(this.label6);
            this.PersonelKayıt.Controls.Add(this.maas);
            this.PersonelKayıt.Controls.Add(this.label7);
            this.PersonelKayıt.Controls.Add(this.radioButton2);
            this.PersonelKayıt.Controls.Add(this.label5);
            this.PersonelKayıt.Controls.Add(this.radioButton1);
            this.PersonelKayıt.Controls.Add(this.textsehir);
            this.PersonelKayıt.Controls.Add(this.label4);
            this.PersonelKayıt.Controls.Add(this.meslek);
            this.PersonelKayıt.Controls.Add(this.textsoyad);
            this.PersonelKayıt.Controls.Add(this.textad);
            this.PersonelKayıt.Controls.Add(this.label3);
            this.PersonelKayıt.Controls.Add(this.txtid);
            this.PersonelKayıt.Controls.Add(this.label2);
            this.PersonelKayıt.Controls.Add(this.label1);
            this.PersonelKayıt.Location = new System.Drawing.Point(11, 10);
            this.PersonelKayıt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelKayıt.Name = "PersonelKayıt";
            this.PersonelKayıt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonelKayıt.Size = new System.Drawing.Size(294, 251);
            this.PersonelKayıt.TabIndex = 1;
            this.PersonelKayıt.TabStop = false;
            this.PersonelKayıt.Text = "Personel Kayıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "maaş";
            // 
            // maas
            // 
            this.maas.Location = new System.Drawing.Point(112, 159);
            this.maas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maas.Mask = "0000";
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(90, 27);
            this.maas.TabIndex = 5;
            this.maas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "meslek";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(170, 189);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 23);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "durum";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(116, 189);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 23);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textsehir
            // 
            this.textsehir.FormattingEnabled = true;
            this.textsehir.Location = new System.Drawing.Point(112, 122);
            this.textsehir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsehir.Name = "textsehir";
            this.textsehir.Size = new System.Drawing.Size(90, 27);
            this.textsehir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "şehir";
            // 
            // meslek
            // 
            this.meslek.Location = new System.Drawing.Point(116, 216);
            this.meslek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meslek.Name = "meslek";
            this.meslek.Size = new System.Drawing.Size(90, 27);
            this.meslek.TabIndex = 8;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(112, 92);
            this.textsoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(90, 27);
            this.textsoyad.TabIndex = 3;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(112, 61);
            this.textad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(90, 27);
            this.textad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(112, 31);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 27);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.butistatistik);
            this.groupBox1.Controls.Add(this.buttemizle);
            this.groupBox1.Controls.Add(this.butsil);
            this.groupBox1.Controls.Add(this.butgüncelle);
            this.groupBox1.Controls.Add(this.butkaydet);
            this.groupBox1.Controls.Add(this.butliste);
            this.groupBox1.Location = new System.Drawing.Point(321, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(182, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Linen;
            this.button8.Location = new System.Drawing.Point(69, 198);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 26);
            this.button8.TabIndex = 6;
            this.button8.Text = "grafikler";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // butistatistik
            // 
            this.butistatistik.BackColor = System.Drawing.Color.Linen;
            this.butistatistik.Location = new System.Drawing.Point(69, 171);
            this.butistatistik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butistatistik.Name = "butistatistik";
            this.butistatistik.Size = new System.Drawing.Size(81, 26);
            this.butistatistik.TabIndex = 5;
            this.butistatistik.Text = "istatistik";
            this.butistatistik.UseVisualStyleBackColor = false;
            this.butistatistik.Click += new System.EventHandler(this.butistatistik_Click);
            // 
            // buttemizle
            // 
            this.buttemizle.BackColor = System.Drawing.Color.Linen;
            this.buttemizle.Location = new System.Drawing.Point(69, 144);
            this.buttemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttemizle.Name = "buttemizle";
            this.buttemizle.Size = new System.Drawing.Size(81, 26);
            this.buttemizle.TabIndex = 4;
            this.buttemizle.Text = "temizle";
            this.buttemizle.UseVisualStyleBackColor = false;
            this.buttemizle.Click += new System.EventHandler(this.buttemizle_Click);
            // 
            // butsil
            // 
            this.butsil.BackColor = System.Drawing.Color.Linen;
            this.butsil.Location = new System.Drawing.Point(69, 83);
            this.butsil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butsil.Name = "butsil";
            this.butsil.Size = new System.Drawing.Size(81, 26);
            this.butsil.TabIndex = 2;
            this.butsil.Text = "sil";
            this.butsil.UseVisualStyleBackColor = false;
            this.butsil.Click += new System.EventHandler(this.butsil_Click);
            // 
            // butgüncelle
            // 
            this.butgüncelle.BackColor = System.Drawing.Color.Linen;
            this.butgüncelle.Location = new System.Drawing.Point(69, 113);
            this.butgüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butgüncelle.Name = "butgüncelle";
            this.butgüncelle.Size = new System.Drawing.Size(81, 26);
            this.butgüncelle.TabIndex = 3;
            this.butgüncelle.Text = "güncelle";
            this.butgüncelle.UseVisualStyleBackColor = false;
            this.butgüncelle.Click += new System.EventHandler(this.butgüncelle_Click);
            // 
            // butkaydet
            // 
            this.butkaydet.BackColor = System.Drawing.Color.Linen;
            this.butkaydet.Location = new System.Drawing.Point(69, 51);
            this.butkaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butkaydet.Name = "butkaydet";
            this.butkaydet.Size = new System.Drawing.Size(81, 26);
            this.butkaydet.TabIndex = 1;
            this.butkaydet.Text = "kaydet";
            this.butkaydet.UseVisualStyleBackColor = false;
            this.butkaydet.Click += new System.EventHandler(this.butkaydet_Click);
            // 
            // butliste
            // 
            this.butliste.BackColor = System.Drawing.Color.Linen;
            this.butliste.Location = new System.Drawing.Point(69, 17);
            this.butliste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butliste.Name = "butliste";
            this.butliste.Size = new System.Drawing.Size(81, 26);
            this.butliste.TabIndex = 0;
            this.butliste.Text = "listele";
            this.butliste.UseVisualStyleBackColor = false;
            this.butliste.Click += new System.EventHandler(this.butliste_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(729, 299);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
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
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DefaultCellStyleChanged += new System.EventHandler(this.dataGridView1_DefaultCellStyleChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabanıDataSet2;
            // 
            // personelVeriTabanıDataSet2
            // 
            this.personelVeriTabanıDataSet2.DataSetName = "PersonelVeriTabanıDataSet2";
            this.personelVeriTabanıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "XSASAXSA";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(752, 619);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PersonelKayıt);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PersonelKayıt.ResumeLayout(false);
            this.PersonelKayıt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonelKayıt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox textsehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox meslek;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button butistatistik;
        private System.Windows.Forms.Button buttemizle;
        private System.Windows.Forms.Button butsil;
        private System.Windows.Forms.Button butgüncelle;
        private System.Windows.Forms.Button butkaydet;
        private System.Windows.Forms.Button butliste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabanıDataSet2 personelVeriTabanıDataSet2;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabanıDataSet2TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

