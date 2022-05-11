using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solução___Exercicio_Caixa_Eletronico
{
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            try
            {
                lbNotasNecessarias.Text = calculaNotasNecessarias(int.Parse(txtValorSaqui.Text));
            }
            catch
            {
                MessageBox.Show("Ops... algo deu errado...");
            }
        }

        private String calculaNotasNecessarias(int valorSaque)
        {
            string notasNecessarias = "";

            int[] notas = { 100, 50, 20, 10, 5, 2 };
            int resultado = 0;
            int divide = 0;

            if (valorSaque == 1 || valorSaque == 3)
            {
                notasNecessarias = "Valor impossível de ser sacado!";
            }
            else
            {
                foreach(int nota in notas)
                {
                    if(valorSaque >= nota)
                    {
                        resultado = valorSaque % nota;
                        divide = valorSaque / nota;

                        if(resultado != 3 && resultado != 1)
                        {
                            notasNecessarias += divide + " nota(s) de " + nota + Environment.NewLine;
                            valorSaque -= (nota * divide);
                        }

                        if(nota >= 10 && resultado == 3)
                        {
                            valorSaque -= 5;
                            notasNecessarias += "1 nota de 5" + Environment.NewLine;
                        }

                        if(nota >= 10 && resultado == 1)
                        {
                            valorSaque -= 6;
                            notasNecessarias += "3 notas de 2" + Environment.NewLine;
                        }
                    }
                }
            }

            return notasNecessarias;
        }
    }
}
