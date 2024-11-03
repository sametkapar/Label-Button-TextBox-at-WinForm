namespace WinFormsControls
{
    partial class ButtonControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_tikla = new System.Windows.Forms.Button();
            this.btn_click = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Standart Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(142, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Şişman buton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(320, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Renkli Buton";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WinFormsControls.Properties.Resources.süpürge;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(470, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 168);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_tikla
            // 
            this.btn_tikla.Location = new System.Drawing.Point(13, 239);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(120, 59);
            this.btn_tikla.TabIndex = 4;
            this.btn_tikla.Text = "TIKLA";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(338, 239);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(149, 68);
            this.btn_click.TabIndex = 5;
            this.btn_click.Text = "BANANA BAS YA";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_counter.Location = new System.Drawing.Point(408, 339);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(18, 20);
            this.lbl_counter.TabIndex = 6;
            this.lbl_counter.Text = "0";
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.btn_tikla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ButtonControl";
            this.Text = "ButtonControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label lbl_counter;
    }
}