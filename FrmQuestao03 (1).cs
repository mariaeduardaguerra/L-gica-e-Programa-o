using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2C131MariaEduardaGuerra
{
    public partial class FrmQuestao03 : Form
    {
        public FrmQuestao03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturar os dados que desejo na tela
            float totalFuncionarios = float.Parse(txtTotalFuncionarios.Text);
            float qntSolteiros = float.Parse(txtQntSolteiros.Text);
            float resultado;

            //Realizar o cálculo
            resultado = (qntSolteiros / totalFuncionarios) * 100;

            //Mostrar o resultado
            lblResultado.Text = resultado.ToString();
        }
    }
}
