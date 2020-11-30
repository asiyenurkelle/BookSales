
namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    partial class SalesForm
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
            this.labelTutar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxSiparisListesi = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxOrder = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxTC = new System.Windows.Forms.ListBox();
            this.textboxAdress = new System.Windows.Forms.ListBox();
            this.textboxName = new System.Windows.Forms.ListBox();
            this.textboxPhone = new System.Windows.Forms.ListBox();
            this.gridViewBook = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapSatisDataSet3 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet3();
            this.kitapSatisDataSet = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet();
            this.tblBookTableAdapter = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet3TableAdapters.TblBookTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOrder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonTamamla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSiparisAl = new System.Windows.Forms.Button();
            this.kitapSatisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTutar2 = new System.Windows.Forms.Label();
            this.groupBoxSiparisListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar.Location = new System.Drawing.Point(494, 200);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(50, 25);
            this.labelTutar.TabIndex = 19;
            this.labelTutar.Text = "tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(424, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tutar:";
            // 
            // groupBoxSiparisListesi
            // 
            this.groupBoxSiparisListesi.Controls.Add(this.label7);
            this.groupBoxSiparisListesi.Controls.Add(this.textboxOrder);
            this.groupBoxSiparisListesi.Controls.Add(this.label5);
            this.groupBoxSiparisListesi.Controls.Add(this.label4);
            this.groupBoxSiparisListesi.Controls.Add(this.label2);
            this.groupBoxSiparisListesi.Controls.Add(this.label1);
            this.groupBoxSiparisListesi.Controls.Add(this.textboxTC);
            this.groupBoxSiparisListesi.Controls.Add(this.textboxAdress);
            this.groupBoxSiparisListesi.Controls.Add(this.textboxName);
            this.groupBoxSiparisListesi.Controls.Add(this.textboxPhone);
            this.groupBoxSiparisListesi.Location = new System.Drawing.Point(12, 256);
            this.groupBoxSiparisListesi.Name = "groupBoxSiparisListesi";
            this.groupBoxSiparisListesi.Size = new System.Drawing.Size(663, 144);
            this.groupBoxSiparisListesi.TabIndex = 16;
            this.groupBoxSiparisListesi.TabStop = false;
            this.groupBoxSiparisListesi.Text = "Siparis Listesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Siparişler";
            // 
            // textboxOrder
            // 
            this.textboxOrder.FormattingEnabled = true;
            this.textboxOrder.HorizontalScrollbar = true;
            this.textboxOrder.Location = new System.Drawing.Point(466, 38);
            this.textboxOrder.Name = "textboxOrder";
            this.textboxOrder.Size = new System.Drawing.Size(190, 95);
            this.textboxOrder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad ve Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC Kimlik No";
            // 
            // textboxTC
            // 
            this.textboxTC.FormattingEnabled = true;
            this.textboxTC.Location = new System.Drawing.Point(6, 38);
            this.textboxTC.Name = "textboxTC";
            this.textboxTC.Size = new System.Drawing.Size(73, 95);
            this.textboxTC.TabIndex = 0;
            // 
            // textboxAdress
            // 
            this.textboxAdress.FormattingEnabled = true;
            this.textboxAdress.HorizontalScrollbar = true;
            this.textboxAdress.Location = new System.Drawing.Point(305, 38);
            this.textboxAdress.Name = "textboxAdress";
            this.textboxAdress.Size = new System.Drawing.Size(155, 95);
            this.textboxAdress.TabIndex = 4;
            // 
            // textboxName
            // 
            this.textboxName.FormattingEnabled = true;
            this.textboxName.Location = new System.Drawing.Point(85, 38);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(120, 95);
            this.textboxName.TabIndex = 1;
            // 
            // textboxPhone
            // 
            this.textboxPhone.FormattingEnabled = true;
            this.textboxPhone.Location = new System.Drawing.Point(211, 38);
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new System.Drawing.Size(88, 95);
            this.textboxPhone.TabIndex = 3;
            // 
            // gridViewBook
            // 
            this.gridViewBook.AutoGenerateColumns = false;
            this.gridViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.writerFullNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.gridViewBook.DataSource = this.tblBookBindingSource;
            this.gridViewBook.Location = new System.Drawing.Point(12, 12);
            this.gridViewBook.Name = "gridViewBook";
            this.gridViewBook.Size = new System.Drawing.Size(663, 151);
            this.gridViewBook.TabIndex = 20;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // writerFullNameDataGridViewTextBoxColumn
            // 
            this.writerFullNameDataGridViewTextBoxColumn.DataPropertyName = "WriterFullName";
            this.writerFullNameDataGridViewTextBoxColumn.HeaderText = "WriterFullName";
            this.writerFullNameDataGridViewTextBoxColumn.Name = "writerFullNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // tblBookBindingSource
            // 
            this.tblBookBindingSource.DataMember = "TblBook";
            this.tblBookBindingSource.DataSource = this.kitapSatisDataSet3;
            // 
            // kitapSatisDataSet3
            // 
            this.kitapSatisDataSet3.DataSetName = "KitapSatisDataSet3";
            this.kitapSatisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapSatisDataSet
            // 
            this.kitapSatisDataSet.DataSetName = "KitapSatisDataSet";
            this.kitapSatisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBookTableAdapter
            // 
            this.tblBookTableAdapter.ClearBeforeFill = true;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrder.Location = new System.Drawing.Point(376, 447);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(57, 25);
            this.lblOrder.TabIndex = 24;
            this.lblOrder.Text = "order";
            this.lblOrder.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 447);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeri.Location = new System.Drawing.Point(279, 180);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(69, 70);
            this.buttonGeri.TabIndex = 23;
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonTamamla
            // 
            this.buttonTamamla.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.buttonTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTamamla.Location = new System.Drawing.Point(187, 180);
            this.buttonTamamla.Name = "buttonTamamla";
            this.buttonTamamla.Size = new System.Drawing.Size(69, 70);
            this.buttonTamamla.TabIndex = 22;
            this.buttonTamamla.UseVisualStyleBackColor = true;
            this.buttonTamamla.Click += new System.EventHandler(this.buttonTamamla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.delete;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Location = new System.Drawing.Point(97, 180);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(69, 70);
            this.buttonSil.TabIndex = 21;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSiparisAl
            // 
            this.buttonSiparisAl.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.buttonSiparisAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiparisAl.Location = new System.Drawing.Point(12, 180);
            this.buttonSiparisAl.Name = "buttonSiparisAl";
            this.buttonSiparisAl.Size = new System.Drawing.Size(71, 70);
            this.buttonSiparisAl.TabIndex = 17;
            this.buttonSiparisAl.UseVisualStyleBackColor = true;
            this.buttonSiparisAl.Click += new System.EventHandler(this.buttonSiparisAl_Click);
            // 
            // labelTutar2
            // 
            this.labelTutar2.AutoSize = true;
            this.labelTutar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar2.Location = new System.Drawing.Point(297, 447);
            this.labelTutar2.Name = "labelTutar2";
            this.labelTutar2.Size = new System.Drawing.Size(64, 25);
            this.labelTutar2.TabIndex = 26;
            this.labelTutar2.Text = "Tutar:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 408);
            this.Controls.Add(this.labelTutar2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonTamamla);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.gridViewBook);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSiparisAl);
            this.Controls.Add(this.groupBoxSiparisListesi);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBoxSiparisListesi.ResumeLayout(false);
            this.groupBoxSiparisListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSiparisAl;
        private System.Windows.Forms.GroupBox groupBoxSiparisListesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox textboxOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox textboxAdress;
        public System.Windows.Forms.ListBox textboxName;
        public System.Windows.Forms.ListBox textboxPhone;
        private System.Windows.Forms.DataGridView gridViewBook;
        private System.Windows.Forms.BindingSource kitapSatisDataSetBindingSource;
        private KitapSatisDataSet kitapSatisDataSet;
        private KitapSatisDataSet3 kitapSatisDataSet3;
        private System.Windows.Forms.BindingSource tblBookBindingSource;
        private KitapSatisDataSet3TableAdapters.TblBookTableAdapter tblBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonTamamla;
        private System.Windows.Forms.Button buttonGeri;
        public System.Windows.Forms.ListBox textboxTC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTutar2;
    }
}