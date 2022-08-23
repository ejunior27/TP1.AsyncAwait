using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1.AsyncAwait
{
    public partial class FrmExemplo : Form
    {
        public FrmExemplo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await BaixarArquivo();
        }

        private async Task BaixarArquivo()
        {
            button3.Enabled = false;
            label1.ForeColor = Color.Red;
            label1.Text = "Baixando arquivo... Aguarde...";

            //Essa linha simula a requisição e a resposta do servidor onde está o 
            //arquivo para download
            await Task.Delay(TimeSpan.FromSeconds(8));

            label1.Text = "Arquivo baixado com sucesso!";
            label1.ForeColor = Color.Green;
            button3.Enabled = true;
        }
    }
}
