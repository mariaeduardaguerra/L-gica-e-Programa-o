using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Lista_01
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void lblcalculadora_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void txtoperacao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somar");
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar Registro");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subtrair");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limpar");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multiplicar");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0");
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ponto");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dividir");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Igual a");
        }
    }
}
