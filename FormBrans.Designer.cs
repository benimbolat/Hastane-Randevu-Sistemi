
namespace Hastane_Randevu_Sistemi
{
    partial class FormBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrans));
            this.buttonbransguncelle = new System.Windows.Forms.Button();
            this.buttonbranssil = new System.Windows.Forms.Button();
            this.buttonbransekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbransad = new System.Windows.Forms.TextBox();
            this.textbransid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbransguncelle
            // 
            this.buttonbransguncelle.Location = new System.Drawing.Point(12, 139);
            this.buttonbransguncelle.Name = "buttonbransguncelle";
            this.buttonbransguncelle.Size = new System.Drawing.Size(141, 23);
            this.buttonbransguncelle.TabIndex = 27;
            this.buttonbransguncelle.Text = "Güncelle";
            this.buttonbransguncelle.UseVisualStyleBackColor = true;
            this.buttonbransguncelle.Click += new System.EventHandler(this.buttonbransguncelle_Click);
            // 
            // buttonbranssil
            // 
            this.buttonbranssil.Location = new System.Drawing.Point(88, 110);
            this.buttonbranssil.Name = "buttonbranssil";
            this.buttonbranssil.Size = new System.Drawing.Size(65, 23);
            this.buttonbranssil.TabIndex = 26;
            this.buttonbranssil.Text = "Sil";
            this.buttonbranssil.UseVisualStyleBackColor = true;
            this.buttonbranssil.Click += new System.EventHandler(this.buttonbranssil_Click);
            // 
            // buttonbransekle
            // 
            this.buttonbransekle.Location = new System.Drawing.Point(12, 110);
            this.buttonbransekle.Name = "buttonbransekle";
            this.buttonbransekle.Size = new System.Drawing.Size(70, 23);
            this.buttonbransekle.TabIndex = 25;
            this.buttonbransekle.Text = "Ekle";
            this.buttonbransekle.UseVisualStyleBackColor = true;
            this.buttonbransekle.Click += new System.EventHandler(this.buttonbransekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textbransad
            // 
            this.textbransad.Location = new System.Drawing.Point(12, 80);
            this.textbransad.Name = "textbransad";
            this.textbransad.Size = new System.Drawing.Size(141, 20);
            this.textbransad.TabIndex = 20;
            // 
            // textbransid
            // 
            this.textbransid.Location = new System.Drawing.Point(12, 30);
            this.textbransid.Name = "textbransid";
            this.textbransid.Size = new System.Drawing.Size(141, 20);
            this.textbransid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branş Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Branş ID :";
            // 
            // FormBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 169);
            this.Controls.Add(this.buttonbransguncelle);
            this.Controls.Add(this.buttonbranssil);
            this.Controls.Add(this.buttonbransekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbransad);
            this.Controls.Add(this.textbransid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrans";
            this.Text = "Branş Düzenleme";
            this.Load += new System.EventHandler(this.FormBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbransguncelle;
        private System.Windows.Forms.Button buttonbranssil;
        private System.Windows.Forms.Button buttonbransekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbransad;
        private System.Windows.Forms.TextBox textbransid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}