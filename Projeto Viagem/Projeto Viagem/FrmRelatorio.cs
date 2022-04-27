using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto_Viagem
{
    public partial class FrmRelatorio : Form
    {
        private float distancia, consumo, combustivel, pedagio;

        public FrmRelatorio(float distancia, float consumo, float combustivel, float pedagio)
        {
            this.distancia = distancia;
            this.consumo = consumo;
            this.combustivel = combustivel;
            this.pedagio = pedagio;

            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            float qtdLitros = calculaQtdLitros(distancia, consumo);
            float vTotalCombustivel = calculaValorGastoCombustivel(qtdLitros, combustivel);
            float vTotalViagem = calculaValorTotalViagem(vTotalCombustivel, pedagio);
            String aux = "";

            aux = "Distância informada: " + distancia + "Km";
            adicionaTexto(aux);

            aux = "Consumo do veículo infomado: " + consumo + "Km/L";
            adicionaTexto(aux);

            aux = "Valor informado o combustível: R$" + combustivel;
            adicionaTexto(aux);


            aux = "Houve gasto com pedágios: " + (pedagio == 0 ? "Não" : "Sim");
            adicionaTexto(aux);

            if (pedagio != 0)
            {
                aux = "Valor gasto com pedágio(s): R$" + pedagio;
                adicionaTexto(aux);
            }

            rtRelatorio.AppendText(Environment.NewLine + "-------------------" + Environment.NewLine);

            aux = "Quantidade de litros utilizada: " + qtdLitros + "L";
            adicionaTexto(aux);

            aux = "Valor total gasto com combustível: R$" + vTotalCombustivel;
            adicionaTexto(aux);

            aux = "-> Valor total da Viagem: R$" + vTotalViagem;
            adicionaTexto(aux);

        }

        private float calculaQtdLitros(float distancia, float consumo)
        {
            return distancia / consumo;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "Arquivo de Texto | *.txt";
                save.FileName = "Relatorio_Viagem.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(save.OpenFile());
                    for (int i = 0; i < rtRelatorio.Lines.Length; i++)
                    {
                        sw.WriteLine(rtRelatorio.Lines[i]);
                    }

                    sw.Close();
                    sw.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Ops... houve algum erro...!");
            }
        }

        private float calculaValorGastoCombustivel(float qtdLitros, float vCombustivel)
        {
            return qtdLitros * vCombustivel;
        }

        private float calculaValorTotalViagem(float vGastoCombustivel, float vPedagios)
        {
            return vGastoCombustivel + vPedagios;
        }

        //de: https://stackoverflow.com/questions/4077582/format-text-in-rich-text-box
        private void adicionaTexto(string texto)
        {
            string[] aux = texto.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            if (aux.Length == 2)
            {
                rtRelatorio.DeselectAll();
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Bold);
                rtRelatorio.AppendText(Environment.NewLine + aux[0] + ": ");
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Regular);
                rtRelatorio.AppendText(aux[1]);
            }
        }

    }
}
