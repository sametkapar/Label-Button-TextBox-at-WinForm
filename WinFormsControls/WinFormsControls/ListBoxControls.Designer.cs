namespace WinFormsControls
{
    partial class ListBoxControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sehirListe = new System.Windows.Forms.ListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.tb_eklenecek = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_sehirListe2 = new System.Windows.Forms.ListBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birden çok seçenek arasından bir veye\r\nbirden çok seçeneği seçmemizi sağlayan yap" +
    "ıdır.";
            // 
            // lb_sehirListe
            // 
            this.lb_sehirListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sehirListe.FormattingEnabled = true;
            this.lb_sehirListe.ItemHeight = 20;
            this.lb_sehirListe.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Eskişehir"});
            this.lb_sehirListe.Location = new System.Drawing.Point(30, 186);
            this.lb_sehirListe.Name = "lb_sehirListe";
            this.lb_sehirListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_sehirListe.Size = new System.Drawing.Size(221, 144);
            this.lb_sehirListe.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getir.Location = new System.Drawing.Point(30, 341);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(221, 27);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ekran.Location = new System.Drawing.Point(26, 380);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(27, 20);
            this.lbl_ekran.TabIndex = 3;
            this.lbl_ekran.Text = "aa";
            // 
            // tb_eklenecek
            // 
            this.tb_eklenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_eklenecek.Location = new System.Drawing.Point(30, 125);
            this.tb_eklenecek.Name = "tb_eklenecek";
            this.tb_eklenecek.Size = new System.Drawing.Size(221, 27);
            this.tb_eklenecek.TabIndex = 4;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(257, 125);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 27);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir Yazınız:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "PARTİ BUTONU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_sehirListe2
            // 
            this.lb_sehirListe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sehirListe2.FormattingEnabled = true;
            this.lb_sehirListe2.ItemHeight = 20;
            this.lb_sehirListe2.Location = new System.Drawing.Point(357, 186);
            this.lb_sehirListe2.Name = "lb_sehirListe2";
            this.lb_sehirListe2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_sehirListe2.Size = new System.Drawing.Size(221, 144);
            this.lb_sehirListe2.TabIndex = 1;
            // 
            // btn_aktar
            // 
            this.btn_aktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktar.Location = new System.Drawing.Point(266, 236);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(75, 49);
            this.btn_aktar.TabIndex = 7;
            this.btn_aktar.Text = ">";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // ListBoxControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_eklenecek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.lb_sehirListe2);
            this.Controls.Add(this.lb_sehirListe);
            this.Controls.Add(this.label1);
            this.Name = "ListBoxControls";
            this.Text = "ListBoxControls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_sehirListe;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.TextBox tb_eklenecek;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_sehirListe2;
        private System.Windows.Forms.Button btn_aktar;
    }
}