
namespace Hastane_Randevu_Sistemi
{
    partial class FormSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsekreteradsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsekretertc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonduyuruolustur = new System.Windows.Forms.Button();
            this.richduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonrandevukaydet = new System.Windows.Forms.Button();
            this.checkBoxdurum = new System.Windows.Forms.CheckBox();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxdoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxsaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxtarih = new System.Windows.Forms.MaskedTextBox();
            this.textBoxidsekreter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asdasdcasdca = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonrandevulistesi = new System.Windows.Forms.Button();
            this.buttonbranspaneli = new System.Windows.Forms.Button();
            this.buttondoktorpaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.asdasdcasdca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsekreteradsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblsekretertc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblsekreteradsoyad
            // 
            this.lblsekreteradsoyad.AutoSize = true;
            this.lblsekreteradsoyad.Location = new System.Drawing.Point(75, 52);
            this.lblsekreteradsoyad.Name = "lblsekreteradsoyad";
            this.lblsekreteradsoyad.Size = new System.Drawing.Size(25, 13);
            this.lblsekreteradsoyad.TabIndex = 3;
            this.lblsekreteradsoyad.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad :";
            // 
            // lblsekretertc
            // 
            this.lblsekretertc.AutoSize = true;
            this.lblsekretertc.Location = new System.Drawing.Point(75, 26);
            this.lblsekretertc.Name = "lblsekretertc";
            this.lblsekretertc.Size = new System.Drawing.Size(73, 13);
            this.lblsekretertc.TabIndex = 1;
            this.lblsekretertc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonduyuruolustur);
            this.groupBox2.Controls.Add(this.richduyuru);
            this.groupBox2.Location = new System.Drawing.Point(2, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // buttonduyuruolustur
            // 
            this.buttonduyuruolustur.Location = new System.Drawing.Point(6, 109);
            this.buttonduyuruolustur.Name = "buttonduyuruolustur";
            this.buttonduyuruolustur.Size = new System.Drawing.Size(150, 23);
            this.buttonduyuruolustur.TabIndex = 1;
            this.buttonduyuruolustur.Text = "Oluştur";
            this.buttonduyuruolustur.UseVisualStyleBackColor = true;
            this.buttonduyuruolustur.Click += new System.EventHandler(this.buttonduyuruolustur_Click);
            // 
            // richduyuru
            // 
            this.richduyuru.Location = new System.Drawing.Point(6, 19);
            this.richduyuru.Name = "richduyuru";
            this.richduyuru.Size = new System.Drawing.Size(150, 84);
            this.richduyuru.TabIndex = 0;
            this.richduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonrandevukaydet);
            this.groupBox3.Controls.Add(this.checkBoxdurum);
            this.groupBox3.Controls.Add(this.maskedtc);
            this.groupBox3.Controls.Add(this.comboBoxdoktor);
            this.groupBox3.Controls.Add(this.comboBoxbrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxsaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxtarih);
            this.groupBox3.Controls.Add(this.textBoxidsekreter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(170, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // buttonrandevukaydet
            // 
            this.buttonrandevukaydet.Location = new System.Drawing.Point(2, 199);
            this.buttonrandevukaydet.Name = "buttonrandevukaydet";
            this.buttonrandevukaydet.Size = new System.Drawing.Size(198, 23);
            this.buttonrandevukaydet.TabIndex = 14;
            this.buttonrandevukaydet.Text = "Kaydet";
            this.buttonrandevukaydet.UseVisualStyleBackColor = true;
            this.buttonrandevukaydet.Click += new System.EventHandler(this.buttonrandevukaydet_Click);
            // 
            // checkBoxdurum
            // 
            this.checkBoxdurum.AutoSize = true;
            this.checkBoxdurum.Location = new System.Drawing.Point(59, 176);
            this.checkBoxdurum.Name = "checkBoxdurum";
            this.checkBoxdurum.Size = new System.Drawing.Size(57, 17);
            this.checkBoxdurum.TabIndex = 13;
            this.checkBoxdurum.Text = "Durum";
            this.checkBoxdurum.UseVisualStyleBackColor = true;
            // 
            // maskedtc
            // 
            this.maskedtc.Location = new System.Drawing.Point(59, 150);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(100, 20);
            this.maskedtc.TabIndex = 12;
            this.maskedtc.ValidatingType = typeof(int);
            // 
            // comboBoxdoktor
            // 
            this.comboBoxdoktor.FormattingEnabled = true;
            this.comboBoxdoktor.Location = new System.Drawing.Point(59, 123);
            this.comboBoxdoktor.Name = "comboBoxdoktor";
            this.comboBoxdoktor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxdoktor.TabIndex = 11;
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(59, 96);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(100, 21);
            this.comboBoxbrans.TabIndex = 10;
            this.comboBoxbrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxbrans_SelectedIndexChanged);
            // 
            // maskedTextBoxsaat
            // 
            this.maskedTextBoxsaat.Location = new System.Drawing.Point(59, 69);
            this.maskedTextBoxsaat.Mask = "00:00";
            this.maskedTextBoxsaat.Name = "maskedTextBoxsaat";
            this.maskedTextBoxsaat.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxsaat.TabIndex = 9;
            this.maskedTextBoxsaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxtarih
            // 
            this.maskedTextBoxtarih.Location = new System.Drawing.Point(59, 43);
            this.maskedTextBoxtarih.Mask = "00/00/0000";
            this.maskedTextBoxtarih.Name = "maskedTextBoxtarih";
            this.maskedTextBoxtarih.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxtarih.TabIndex = 8;
            this.maskedTextBoxtarih.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxidsekreter
            // 
            this.textBoxidsekreter.Location = new System.Drawing.Point(59, 19);
            this.textBoxidsekreter.Name = "textBoxidsekreter";
            this.textBoxidsekreter.Size = new System.Drawing.Size(100, 20);
            this.textBoxidsekreter.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "T.C. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(376, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // asdasdcasdca
            // 
            this.asdasdcasdca.Controls.Add(this.dataGridView2);
            this.asdasdcasdca.Location = new System.Drawing.Point(376, 154);
            this.asdasdcasdca.Name = "asdasdcasdca";
            this.asdasdcasdca.Size = new System.Drawing.Size(412, 172);
            this.asdasdcasdca.TabIndex = 4;
            this.asdasdcasdca.TabStop = false;
            this.asdasdcasdca.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(406, 153);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonrandevulistesi);
            this.groupBox5.Controls.Add(this.buttonbranspaneli);
            this.groupBox5.Controls.Add(this.buttondoktorpaneli);
            this.groupBox5.Location = new System.Drawing.Point(2, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 87);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // buttonrandevulistesi
            // 
            this.buttonrandevulistesi.Location = new System.Drawing.Point(244, 19);
            this.buttonrandevulistesi.Name = "buttonrandevulistesi";
            this.buttonrandevulistesi.Size = new System.Drawing.Size(113, 23);
            this.buttonrandevulistesi.TabIndex = 17;
            this.buttonrandevulistesi.Text = "Randevu Listesi";
            this.buttonrandevulistesi.UseVisualStyleBackColor = true;
            this.buttonrandevulistesi.Click += new System.EventHandler(this.buttonrandevulistesi_Click);
            // 
            // buttonbranspaneli
            // 
            this.buttonbranspaneli.Location = new System.Drawing.Point(125, 19);
            this.buttonbranspaneli.Name = "buttonbranspaneli";
            this.buttonbranspaneli.Size = new System.Drawing.Size(113, 23);
            this.buttonbranspaneli.TabIndex = 16;
            this.buttonbranspaneli.Text = "Branş Paneli";
            this.buttonbranspaneli.UseVisualStyleBackColor = true;
            this.buttonbranspaneli.Click += new System.EventHandler(this.buttonbranspaneli_Click);
            // 
            // buttondoktorpaneli
            // 
            this.buttondoktorpaneli.Location = new System.Drawing.Point(6, 19);
            this.buttondoktorpaneli.Name = "buttondoktorpaneli";
            this.buttondoktorpaneli.Size = new System.Drawing.Size(113, 23);
            this.buttondoktorpaneli.TabIndex = 15;
            this.buttondoktorpaneli.Text = "Doktor Paneli";
            this.buttondoktorpaneli.UseVisualStyleBackColor = true;
            this.buttondoktorpaneli.Click += new System.EventHandler(this.buttondoktorpaneli_Click);
            // 
            // FormSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.asdasdcasdca);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSekreterDetay";
            this.Text = "Sekreter Detay Paneli";
            this.Load += new System.EventHandler(this.FormSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.asdasdcasdca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsekreteradsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsekretertc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonduyuruolustur;
        private System.Windows.Forms.RichTextBox richduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonrandevukaydet;
        private System.Windows.Forms.CheckBox checkBoxdurum;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.ComboBox comboBoxdoktor;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxsaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtarih;
        private System.Windows.Forms.TextBox textBoxidsekreter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox asdasdcasdca;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonrandevulistesi;
        private System.Windows.Forms.Button buttonbranspaneli;
        private System.Windows.Forms.Button buttondoktorpaneli;
    }
}