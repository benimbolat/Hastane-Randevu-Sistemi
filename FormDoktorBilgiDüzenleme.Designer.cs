
namespace Hastane_Randevu_Sistemi
{
    partial class FormDoktorBilgiDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorBilgiDüzenleme));
            this.butondoktorbilgiguncelle = new System.Windows.Forms.Button();
            this.textdoktorsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textdoktorad = new System.Windows.Forms.TextBox();
            this.labeldoktorad = new System.Windows.Forms.Label();
            this.msktcdoktor = new System.Windows.Forms.MaskedTextBox();
            this.doktorsifretext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxbrasdoktor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butondoktorbilgiguncelle
            // 
            this.butondoktorbilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butondoktorbilgiguncelle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.butondoktorbilgiguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butondoktorbilgiguncelle.Location = new System.Drawing.Point(35, 166);
            this.butondoktorbilgiguncelle.Name = "butondoktorbilgiguncelle";
            this.butondoktorbilgiguncelle.Size = new System.Drawing.Size(228, 23);
            this.butondoktorbilgiguncelle.TabIndex = 47;
            this.butondoktorbilgiguncelle.Text = "Yeni Bilgileri Kaydet";
            this.butondoktorbilgiguncelle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butondoktorbilgiguncelle.UseVisualStyleBackColor = false;
            // 
            // textdoktorsoyad
            // 
            this.textdoktorsoyad.Location = new System.Drawing.Point(117, 56);
            this.textdoktorsoyad.Name = "textdoktorsoyad";
            this.textdoktorsoyad.Size = new System.Drawing.Size(146, 20);
            this.textdoktorsoyad.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Doktor Soyadı :";
            // 
            // textdoktorad
            // 
            this.textdoktorad.Location = new System.Drawing.Point(117, 30);
            this.textdoktorad.Name = "textdoktorad";
            this.textdoktorad.Size = new System.Drawing.Size(146, 20);
            this.textdoktorad.TabIndex = 40;
            // 
            // labeldoktorad
            // 
            this.labeldoktorad.AutoSize = true;
            this.labeldoktorad.Location = new System.Drawing.Point(46, 33);
            this.labeldoktorad.Name = "labeldoktorad";
            this.labeldoktorad.Size = new System.Drawing.Size(63, 13);
            this.labeldoktorad.TabIndex = 39;
            this.labeldoktorad.Text = "Doktor Adı :";
            // 
            // msktcdoktor
            // 
            this.msktcdoktor.Location = new System.Drawing.Point(117, 82);
            this.msktcdoktor.Mask = "00000000000";
            this.msktcdoktor.Name = "msktcdoktor";
            this.msktcdoktor.Size = new System.Drawing.Size(146, 20);
            this.msktcdoktor.TabIndex = 38;
            this.msktcdoktor.ValidatingType = typeof(int);
            // 
            // doktorsifretext
            // 
            this.doktorsifretext.Location = new System.Drawing.Point(117, 110);
            this.doktorsifretext.Name = "doktorsifretext";
            this.doktorsifretext.Size = new System.Drawing.Size(146, 20);
            this.doktorsifretext.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Doktor Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Doktor Bilgi Düzenleme Paneli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Branş :";
            // 
            // comboBoxbrasdoktor
            // 
            this.comboBoxbrasdoktor.FormattingEnabled = true;
            this.comboBoxbrasdoktor.Location = new System.Drawing.Point(117, 139);
            this.comboBoxbrasdoktor.Name = "comboBoxbrasdoktor";
            this.comboBoxbrasdoktor.Size = new System.Drawing.Size(146, 21);
            this.comboBoxbrasdoktor.TabIndex = 49;
            // 
            // FormDoktorBilgiDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(286, 202);
            this.Controls.Add(this.comboBoxbrasdoktor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butondoktorbilgiguncelle);
            this.Controls.Add(this.textdoktorsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textdoktorad);
            this.Controls.Add(this.labeldoktorad);
            this.Controls.Add(this.msktcdoktor);
            this.Controls.Add(this.doktorsifretext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoktorBilgiDüzenleme";
            this.Text = "Doktor Bilgi Düzenleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butondoktorbilgiguncelle;
        private System.Windows.Forms.TextBox textdoktorsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textdoktorad;
        private System.Windows.Forms.Label labeldoktorad;
        private System.Windows.Forms.MaskedTextBox msktcdoktor;
        private System.Windows.Forms.TextBox doktorsifretext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxbrasdoktor;
    }
}