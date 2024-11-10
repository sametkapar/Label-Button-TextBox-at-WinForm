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
using WinFormsControls.Model;

namespace WinFormsControls
{
    public partial class ComboBox : Form
    {
        List<Marka> markalar = new List<Marka>();
        public ComboBox()
        {
            InitializeComponent();
            //markalar.Add(new Marka() { ID = -1, Isim = "Marka Seçiniz" });
            markalar.Add(new Marka() { ID = 1, Isim = "Bosch" });
            markalar.Add(new Marka() { ID = 2, Isim = "Milwaukee" });
            markalar.Add(new Marka() { ID = 3, Isim = "Hilti" });
            markalar.Add(new Marka() { ID = 4, Isim = "Black Decker" });
            cb_markalar.ValueMember = "ID";
            cb_markalar.DisplayMember = "Isim";
            cb_markalar.DataSource = markalar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string secilen = cb_departman.SelectedItem.ToString();
            string secilen = cb_departman.Text;
            if(secilen != "Seçiniz")
            {
                lbl_departman.Text = secilen;
            }
            else
            {
                lbl_departman.Text = "Lütfen Seçin YapınızѾѾѾѾѾѾ";
            }
            
        }
        
        private void cb_egitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_egitim.SelectedItem.ToString();
            lbl_egitim.Text = secilen;
        }

        private void btn_markasec_Click(object sender, EventArgs e)
        {
            //string secilen = "ID = " + cb_markalar.SelectedValue.ToString();
            //secilen += "Isim =" + cb_markalar.SelectedItem.ToString();
            Marka m = (Marka)cb_markalar.SelectedItem;

            lbl_maraSec.Text = "ID = " + m.ID +" Isim = " + m.Isim; 
        }
    }
}
