
namespace Hastane_Randevu_Sistemi
{
    partial class FormDoktorEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDoktorad = new System.Windows.Forms.TextBox();
            this.textdoktorsoyad = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtcdoktor = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttondoktorekle = new System.Windows.Forms.Button();
            this.buttondoktorsil = new System.Windows.Forms.Button();
            this.buttondoktorguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // textDoktorad
            // 
            this.textDoktorad.Location = new System.Drawing.Point(55, 6);
            this.textDoktorad.Name = "textDoktorad";
            this.textDoktorad.Size = new System.Drawing.Size(100, 20);
            this.textDoktorad.TabIndex = 5;
            // 
            // textdoktorsoyad
            // 
            this.textdoktorsoyad.Location = new System.Drawing.Point(55, 32);
            this.textdoktorsoyad.Name = "textdoktorsoyad";
            this.textdoktorsoyad.Size = new System.Drawing.Size(100, 20);
            this.textdoktorsoyad.TabIndex = 6;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(55, 110);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxsifre.TabIndex = 7;
            // 
            // maskedTextBoxtcdoktor
            // 
            this.maskedTextBoxtcdoktor.Location = new System.Drawing.Point(55, 84);
            this.maskedTextBoxtcdoktor.Mask = "00000000000";
            this.maskedTextBoxtcdoktor.Name = "maskedTextBoxtcdoktor";
            this.maskedTextBoxtcdoktor.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxtcdoktor.TabIndex = 8;
            this.maskedTextBoxtcdoktor.ValidatingType = typeof(int);
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(55, 57);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(100, 21);
            this.comboBoxbrans.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 182);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttondoktorekle
            // 
            this.buttondoktorekle.Location = new System.Drawing.Point(55, 136);
            this.buttondoktorekle.Name = "buttondoktorekle";
            this.buttondoktorekle.Size = new System.Drawing.Size(48, 23);
            this.buttondoktorekle.TabIndex = 11;
            this.buttondoktorekle.Text = "Ekle";
            this.buttondoktorekle.UseVisualStyleBackColor = true;
            // 
            // buttondoktorsil
            // 
            this.buttondoktorsil.Location = new System.Drawing.Point(107, 136);
            this.buttondoktorsil.Name = "buttondoktorsil";
            this.buttondoktorsil.Size = new System.Drawing.Size(48, 23);
            this.buttondoktorsil.TabIndex = 12;
            this.buttondoktorsil.Text = "Sil";
            this.buttondoktorsil.UseVisualStyleBackColor = true;
            this.buttondoktorsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondoktorguncelle
            // 
            this.buttondoktorguncelle.Location = new System.Drawing.Point(55, 165);
            this.buttondoktorguncelle.Name = "buttondoktorguncelle";
            this.buttondoktorguncelle.Size = new System.Drawing.Size(100, 23);
            this.buttondoktorguncelle.TabIndex = 13;
            this.buttondoktorguncelle.Text = "Güncelle";
            this.buttondoktorguncelle.UseVisualStyleBackColor = true;
            // 
            // FormDoktorEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 198);
            this.Controls.Add(this.buttondoktorguncelle);
            this.Controls.Add(this.buttondoktorsil);
            this.Controls.Add(this.buttondoktorekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxbrans);
            this.Controls.Add(this.maskedTextBoxtcdoktor);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textdoktorsoyad);
            this.Controls.Add(this.textDoktorad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoktorEkleme";
            this.Text = "Doktor Düzenleme Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDoktorad;
        private System.Windows.Forms.TextBox textdoktorsoyad;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtcdoktor;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttondoktorekle;
        private System.Windows.Forms.Button buttondoktorsil;
        private System.Windows.Forms.Button buttondoktorguncelle;
    }
}