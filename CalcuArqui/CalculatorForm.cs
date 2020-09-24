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
    public partial class CalculatorForm : Form
    {
        double first;
        double second;
        string simbol;

        Calculator calculator = new Calculator();

        public CalculatorForm()
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
            simbol = "+";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            simbol = "-";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            simbol = "*";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            simbol = "/";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            second = double.Parse(tbxScreen.Text);
            double Ans = 0;

            switch (simbol)
            {
                case "+":
                    Ans = calculator.sum(first, second);
                    break;

                case "-":
                    Ans = calculator.subtraction(first, second);
                    break;

                case "*":
                    Ans = calculator.multiplicacion(first,second);
                    break;

                case "/":
                    Ans = calculator.division(first, second);
                    break;
            }
            tbxScreen.Text = Ans.ToString();

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
