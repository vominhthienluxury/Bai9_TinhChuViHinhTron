
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9_TinhChuViHinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        { 
            double  so2, cv, dt;
            so2 = double.Parse(sothu1.Text);
           
            if (dientich.Checked)
            {
                dt = (Math.PI * (so2 * so2));
                   ketqua.Text = dt.ToString();
            }
            if (chuvi.Checked)
            {
                cv = 2 * Math.PI * so2;
                ketqua.Text = cv.ToString();
            }
            {
                
            }



        }

    }
}
