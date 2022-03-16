namespace Calculadora_IMC
{
    public class Imc
    {
        private float peso;
        private float altura;

        public float Altura
        {
            get => altura;
            set => altura = value;
        }

        public float Peso
        {
            get => peso;
            set => peso = value;
        }

        public float calculaImc()
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        /**
         * 
         * Desafio do tio:
         * 
         * Implementar o processo de classificação 
         * usando a tabela disponível em
         * https://arquivos.sbn.org.br/equacoes/eq5.htm
         * 
         * Desafio 2: Deixar o IMC com apenas duas casas decimais
         */
    }
}
