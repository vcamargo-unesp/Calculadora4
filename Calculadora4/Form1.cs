using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void AtribuirOperador(string operador)
        {
            lblOper.Text = operador;
            btIgual.Enabled = true;
        }

        void TravarBotao()
        {
            /*if (lblOper.Text == "..." ||
                (lblOper.Text == btDiv.Text && numOper2.Value == 0))
                btIgual.Enabled = false;
            else
                btIgual.Enabled = true;*/

            btIgual.Enabled = !(lblOper.Text == "..." ||
                (lblOper.Text == btDiv.Text && numOper2.Value == 0));
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btSoma.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btSub.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperador(btDiv.Text);
            TravarBotao();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lblOper.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (lblOper.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOper.Text == btMult.Text)
                resultado = num1 * num2;
            else resultado = num1 / num2;

            lblResultado.Text = resultado.ToString();
        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {
            TravarBotao();
        }
    }
}
