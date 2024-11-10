﻿using System;
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
    public partial class CheckBoxRadioButtonControls : Form
    {
        public CheckBoxRadioButtonControls()
        {
            InitializeComponent();
            rb_erkek.Checked = true;
            rb_evli.Checked = true;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            //lbl_ekran.Text = cb_secim.Checked.ToString();
            if (cb_secim.Checked)
            {
                lbl_ekran.Text = "Gönderme işlemi başarılı";
            }
            else
            {
                MessageBox.Show("Sözleşmeyi kabul etmelisiniz", "Sözleşme Kabulu");
            }
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string diller = "";
            if (cb_ingilizce.Checked) { diller += " İngilizce"; }
            if (cb_almanca.Checked) { diller += " Almanca"; }
            if (cb_japonca.Checked) { diller += " Japonca"; }
            lbl_ekran2.Text = "Diller = " + diller;

            string cinsiyet = "Erkek";
            if (rb_kadin.Checked)
            {
                cinsiyet = "Kadin";
            }
            string medenidurum = "Evli";
            if (rb_bekar.Checked)
            {
                medenidurum = "Bekar";
            }
            lbl_ekran3.Text = "Cinsiye = " + cinsiyet + "    " + "Medeni Hal = " + medenidurum;
        }
    }
}
