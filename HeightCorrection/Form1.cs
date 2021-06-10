using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightCorrection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            double pCalc = 1013.25 * Math.Pow((1.0 - double.Parse(txtSA.Text) / 145366.45), (1.0 / 0.190284));
            double Hpa = double.Parse(txtCB.Text) * 3.38639 * 10;
            double outCalc =(1.0 - Math.Pow((pCalc / Hpa), (0.190284)))   * 145366.45;
            txtOutput.Text = outCalc.ToString("0.0");
        }
    }
}
