using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Uni_Locadora.Dao;
using Uni_Locadora.Model;

namespace Uni_Locadora
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!validaDados())
            {
                return;
            }

            gravaNovoCliente();
        }


        private void gravaNovoCliente()
        {
            DateTime dataAux;
            DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy",
                new CultureInfo("pt-BR"), DateTimeStyles.None, out dataAux);

            Cliente cliente = new Cliente(0, txtNome.Text, txtCPF.Text, dataAux);

            ClienteDao cDao = new ClienteDao();

            try
            {
                if (cDao.AdicionaCliente(cliente))
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso",
                    "Cliente Cadastrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }


        private bool validaDados()
        {
            //valida o nome do cliente:
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Verifique o nome do cliente",
                    "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNome.Focus();

                return false;
            }

            //validação simples do CPF:
            if (!txtCPF.MaskFull)
            {
                MessageBox.Show("Verifique o CPF do cliente",
                    "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCPF.Focus();

                return false;
            }

            //Inicio do processo de validação da data:
            //1a. etapa:
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool dataValida = regex.IsMatch(txtDtnasc.Text.Trim());

            //2a. etapa:
            DateTime dt;
            dataValida &= DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy", 
                new CultureInfo("pt-BR"), DateTimeStyles.None, out dt);

            if(!dataValida)
            {
                MessageBox.Show("Verifique a data de nascimento do cliente",
                    "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtDtnasc.Focus();

                return false;
            }

            return true;
        }
    }
}
