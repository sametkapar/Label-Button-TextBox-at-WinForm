using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class ButtonControl : Form
    {
        public ButtonControl()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            this.Text = "Tıkladım Ne oldu?";
            btn_tikla.Text = button1.Text = button2.Text = "SUS BE"; 
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(lbl_counter.Text);
            sayi += 1;
            lbl_counter.Text = Convert.ToString(sayi);
        }
    }
}
