using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belge_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumG_Click(object sender, EventArgs e)
        {
            double notOrtalamasi, devamsizlikSayisi;
            int zayifSayisi;
            notOrtalamasi=Convert.ToDouble(txtOrtalama.Text);
            devamsizlikSayisi=Convert.ToDouble(txtDevamsizlik.Text);
            zayifSayisi = Convert.ToInt32(txtZayif.Text);

            if (notOrtalamasi >= 70 && notOrtalamasi < 85 && devamsizlikSayisi < 5 && zayifSayisi == 0)
            {
                lblDurum.Text = "Teşekkür Belgesi Aldınız :)";
            }
            else if (notOrtalamasi >= 85 && notOrtalamasi >= 100 && devamsizlikSayisi < 5 && zayifSayisi == 0)
            {
                lblDurum.Text = "Taktir Belgesi Aldınız";
            }
            else if (zayifSayisi>= 1)
            {
                lblDurum.Text = "Zayıf var.";
            }
            else if (devamsizlikSayisi >= 10)
            {
                lblDurum.Text = "Devamsızlık Fazla";
            }
            else
            {
                lblDurum.Text = "BELGE YOK.";
            }

        }
    }
}
