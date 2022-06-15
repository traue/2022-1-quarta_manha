using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Revisão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 5;
            int c = metodo1(a, b);
            MessageBox.Show(c.ToString());
        }

        int metodo1(int x, int y)
        {
            x = x * y;
            return x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //gerar a sequência: 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
            string seq = "";

            for(int i = 10; i > 0; i--)
            {
                seq += i + " ";
            }

            MessageBox.Show(seq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //i deve ser igual a 30, ou seja, preciso de um loop que rode 30 vezes
            int i;

            //?

            MessageBox.Show(i.ToString());


        }
    }
}
