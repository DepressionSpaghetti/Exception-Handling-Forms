using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBroj_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {

            try
            {
                int broj_a, broj_b, zbroj;
                broj_a = Convert.ToInt32(txtBroj_a.Text);
                broj_b = Convert.ToInt32(txtBroj_b.Text);
                zbroj = broj_a + broj_b;
                txtSuma.Text = Convert.ToString(zbroj);

            }
            catch (FormatException greskaUpis)
            {
                txtSuma.Text = "";
                MessageBox.Show("Upisali ste samo jedan broj, upisite jos jedan");

            }
            catch (Exception greskaSlovo)
            {
                txtSuma.Text = "";
                MessageBox.Show("Krivi upis, upisite broj.");

            }

        }
    }
}
