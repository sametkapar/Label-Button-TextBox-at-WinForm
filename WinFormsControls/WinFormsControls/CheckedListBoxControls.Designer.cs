﻿namespace WinFormsControls
{
    partial class CheckedListBoxControls
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
            this.clb_diiler = new System.Windows.Forms.CheckedListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb_diiler
            // 
            this.clb_diiler.FormattingEnabled = true;
            this.clb_diiler.Items.AddRange(new object[] {
            "İngilizce",
            "Almanca",
            "Rusça",
            "Çince",
            "Korece",
            "Japonca",
            "Danca"});
            this.clb_diiler.Location = new System.Drawing.Point(6, 35);
            this.clb_diiler.Name = "clb_diiler";
            this.clb_diiler.Size = new System.Drawing.Size(125, 140);
            this.clb_diiler.TabIndex = 0;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(150, 35);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 1;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(147, 72);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran.TabIndex = 2;
            this.lbl_ekran.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb_diiler);
            this.groupBox1.Controls.Add(this.lbl_ekran);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilinen Diller";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // CheckedListBoxControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckedListBoxControls";
            this.Text = "CheckedListBoxControls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_diiler;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}