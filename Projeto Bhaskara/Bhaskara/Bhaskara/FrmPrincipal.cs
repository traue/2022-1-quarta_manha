using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            lbDelta.Visible = false;
            lbXP.Visible = false;
            lbXN.Visible = false;

            //1. obtencão dos valores "a", "b" e "c":
            int a, b, c;
            try
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                c = int.Parse(txtC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro nos valores de entrada!");
                return;
            }

            //2. se o a for zero, não pode continuar...
            if (a == 0)
            {
                MessageBox.Show("O valor do a não pode ser zero!");
                return;
            }

            //3. iniciar o processo de cálculo
            double delta = (b * b) - 4 * a * c;

            //4. Se o delta for negativo, informar...
            if (delta < 0)
            {
                //alternativa:
                //MessageBox.Show("O delta é negativo: " + delta);
                lbDelta.Text = "O delta é negativo: " + delta;
                lbXP.Text = "Não é possível calcular as raízes";

                lbDelta.Visible = true;
                lbXP.Visible = true;

                return;
            }

            //5. Cálculo das raízes...
            double xP, xN;
            xP = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            xN = ((-b) - Math.Sqrt(delta)) / (2 * a);

            //6. exibição dos resultados...
            if (xP == xN)
            {
                lbXP.Text = "X' = X\" = " + xP;
                lbXP.Visible = true;

                return;
            }

            lbDelta.Text = "Delta = " + delta;
            lbXP.Text = "X' = " + xP;
            lbXN.Text = "X\" = " + xN;

            lbDelta.Visible = true;
            lbXP.Visible = true;
            lbXN.Visible = true;

        }
    }
}
