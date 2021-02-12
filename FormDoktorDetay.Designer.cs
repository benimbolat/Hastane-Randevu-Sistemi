
namespace Hastane_Randevu_Sistemi
{
    partial class FormDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldoktoradsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldoktortc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxdktrsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vutoncıkıs = new System.Windows.Forms.Button();
            this.butonbos = new System.Windows.Forms.Button();
            this.butonduyurular = new System.Windows.Forms.Button();
            this.butonguncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldoktoradsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbldoktortc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbldoktoradsoyad
            // 
            this.lbldoktoradsoyad.AutoSize = true;
            this.lbldoktoradsoyad.Location = new System.Drawing.Point(82, 51);
            this.lbldoktoradsoyad.Name = "lbldoktoradsoyad";
            this.lbldoktoradsoyad.Size = new System.Drawing.Size(25, 13);
            this.lbldoktoradsoyad.TabIndex = 2;
            this.lbldoktoradsoyad.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad :";
            // 
            // lbldoktortc
            // 
            this.lbldoktortc.AutoSize = true;
            this.lbldoktortc.Location = new System.Drawing.Point(82, 27);
            this.lbldoktortc.Name = "lbldoktortc";
            this.lbldoktortc.Size = new System.Drawing.Size(73, 13);
            this.lbldoktortc.TabIndex = 1;
            this.lbldoktortc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxdktrsikayet);
            this.groupBox2.Location = new System.Drawing.Point(1, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şikayet :";
            // 
            // richTextBoxdktrsikayet
            // 
            this.richTextBoxdktrsikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxdktrsikayet.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxdktrsikayet.Name = "richTextBoxdktrsikayet";
            this.richTextBoxdktrsikayet.Size = new System.Drawing.Size(194, 237);
            this.richTextBoxdktrsikayet.TabIndex = 4;
            this.richTextBoxdktrsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(207, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 413);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vutoncıkıs);
            this.groupBox4.Controls.Add(this.butonbos);
            this.groupBox4.Controls.Add(this.butonduyurular);
            this.groupBox4.Controls.Add(this.butonguncelle);
            this.groupBox4.Location = new System.Drawing.Point(1, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // vutoncıkıs
            // 
            this.vutoncıkıs.Location = new System.Drawing.Point(110, 49);
            this.vutoncıkıs.Name = "vutoncıkıs";
            this.vutoncıkıs.Size = new System.Drawing.Size(84, 23);
            this.vutoncıkıs.TabIndex = 3;
            this.vutoncıkıs.Text = "Çıkış Yap";
            this.vutoncıkıs.UseVisualStyleBackColor = true;
            // 
            // butonbos
            // 
            this.butonbos.Location = new System.Drawing.Point(110, 20);
            this.butonbos.Name = "butonbos";
            this.butonbos.Size = new System.Drawing.Size(84, 23);
            this.butonbos.TabIndex = 2;
            this.butonbos.Text = "Boş";
            this.butonbos.UseVisualStyleBackColor = true;
            // 
            // butonduyurular
            // 
            this.butonduyurular.Location = new System.Drawing.Point(7, 49);
            this.butonduyurular.Name = "butonduyurular";
            this.butonduyurular.Size = new System.Drawing.Size(84, 23);
            this.butonduyurular.TabIndex = 1;
            this.butonduyurular.Text = "Duyuru";
            this.butonduyurular.UseVisualStyleBackColor = true;
            // 
            // butonguncelle
            // 
            this.butonguncelle.Location = new System.Drawing.Point(7, 20);
            this.butonguncelle.Name = "butonguncelle";
            this.butonguncelle.Size = new System.Drawing.Size(84, 23);
            this.butonguncelle.TabIndex = 0;
            this.butonguncelle.Text = "Bilgi Düzenle";
            this.butonguncelle.UseVisualStyleBackColor = true;
            // 
            // FormDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoktorDetay";
            this.Text = "Doktor Detay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldoktoradsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldoktortc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBoxdktrsikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button vutoncıkıs;
        private System.Windows.Forms.Button butonbos;
        private System.Windows.Forms.Button butonduyurular;
        private System.Windows.Forms.Button butonguncelle;
    }
}