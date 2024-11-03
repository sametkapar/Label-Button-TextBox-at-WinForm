using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class MetinAraclari : Form
    {
        public MetinAraclari()
        {
            InitializeComponent();
        }

        private void tb_sinirli_TextChanged(object sender, EventArgs e)
        {
            int count = tb_sinirli.Text.Length;
            lbl_count.Text = Convert.ToString(20 - count);
            Random rnd = new Random();
            int sayi = rnd.Next(42, 45);
            tb_sinirli.PasswordChar = (char)sayi;

            label1.Text = tb_sinirli.Text + "sodfhsdakfjsda";

            
            Insan i = new Insan();
            i.isim = label12.Text;
        }
    }
}
