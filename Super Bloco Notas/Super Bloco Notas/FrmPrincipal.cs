using System;
using System.IO;
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Deseja realmente sair?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha filhaAtiva = (FrmFilha)this.ActiveMdiChild;
            if (filhaAtiva != null)
            {
                try
                {
                    RichTextBox rtTexto = filhaAtiva.rtTextoUsuario;

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Arquivo de Texto | *.txt";
                    saveFileDialog.FileName = "Arquivo.txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                        for (int i = 0; i < rtTexto.Lines.Length; i++)
                        {
                            writer.WriteLine(rtTexto.Lines[i]);
                        }
                        filhaAtiva.Text = saveFileDialog.FileName;

                        writer.Dispose();
                        writer.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Ops... algo deu errado!");
                }
            }
        }

        private void arirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivo de Text | *.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FrmFilha frmFilha = new FrmFilha();
                frmFilha.MdiParent = this;
                StreamReader reader = new StreamReader(openFileDialog.OpenFile());

                frmFilha.rtTextoUsuario.Text = reader.ReadToEnd();

                reader.Dispose();
                reader.Close();

                frmFilha.Text = openFileDialog.FileName;
                frmFilha.Show();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar_recortar(false);
        }

        private void copiar_recortar(bool recortando)
        {
            FrmFilha frmFilha = (FrmFilha)this.ActiveMdiChild;
            if (frmFilha != null)
            {
                try
                {
                    RichTextBox textBox = frmFilha.rtTextoUsuario;
                    if (textBox != null)
                    {
                        Clipboard.SetText(textBox.SelectedText, TextDataFormat.UnicodeText);
                        if (recortando)
                        {
                            textBox.SelectedText = String.Empty;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao copiar...");
                }
            }
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar_recortar(true);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha frmFilha = (FrmFilha)this.ActiveMdiChild;
            if (frmFilha != null)
            {
                try
                {
                    RichTextBox textBox = frmFilha.rtTextoUsuario;
                    if (textBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.StringFormat))
                        {
                            textBox.SelectedText = data.GetData(DataFormats.StringFormat).ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao colar...");
                }
            }
        }
    }
}
