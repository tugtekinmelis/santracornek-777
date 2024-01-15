using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek12
{
    public partial class Form1 : Form
    {
        int sayacbeyaz = 10;
        int sayacsiyah = 10;

        public Form1()
        {
            InitializeComponent();
        }
      
       

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timBeyaz.Start();
            this.lblBeyaz.ForeColor = Color.White;
            this.BackColor = Color.Black;

        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timBeyaz.Stop();

            timSiyah.Start();
            this.BackColor = Color.Black;
            this.lblBeyaz.ForeColor = Color.White;
            this.lblSiyah.ForeColor = Color.White;


        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            timSiyah.Stop();

            timBeyaz.Start();
            this.BackColor = Color.White;
            this.lblBeyaz.ForeColor = Color.Black;
            this.lblSiyah.ForeColor = Color.Black;
        }

        private void timBeyaz_Tick(object sender, EventArgs e)
        {
            sayacbeyaz--;
            lblBeyaz.Text = sayacbeyaz.ToString();


            if (sayacbeyaz <= 0)
            {
                timBeyaz.Stop();
                this.BackColor = Color.White;
          lblMesaj.Text = "SİYAH KAZANDI";
            }
        }

        private void timSiyah_Tick(object sender, EventArgs e)
        {
            sayacsiyah--;
            lblSiyah.Text = sayacsiyah.ToString();

            if (sayacsiyah <= 0)
            {
                timSiyah.Stop();
                this.BackColor = Color.Black;
                lblMesaj.Text = "BEYAZ KAZANDI";
            }
        }
    }
}
