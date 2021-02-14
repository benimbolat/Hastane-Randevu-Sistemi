
namespace Hastane_Randevu_Sistemi
{
    partial class FormSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterGiris));
            this.label5 = new System.Windows.Forms.Label();
            this.linkuyeolsekreter = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.butongirissekreter = new System.Windows.Forms.Button();
            this.sekretertcid = new System.Windows.Forms.MaskedTextBox();
            this.sekretersifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "tıklayarak yeni hesap açabilirsiniz.";
            // 
            // linkuyeolsekreter
            // 
            this.linkuyeolsekreter.AutoSize = true;
            this.linkuyeolsekreter.Location = new System.Drawing.Point(117, 159);
            this.linkuyeolsekreter.Name = "linkuyeolsekreter";
            this.linkuyeolsekreter.Size = new System.Drawing.Size(39, 13);
            this.linkuyeolsekreter.TabIndex = 18;
            this.linkuyeolsekreter.TabStop = true;
            this.linkuyeolsekreter.Text = "buraya";
//            this.linkuyeolsekreter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuyeolsekreter_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kayıtlı hesabınız yoksa ";
            // 
            // butongirissekreter
            // 
            this.butongirissekreter.Location = new System.Drawing.Point(85, 114);
            this.butongirissekreter.Name = "butongirissekreter";
            this.butongirissekreter.Size = new System.Drawing.Size(161, 24);
            this.butongirissekreter.TabIndex = 16;
            this.butongirissekreter.Text = "Giriş yap";
            this.butongirissekreter.UseVisualStyleBackColor = true;
            this.butongirissekreter.Click += new System.EventHandler(this.butongirissekreter_Click);
            // 
            // sekretertcid
            // 
            this.sekretertcid.Location = new System.Drawing.Point(94, 58);
            this.sekretertcid.Mask = "00000000000";
            this.sekretertcid.Name = "sekretertcid";
            this.sekretertcid.Size = new System.Drawing.Size(146, 20);
            this.sekretertcid.TabIndex = 15;
            this.sekretertcid.ValidatingType = typeof(int);
            // 
            // sekretersifre
            // 
            this.sekretersifre.Location = new System.Drawing.Point(94, 88);
            this.sekretersifre.Name = "sekretersifre";
            this.sekretersifre.Size = new System.Drawing.Size(146, 20);
            this.sekretersifre.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sekreter Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // FormSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 185);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkuyeolsekreter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butongirissekreter);
            this.Controls.Add(this.sekretertcid);
            this.Controls.Add(this.sekretersifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSekreterGiris";
            this.Text = "Sekreter Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkuyeolsekreter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butongirissekreter;
        private System.Windows.Forms.MaskedTextBox sekretertcid;
        private System.Windows.Forms.TextBox sekretersifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}