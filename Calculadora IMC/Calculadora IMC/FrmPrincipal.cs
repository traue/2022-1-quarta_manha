using System;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Imc imc = new Imc();
            imc.Altura = float.Parse(txtAltura.Text);
            imc.Peso = float.Parse(txtPeso.Text);
            float resultadoIMC = imc.calculaImc();

            lbResultadoIMC.Text = "IMC: " + resultadoIMC.ToString("0.00");
            lbResultadoIMC.Visible = true;

            lbClassificacao.Text = "Classificação: " + imc.classificaIMC(resultadoIMC);
            lbClassificacao.Visible = true;
        }
    }
}
