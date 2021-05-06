
namespace EntityOrnek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciKaydet = new System.Windows.Forms.Button();
            this.TxtOgrenciFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnDersKaydet = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOgrenciBul = new System.Windows.Forms.Button();
            this.BtnOgrenciSil = new System.Windows.Forms.Button();
            this.BtnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDersSil = new System.Windows.Forms.Button();
            this.BtnDersGuncelle = new System.Windows.Forms.Button();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNotBul = new System.Windows.Forms.Button();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.BtnSinavNotuGuncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.CmbOgrenciListeleme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnOgrenciKaydet
            // 
            this.BtnOgrenciKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciKaydet.Location = new System.Drawing.Point(495, 147);
            this.BtnOgrenciKaydet.Name = "BtnOgrenciKaydet";
            this.BtnOgrenciKaydet.Size = new System.Drawing.Size(486, 48);
            this.BtnOgrenciKaydet.TabIndex = 2;
            this.BtnOgrenciKaydet.Text = "Öğrenci Kaydet";
            this.BtnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.BtnOgrenciKaydet.Click += new System.EventHandler(this.BtnOgrenciKaydet_Click);
            // 
            // TxtOgrenciFoto
            // 
            this.TxtOgrenciFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOgrenciFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrenciFoto.Location = new System.Drawing.Point(495, 111);
            this.TxtOgrenciFoto.Name = "TxtOgrenciFoto";
            this.TxtOgrenciFoto.Size = new System.Drawing.Size(486, 30);
            this.TxtOgrenciFoto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "FOTOĞRAF :";
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOgrenciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(495, 75);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(486, 30);
            this.TxtOgrenciSoyad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYAD :";
            // 
            // TxtOgrenciAd
            // 
            this.TxtOgrenciAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrenciAd.Location = new System.Drawing.Point(495, 39);
            this.TxtOgrenciAd.Name = "TxtOgrenciAd";
            this.TxtOgrenciAd.Size = new System.Drawing.Size(486, 30);
            this.TxtOgrenciAd.TabIndex = 17;
            this.TxtOgrenciAd.TextChanged += new System.EventHandler(this.TxtOgrenciAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "AD : ";
            // 
            // TxtOgrenciId
            // 
            this.TxtOgrenciId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOgrenciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrenciId.Location = new System.Drawing.Point(495, 3);
            this.TxtOgrenciId.Name = "TxtOgrenciId";
            this.TxtOgrenciId.Size = new System.Drawing.Size(486, 30);
            this.TxtOgrenciId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID : ";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDersAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDersAd.Location = new System.Drawing.Point(495, 39);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(486, 30);
            this.TxtDersAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "AD : ";
            // 
            // TxtDersId
            // 
            this.TxtDersId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDersId.Location = new System.Drawing.Point(495, 3);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(486, 30);
            this.TxtDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID : ";
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotListesi.Location = new System.Drawing.Point(3, 242);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(486, 48);
            this.BtnNotListesi.TabIndex = 24;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersKaydet.Location = new System.Drawing.Point(495, 75);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(486, 48);
            this.BtnDersKaydet.TabIndex = 22;
            this.BtnDersKaydet.Text = "Ders Kaydet";
            this.BtnDersKaydet.UseVisualStyleBackColor = true;
            this.BtnDersKaydet.Click += new System.EventHandler(this.BtnDersKaydet_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(13, 362);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 424);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenciler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnOgrenciSil, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnOgrenciGuncelle, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtOgrenciFoto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtOgrenciId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtOgrenciAd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtOgrenciSoyad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnOgrenciKaydet, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnOgrenciBul, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnOgrenciListele, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.CmbOgrenciListeleme, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnOgrenciBul
            // 
            this.BtnOgrenciBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciBul.Location = new System.Drawing.Point(3, 147);
            this.BtnOgrenciBul.Name = "BtnOgrenciBul";
            this.BtnOgrenciBul.Size = new System.Drawing.Size(486, 48);
            this.BtnOgrenciBul.TabIndex = 30;
            this.BtnOgrenciBul.Text = "Öğrenci Bul";
            this.BtnOgrenciBul.UseVisualStyleBackColor = true;
            this.BtnOgrenciBul.Click += new System.EventHandler(this.BtnOgrenciBul_Click);
            // 
            // BtnOgrenciSil
            // 
            this.BtnOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciSil.Location = new System.Drawing.Point(495, 201);
            this.BtnOgrenciSil.Name = "BtnOgrenciSil";
            this.BtnOgrenciSil.Size = new System.Drawing.Size(486, 48);
            this.BtnOgrenciSil.TabIndex = 29;
            this.BtnOgrenciSil.Text = "Öğrenci Sil";
            this.BtnOgrenciSil.UseVisualStyleBackColor = true;
            this.BtnOgrenciSil.Click += new System.EventHandler(this.BtnOgrenciSil_Click);
            // 
            // BtnOgrenciGuncelle
            // 
            this.BtnOgrenciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciGuncelle.Location = new System.Drawing.Point(3, 201);
            this.BtnOgrenciGuncelle.Name = "BtnOgrenciGuncelle";
            this.BtnOgrenciGuncelle.Size = new System.Drawing.Size(486, 48);
            this.BtnOgrenciGuncelle.TabIndex = 28;
            this.BtnOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.BtnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.BtnOgrenciGuncelle.Click += new System.EventHandler(this.BtnOgrenciGuncelle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dersler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnDersSil, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnDersGuncelle, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtDersId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtDersAd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDersKaydet, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnDersListesi, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 380);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(3, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ders Bul";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnDersSil
            // 
            this.BtnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersSil.Location = new System.Drawing.Point(495, 129);
            this.BtnDersSil.Name = "BtnDersSil";
            this.BtnDersSil.Size = new System.Drawing.Size(486, 48);
            this.BtnDersSil.TabIndex = 27;
            this.BtnDersSil.Text = "Ders Sil";
            this.BtnDersSil.UseVisualStyleBackColor = true;
            // 
            // BtnDersGuncelle
            // 
            this.BtnDersGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDersGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersGuncelle.Location = new System.Drawing.Point(3, 129);
            this.BtnDersGuncelle.Name = "BtnDersGuncelle";
            this.BtnDersGuncelle.Size = new System.Drawing.Size(486, 48);
            this.BtnDersGuncelle.TabIndex = 26;
            this.BtnDersGuncelle.Text = "Ders Güncelle";
            this.BtnDersGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersListesi.Location = new System.Drawing.Point(3, 75);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(486, 48);
            this.BtnDersListesi.TabIndex = 24;
            this.BtnDersListesi.Text = "Ders Listesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(990, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notlar";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnNotBul, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.BtnNotGuncelle, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.TxtSinav1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnNotListesi, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.TxtSinav2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtSinav3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtOrtalama, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.TxtDurum, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.BtnSinavNotuGuncelle, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.BtnHesapla, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(984, 380);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // BtnNotBul
            // 
            this.BtnNotBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotBul.Location = new System.Drawing.Point(495, 296);
            this.BtnNotBul.Name = "BtnNotBul";
            this.BtnNotBul.Size = new System.Drawing.Size(486, 48);
            this.BtnNotBul.TabIndex = 26;
            this.BtnNotBul.Text = "Not Bul";
            this.BtnNotBul.UseVisualStyleBackColor = true;
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotGuncelle.Location = new System.Drawing.Point(3, 296);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(486, 48);
            this.BtnNotGuncelle.TabIndex = 28;
            this.BtnNotGuncelle.Text = "Not Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(495, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(486, 48);
            this.button2.TabIndex = 27;
            this.button2.Text = "Not Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSinav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSinav1.Location = new System.Drawing.Point(495, 3);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(486, 30);
            this.TxtSinav1.TabIndex = 15;
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSinav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSinav2.Location = new System.Drawing.Point(495, 39);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(486, 30);
            this.TxtSinav2.TabIndex = 17;
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSinav3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSinav3.Location = new System.Drawing.Point(495, 75);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(486, 30);
            this.TxtSinav3.TabIndex = 19;
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOrtalama.Location = new System.Drawing.Point(495, 111);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(486, 30);
            this.TxtOrtalama.TabIndex = 21;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDurum.Location = new System.Drawing.Point(495, 147);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(486, 30);
            this.TxtDurum.TabIndex = 23;
            // 
            // BtnSinavNotuGuncelle
            // 
            this.BtnSinavNotuGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSinavNotuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavNotuGuncelle.Location = new System.Drawing.Point(495, 183);
            this.BtnSinavNotuGuncelle.Name = "BtnSinavNotuGuncelle";
            this.BtnSinavNotuGuncelle.Size = new System.Drawing.Size(486, 53);
            this.BtnSinavNotuGuncelle.TabIndex = 26;
            this.BtnSinavNotuGuncelle.Text = "Sınav notu güncelle";
            this.BtnSinavNotuGuncelle.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "SINAV1 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "SINAV2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "SINAV3 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "DURUM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "ORTALAMA :";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHesapla.Location = new System.Drawing.Point(3, 183);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(486, 53);
            this.BtnHesapla.TabIndex = 25;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciListele.Location = new System.Drawing.Point(3, 286);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(486, 48);
            this.BtnOgrenciListele.TabIndex = 37;
            this.BtnOgrenciListele.Text = "Öğrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // CmbOgrenciListeleme
            // 
            this.CmbOgrenciListeleme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOgrenciListeleme.FormattingEnabled = true;
            this.CmbOgrenciListeleme.Items.AddRange(new object[] {
            "Ada göre sıralayarak listeleme (A-Z)",
            "Ada göre sıralayarak listeleme (Z-A)",
            "İlk üç kayıtı listeleme",
            "Öğrenci Id sine göre listeleme",
            "Adı \'a\' karakteri ile başlayanları listeleme",
            "Adı \'a\' karakteri ile bitenleri listeleme",
            "Girilen öğrenci Id sine sahip bir öğrenci varsa listeleme",
            "En yüksek sınav 1 notu alan öğrenciyi listeleme",
            "Hepsini listeleme"});
            this.CmbOgrenciListeleme.Location = new System.Drawing.Point(3, 255);
            this.CmbOgrenciListeleme.Name = "CmbOgrenciListeleme";
            this.CmbOgrenciListeleme.Size = new System.Drawing.Size(486, 33);
            this.CmbOgrenciListeleme.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1033, 798);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrenciKaydet;
        private System.Windows.Forms.TextBox TxtOgrenciFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOgrenciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnDersKaydet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Button BtnSinavNotuGuncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnOgrenciBul;
        private System.Windows.Forms.Button BtnOgrenciSil;
        private System.Windows.Forms.Button BtnOgrenciGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDersSil;
        private System.Windows.Forms.Button BtnDersGuncelle;
        private System.Windows.Forms.Button BtnNotBul;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.ComboBox CmbOgrenciListeleme;
    }
}

