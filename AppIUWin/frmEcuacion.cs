using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIUWin
{
    public partial class frmEcuacion : Form
    {
        public frmEcuacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c,x1,x2;
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            string msg1 = "", msg2 = "";

            x1 = AppProgramacionCapas.Ecuacion.x1(a, b, c, out msg1);
            x2 = AppProgramacionCapas.Ecuacion.x2(a, b, c, out msg2);

            if (msg1.Length == 0)
            {
                this.txtX1.Text = x1.ToString("0.00");
            }
            else
            {
                this.txtX1.Text = msg1;
            }

            if (msg2.Length == 0)
            {
                this.txtX2.Text = x2.ToString("0.00");
            }
            else
            {
                this.txtX2.Text = msg2;
            }

        }

        private void btnGetX1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1;
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            try
            {
                x1 = AppProgramacionCapas.Ecuacion.getx1(a, b, c);
                this.txtX1.Text = x1.ToString("0.00");
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }
    }
}
