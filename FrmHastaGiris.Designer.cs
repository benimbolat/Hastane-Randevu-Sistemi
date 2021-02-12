
namespace Hastane_Randevu_Sistemi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hastasifre = new System.Windows.Forms.TextBox();
            this.hastatcid = new System.Windows.Forms.MaskedTextBox();
            this.butonhastagiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkuyeol = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Şifre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // hastasifre
            // 
            this.hastasifre.Location = new System.Drawing.Point(88, 88);
            this.hastasifre.Name = "hastasifre";
            this.hastasifre.Size = new System.Drawing.Size(146, 20);
            this.hastasifre.TabIndex = 2;
            // 
            // hastatcid
            // 
            this.hastatcid.Location = new System.Drawing.Point(88, 58);
            this.hastatcid.Mask = "00000000000";
            this.hastatcid.Name = "hastatcid";
            this.hastatcid.Size = new System.Drawing.Size(146, 20);
            this.hastatcid.TabIndex = 1;
            this.hastatcid.ValidatingType = typeof(int);
            // 
            // butonhastagiris
            // 
            this.butonhastagiris.Location = new System.Drawing.Point(79, 114);
            this.butonhastagiris.Name = "butonhastagiris";
            this.butonhastagiris.Size = new System.Drawing.Size(161, 24);
            this.butonhastagiris.TabIndex = 3;
            this.butonhastagiris.Text = "Giriş yap";
            this.butonhastagiris.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kayıtlı hesabınız yoksa ";
            // 
            // linkuyeol
            // 
            this.linkuyeol.AutoSize = true;
            this.linkuyeol.Location = new System.Drawing.Point(111, 159);
            this.linkuyeol.Name = "linkuyeol";
            this.linkuyeol.Size = new System.Drawing.Size(39, 13);
            this.linkuyeol.TabIndex = 4;
            this.linkuyeol.TabStop = true;
            this.linkuyeol.Text = "buraya";
            this.linkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuyeol_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "tıklayarak yeni hesap açabilirsiniz.";
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.butonhastagiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 181);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkuyeol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butonhastagiris);
            this.Controls.Add(this.hastatcid);
            this.Controls.Add(this.hastasifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox hastasifre;
        private System.Windows.Forms.MaskedTextBox hastatcid;
        private System.Windows.Forms.Button butonhastagiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkuyeol;
        private System.Windows.Forms.Label label5;
    }
}