using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sözlük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sefa s = new sefa();

        private void btCevir_Click(object sender, EventArgs e)
        {
            string kelime, sonuc;
            kelime = tbKelime.Text;
            if(cbEn.Checked==true)
            {
                sonuc = s.tr_cevir(kelime);
            }
            else
            {
                sonuc = s.ing_cevir(kelime);
            }

            lbSonuc.Text = sonuc;
        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            s.kelime_ekle(tbTr.Text, tbEn.Text);
        }
    }
}
