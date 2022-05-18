using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solução___Exercicio_SomaAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int a, n;
            Int32.TryParse(txt_va.Text, out a);
            Int32.TryParse(txt_vn.Text, out n);
            lbResposta.Text = SomaAN(a, n);
        }

        private String SomaAN(int a, int n)
        {
            int contador = a;
            int aux = a;
            String saida = a.ToString();
            for(int i = 1; i < n; i++)
            {
                contador += (a + i);
                saida += " + ";
                aux = a + i;
                saida += aux;
            }

            return saida + " = " + contador;
        }
    }
}
