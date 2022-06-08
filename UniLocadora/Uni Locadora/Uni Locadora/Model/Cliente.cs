using System;

namespace Uni_Locadora.Model
{
    public class Cliente
    {
        private int idCliente;
        private string nome;
        private string cpf;
        private DateTime dtNasc;

        public Cliente() { }

        public Cliente(int idCliente, string nome, string cpf, DateTime nasc)
        {
            IdCliente=idCliente;
            Nome=nome;
            Cpf=cpf;
            Nasc=nasc;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Nasc { get => dtNasc; set => dtNasc = value; }
    }
}