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
    public partial class CheckedListBoxControls : Form
    {
        public CheckedListBoxControls()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string diller = "";

            foreach (var item in clb_diiler.CheckedItems)
            {
                diller = diller +"\n"+ item.ToString();
                
            }
            lbl_ekran.Text = diller;
        }
    }
}
