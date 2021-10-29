using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza
{
    public partial class Forza : Form
    {
        public Forza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dampingf = 0;
            double dampingb = 0;
            double max = Decimal.ToDouble(numericUpDown1_max.Value);
            double min = Decimal.ToDouble(numericUpDown2_min.Value);
            double front = Decimal.ToDouble(numericUpDown3_front.Value) / 100;
            double back = 1 - front;
            numericUpDown4_back.Value = Convert.ToDecimal(back) * 100;
            dampingf = (max - min) * front + min;
            dampingb = (max - min) * back + min;
            label5.Text = "Front: " + dampingf;
            label6.Text = "Back: " + dampingb;
        }
    }
}
