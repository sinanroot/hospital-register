﻿namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.Windows.Forms.Button btnhastagiris;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btndoktorgiris = new System.Windows.Forms.Button();
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            btnhastagiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhastagiris
            // 
            btnhastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagiris.BackgroundImage")));
            btnhastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnhastagiris.Location = new System.Drawing.Point(37, 217);
            btnhastagiris.Name = "btnhastagiris";
            btnhastagiris.Size = new System.Drawing.Size(184, 169);
            btnhastagiris.TabIndex = 0;
            btnhastagiris.UseVisualStyleBackColor = true;
            btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click);
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgiris.BackgroundImage")));
            this.btndoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgiris.Location = new System.Drawing.Point(285, 217);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(184, 169);
            this.btndoktorgiris.TabIndex = 1;
            this.btndoktorgiris.UseVisualStyleBackColor = true;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergirisi.BackgroundImage")));
            this.btnsekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirisi.Location = new System.Drawing.Point(528, 217);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(184, 169);
            this.btnsekretergirisi.TabIndex = 2;
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "XYZ Hastanesi";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekretergirisi);
            this.Controls.Add(this.btndoktorgiris);
            this.Controls.Add(btnhastagiris);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "XYZ Hastanesi Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndoktorgiris;
        private System.Windows.Forms.Button btnsekretergirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

