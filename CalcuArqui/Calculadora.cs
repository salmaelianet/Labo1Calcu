using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuArqui
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();

        }



        private void boton0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);
            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = primero+segundo;
                    tbxScreen.Text = Sum.ToString();
                    break;

                case "-":
                    Res = primero-segundo;
                    tbxScreen.Text = Res.ToString();
                    break;

                case "*":
                    Mul = primero*segundo;
                    tbxScreen.Text = Mul.ToString();
                    break;

                case "/":
                    Div = primero/segundo;
                    tbxScreen.Text = Div.ToString();
                    break;

            }
        }

        private void botonDEL_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}
