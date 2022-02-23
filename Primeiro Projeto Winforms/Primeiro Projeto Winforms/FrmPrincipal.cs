using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lbResultado.Text = $"Olá {txtNome.Text}, seja muito bem-vindo(a)!";
        }
    }
}
