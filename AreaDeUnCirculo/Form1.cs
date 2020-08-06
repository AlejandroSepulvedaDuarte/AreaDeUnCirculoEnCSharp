using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaDeUnCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtradio.Text);
            double area = 0;
            area = 3.1416 * Math.Pow(radio,2);
            lblarea.Text = Convert.ToString("El área es: "+ area);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtradio.Text = String.Empty;
            lblarea.Text = String.Empty;
            txtradio.Focus();
        }
    }    
}
