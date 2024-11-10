namespace WinFormsControls
{
    partial class ComboBox
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
            this.lbl_departman = new System.Windows.Forms.Label();
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_egitim = new System.Windows.Forms.ComboBox();
            this.lbl_egitim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.lbl_maraSec = new System.Windows.Forms.Label();
            this.btn_markasec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_departman
            // 
            this.lbl_departman.AutoSize = true;
            this.lbl_departman.Location = new System.Drawing.Point(287, 40);
            this.lbl_departman.Name = "lbl_departman";
            this.lbl_departman.Size = new System.Drawing.Size(120, 16);
            this.lbl_departman.TabIndex = 0;
            this.lbl_departman.Text = "Departman Seçiniz";
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Muhasebe",
            "Levazım",
            "İnsan Kaynakları"});
            this.cb_departman.Location = new System.Drawing.Point(16, 33);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(183, 24);
            this.cb_departman.TabIndex = 1;
            this.cb_departman.Text = "Seçiniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Departman Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Katılınılacak Eğitim";
            // 
            // cb_egitim
            // 
            this.cb_egitim.FormattingEnabled = true;
            this.cb_egitim.Items.AddRange(new object[] {
            "Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "İleri Sürüş Eğitimi",
            "Domates Yetiştiriciği"});
            this.cb_egitim.Location = new System.Drawing.Point(19, 97);
            this.cb_egitim.Name = "cb_egitim";
            this.cb_egitim.Size = new System.Drawing.Size(180, 24);
            this.cb_egitim.TabIndex = 4;
            this.cb_egitim.SelectedIndexChanged += new System.EventHandler(this.cb_egitim_SelectedIndexChanged);
            // 
            // lbl_egitim
            // 
            this.lbl_egitim.AutoSize = true;
            this.lbl_egitim.Location = new System.Drawing.Point(214, 100);
            this.lbl_egitim.Name = "lbl_egitim";
            this.lbl_egitim.Size = new System.Drawing.Size(44, 16);
            this.lbl_egitim.TabIndex = 5;
            this.lbl_egitim.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marka Seçiniz";
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(22, 178);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(183, 24);
            this.cb_markalar.TabIndex = 7;
            // 
            // lbl_maraSec
            // 
            this.lbl_maraSec.AutoSize = true;
            this.lbl_maraSec.Location = new System.Drawing.Point(298, 181);
            this.lbl_maraSec.Name = "lbl_maraSec";
            this.lbl_maraSec.Size = new System.Drawing.Size(112, 16);
            this.lbl_maraSec.TabIndex = 8;
            this.lbl_maraSec.Text = "LEYBILCE5BABA";
            // 
            // btn_markasec
            // 
            this.btn_markasec.Location = new System.Drawing.Point(217, 178);
            this.btn_markasec.Name = "btn_markasec";
            this.btn_markasec.Size = new System.Drawing.Size(75, 23);
            this.btn_markasec.TabIndex = 9;
            this.btn_markasec.Text = "SEÇ";
            this.btn_markasec.UseVisualStyleBackColor = true;
            this.btn_markasec.Click += new System.EventHandler(this.btn_markasec_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_markasec);
            this.Controls.Add(this.lbl_maraSec);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_egitim);
            this.Controls.Add(this.cb_egitim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_departman);
            this.Name = "ComboBox";
            this.Text = "Seçiniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_departman;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_egitim;
        private System.Windows.Forms.Label lbl_egitim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_markalar;
        private System.Windows.Forms.Label lbl_maraSec;
        private System.Windows.Forms.Button btn_markasec;
    }
}