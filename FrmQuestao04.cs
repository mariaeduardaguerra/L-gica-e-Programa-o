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
    public partial class FrmQuestao04 : Form
    {
        public FrmQuestao04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturar os dados que desejo na tela
            float qntMilho = float.Parse(txtQntMilho.Text);
            float qntSuco = float.Parse(txtQntSuco.Text);
            float resultado;

            //Realizar o cálculo
            resultado = (qntMilho * 1.5f) + (qntSuco * 2.0f);

            //Mostrar o resultado
            MessageBox.Show("O valor a pagar é " + resultado);
        }
    }
}
