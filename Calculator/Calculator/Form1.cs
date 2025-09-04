using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Security.Authentication;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        //Class
        private string operation = "";
        private double firstNumber = 0;
        private double secondNumber = 0;
        private bool ClearDisplay = false;



        public frmCalculator()
        {
            InitializeComponent();






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirstNumber.Text);
            double num2 = Convert.ToDouble(txtSecondNumber.Text);

            double rest = num1 + num2;

            string msj = "Resultado de su suma: " + rest;

            lbResultado.Text = msj;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirstNumber.Text);
            double num2 = Convert.ToDouble(txtSecondNumber.Text);

            double rest = num1 - num2;

            string msj = "Resultado de la resta es: " + rest;

            lbResultado.Text = msj;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirstNumber.Text);
            double num2 = Convert.ToDouble(txtSecondNumber.Text);

            double rest = num1 / num2;

            string msj = "El resultado de la division es: " + rest;
            lbResultado.Text = msj;
        }
    }
}