
namespace Hastane_Randevu_Sistemi
{
    partial class FormGirisPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisPenceresi));
            this.butonhasta = new System.Windows.Forms.Button();
            this.butondoktor = new System.Windows.Forms.Button();
            this.butonsekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonhasta
            // 
            this.butonhasta.BackColor = System.Drawing.Color.Transparent;
            this.butonhasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonhasta.BackgroundImage")));
            this.butonhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonhasta.Location = new System.Drawing.Point(12, 86);
            this.butonhasta.Name = "butonhasta";
            this.butonhasta.Size = new System.Drawing.Size(125, 125);
            this.butonhasta.TabIndex = 0;
            this.butonhasta.UseVisualStyleBackColor = false;
            this.butonhasta.Click += new System.EventHandler(this.butonhasta_Click);
            // 
            // butondoktor
            // 
            this.butondoktor.BackColor = System.Drawing.Color.Transparent;
            this.butondoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butondoktor.BackgroundImage")));
            this.butondoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butondoktor.Location = new System.Drawing.Point(143, 86);
            this.butondoktor.Name = "butondoktor";
            this.butondoktor.Size = new System.Drawing.Size(125, 125);
            this.butondoktor.TabIndex = 1;
            this.butondoktor.UseVisualStyleBackColor = false;
            this.butondoktor.Click += new System.EventHandler(this.butondoktor_Click);
            // 
            // butonsekreter
            // 
            this.butonsekreter.BackColor = System.Drawing.Color.Transparent;
            this.butonsekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonsekreter.BackgroundImage")));
            this.butonsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butonsekreter.Location = new System.Drawing.Point(274, 86);
            this.butonsekreter.Name = "butonsekreter";
            this.butonsekreter.Size = new System.Drawing.Size(125, 125);
            this.butonsekreter.TabIndex = 2;
            this.butonsekreter.UseVisualStyleBackColor = false;
            this.butonsekreter.Click += new System.EventHandler(this.butonsekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(170, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(295, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hastane Randevu Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormGirisPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(415, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonsekreter);
            this.Controls.Add(this.butondoktor);
            this.Controls.Add(this.butonhasta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGirisPenceresi";
            this.Text = "Randevu Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonhasta;
        private System.Windows.Forms.Button butondoktor;
        private System.Windows.Forms.Button butonsekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

