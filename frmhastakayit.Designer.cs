
namespace Hastane_Randevu_Sistemi
{
    partial class frmhastakayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastakayit));
            this.label1 = new System.Windows.Forms.Label();
            this.msktchasta = new System.Windows.Forms.MaskedTextBox();
            this.hastasifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texthastaad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texthastasoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxcinsiyet = new System.Windows.Forms.ComboBox();
            this.butonhastakaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Kayıt Paneli";
            // 
            // msktchasta
            // 
            this.msktchasta.Location = new System.Drawing.Point(94, 82);
            this.msktchasta.Mask = "00000000000";
            this.msktchasta.Name = "msktchasta";
            this.msktchasta.Size = new System.Drawing.Size(146, 20);
            this.msktchasta.TabIndex = 3;
            this.msktchasta.ValidatingType = typeof(int);
            // 
            // hastasifre
            // 
            this.hastasifre.Location = new System.Drawing.Point(94, 134);
            this.hastasifre.Name = "hastasifre";
            this.hastasifre.Size = new System.Drawing.Size(146, 20);
            this.hastasifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // texthastaad
            // 
            this.texthastaad.Location = new System.Drawing.Point(94, 30);
            this.texthastaad.Name = "texthastaad";
            this.texthastaad.Size = new System.Drawing.Size(146, 20);
            this.texthastaad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta Adı :";
            // 
            // texthastasoyad
            // 
            this.texthastasoyad.Location = new System.Drawing.Point(94, 56);
            this.texthastasoyad.Name = "texthastasoyad";
            this.texthastasoyad.Size = new System.Drawing.Size(146, 20);
            this.texthastasoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hasta Soyadı :";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(94, 108);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(146, 20);
            this.msktelefon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cinsiyet :";
            // 
            // comboBoxcinsiyet
            // 
            this.comboBoxcinsiyet.FormattingEnabled = true;
            this.comboBoxcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxcinsiyet.Location = new System.Drawing.Point(94, 163);
            this.comboBoxcinsiyet.Name = "comboBoxcinsiyet";
            this.comboBoxcinsiyet.Size = new System.Drawing.Size(146, 21);
            this.comboBoxcinsiyet.TabIndex = 6;
            // 
            // butonhastakaydet
            // 
            this.butonhastakaydet.Location = new System.Drawing.Point(12, 190);
            this.butonhastakaydet.Name = "butonhastakaydet";
            this.butonhastakaydet.Size = new System.Drawing.Size(228, 23);
            this.butonhastakaydet.TabIndex = 7;
            this.butonhastakaydet.Text = "Kaydet";
            this.butonhastakaydet.UseVisualStyleBackColor = true;
            this.butonhastakaydet.Click += new System.EventHandler(this.butonhastakaydet_Click);
            // 
            // frmhastakayit
            // 
            this.AcceptButton = this.butonhastakaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(252, 228);
            this.Controls.Add(this.butonhastakaydet);
            this.Controls.Add(this.comboBoxcinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.texthastasoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texthastaad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msktchasta);
            this.Controls.Add(this.hastasifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhastakayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktchasta;
        private System.Windows.Forms.TextBox hastasifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texthastaad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texthastasoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxcinsiyet;
        private System.Windows.Forms.Button butonhastakaydet;
    }
}