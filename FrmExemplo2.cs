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
    public partial class FrmExemplo2 : Form
    {
        public FrmExemplo2()
        {
            InitializeComponent();
        }

        private DateTime cronometro = new();

        private void FrmExemplo2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cronometro = cronometro.AddSeconds(1);
            Text = cronometro.ToLongTimeString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Text = await ObterTexto();
            button1.Enabled = true;
        }

        private async Task<string> ObterTexto()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            return "Turma 854 - Técnicas de Programação 1";
        }
    }
}
