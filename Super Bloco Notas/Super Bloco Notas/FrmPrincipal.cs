using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Bloco_Notas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha f = new FrmFilha();
            f.Text = String.Format("Novo docoumento - {0}", this.MdiChildren.Length + 1);
            f.MdiParent = this;
            f.Show();
        }
    }
}
