using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string operador = "";
        double primero;
        double segundo;   
        
        public Form1()
        {
            InitializeComponent();
        }
  
        private void mostrarNumeros(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            if(uno.Text == "0")
            {
                uno.Text = "";
            }
            uno.Text += boton.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {             
            
            operador = "+";
            label1.Text = uno.Text + " +";
            primero = Convert.ToDouble(uno.Text);
            uno.Text = "0";
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "*";
            label1.Text = uno.Text + " x";
            primero = Convert.ToDouble(uno.Text);
            uno.Text = "0";
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
            operador = "-";
            label1.Text = uno.Text + " -";
            primero = Convert.ToDouble(uno.Text);
            uno.Text = "0";
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            operador = "/";
            label1.Text = uno.Text + " ÷";
            primero = Convert.ToDouble(uno.Text);
            uno.Text = "0";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            double factorial = 1;

            int numero;

            bool EsEntero = Int32.TryParse(uno.Text, out numero);

            if (!EsEntero)
            {
                label1.Text = "Error de dominio";
            }
            else
            {
                int primer = Convert.ToInt32(uno.Text);
                for (int i = 1; i <= primer; i++)
                {
                    factorial = factorial * i;
                }

                uno.Text = factorial.ToString();
                label1.Text = Convert.ToString(primer + " ! = " + factorial);
            }          
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double result; 

            switch (operador) {
                case "+":

                    segundo = Convert.ToDouble(uno.Text);
                    result = primero + segundo;
                    uno.Text = result.ToString();
                    label1.Text = Convert.ToString(primero + " + " + segundo + " = " + result);
                    break;

                case "-":
      
                    segundo = Convert.ToDouble(uno.Text);
                    result = primero - segundo;
                    uno.Text = result.ToString();
                    label1.Text = Convert.ToString(primero + " - " + segundo + " = " + result);
                    break;

                case "*":
      
                    segundo = Convert.ToDouble(uno.Text);
                    result = primero * segundo;
                    uno.Text = result.ToString();
                    label1.Text = Convert.ToString(primero + " x " + segundo + " = " + result);
                    break;

                case "/":
             
                    segundo = Convert.ToDouble(uno.Text);

                    if (segundo == 0)
                    {
                        label1.Text = "No se puede dividir por 0";
                    }
                    else
                    {
                        result = primero / segundo;
                        uno.Text = result.ToString();
                        label1.Text = Convert.ToString(primero + " ÷ " + segundo + " = " + result);                       
                    }

                    break;
            }
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            uno.Text = "0";
            primero = 0;
            segundo = 0;
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void uno_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }  

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (uno.Text.Length > 1)
            {
                uno.Text = uno.Text.Substring(0, uno.Text.Length - 1);
            }
            else
            {
                uno.Text = "0";
            }
        }
    }
}
