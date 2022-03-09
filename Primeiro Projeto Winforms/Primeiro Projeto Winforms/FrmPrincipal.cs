using System;
using System.Windows.Forms;

namespace Primeiro_Projeto_Winforms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length != 0)
            {
                lbResultado.Text = $"Olá {txtNome.Text}, seja muito bem-vindo(a)!";
            }
            else
            {
                MessageBox.Show("Ops... informe o nome!", "Erro!");
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "Digite seu nome!";
            txtNome.Text = "";
            txtNome.Focus();
        }
    }
}
