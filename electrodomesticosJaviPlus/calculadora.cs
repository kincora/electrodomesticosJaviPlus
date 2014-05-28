using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrodomesticosJaviPlus
{
    public partial class calculadora : Form
    {
        bool detectaoperacion = true;
        bool noOperar = false;
        bool chivatoNegativo = false;
        string operacionAnterior = "";
        string operaciones;
        double resultado;
        double cantidad1;
        double cantidad2;
        bool operacionesJuntas = false;
        
        public calculadora()
        {
            InitializeComponent();
        }

        //NUMERICOS





        private void Txtpantalla_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnret_Click(object sender, EventArgs e)
        {

            if (Txtpantalla.Text.Length == 1) Txtpantalla.Text = "";
            else Txtpantalla.Text = Txtpantalla.Text.Substring(0, Txtpantalla.Text.Length - 1);

        }



        private void btnc_Click(object sender, EventArgs e)
        {
            Txtpantalla.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Txtpantalla.TextLength <= 15)
                if (detectaoperacion)
                {
                    Txtpantalla.Text = "";
                    Txtpantalla.Text = "6";
                    detectaoperacion = false;
                }
                else
                {
                    Txtpantalla.Text = Txtpantalla.Text + "6";

                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "1";

                //cantidad1=operaConDeDosenDos();
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "1";

            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Txtpantalla.Text = Txtpantalla.Text + ",";
            button15.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "2";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "2";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "3";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "3";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "4";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "4";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "5";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "5";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "7";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "7";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "8";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "8";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "9";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "9";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (Txtpantalla.TextLength <= 15)
                operacionesJuntas = false;
            if (detectaoperacion)
            {
                Txtpantalla.Text = "";
                Txtpantalla.Text = "0";
                detectaoperacion = false;
            }
            else
            {
                Txtpantalla.Text = Txtpantalla.Text + "0";

            }
            //if (Txtpantalla.TextLength <= 15)
            /* if (Txtpantalla.Text == "0")
             {
                 return;
             }

             else
             {
                 Txtpantalla.Text = Txtpantalla.Text + "0";

             }*/
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Txtpantalla.Text = "";
            button15.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            operacionAnterior = "+";
            operacionesJuntas = true;
            detectaoperacion = true;
            button15.Enabled = true;
            if (Txtpantalla.Text == "") { noOperar = true; return; }
            noOperar = false;
            cantidad1 = double.Parse(Txtpantalla.Text);
            if (chivatoNegativo) { cantidad1 = cantidad1 * -1; chivatoNegativo = false; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            if ((operacionesJuntas) && (operacionAnterior != "+"))
            { operaciones = operacionAnterior; }
            if (Txtpantalla.Text == "") { noOperar = true; chivatoNegativo = true; return; }
            noOperar = false;
            detectaoperacion = true;
            button15.Enabled = true;
            cantidad1 = double.Parse(Txtpantalla.Text);
            if (chivatoNegativo) { cantidad1 = cantidad1 * -1; chivatoNegativo = false; }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            operacionAnterior = "/";
            operacionesJuntas = true;
            detectaoperacion = true;
            button15.Enabled = true;
            if (Txtpantalla.Text == "") { noOperar = true; return; }
            noOperar = false;
            cantidad1 = double.Parse(Txtpantalla.Text);
            if (chivatoNegativo) { cantidad1 = cantidad1 * -1; chivatoNegativo = false; }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            operacionAnterior = "*";
            operacionesJuntas = true;
            detectaoperacion = true;
            button15.Enabled = true;
            if (Txtpantalla.Text == "") { noOperar = true; return; }
            noOperar = false;
            cantidad1 = double.Parse(Txtpantalla.Text);
            if (chivatoNegativo) { cantidad1 = cantidad1 * -1; chivatoNegativo = false; }
        }

        /*private double operaConDeDosenDos()
        {
            switch (operaciones)
            {

                case "+":

                    resultado = cantidad1 + cantidad2;
                    return resultado;
                    break;

                case "-":
                    resultado = cantidad1 - cantidad2;
                    return resultado;
                    break;

                case "/":
                    resultado = cantidad1 / cantidad2;
                    return resultado;
                    break;

                case "*":
                    resultado = cantidad1 * cantidad2;
                    return resultado;
                    break;



            }

            return 0;
        }*/

        private void button16_Click(object sender, EventArgs e)
        {
            // if (Txtpantalla.Text == "") noOperar = true;
            //if (noOperar){ return; }
            cantidad2 = double.Parse(Txtpantalla.Text);
            detectaoperacion = true;
            button15.Enabled = true;

            switch (operaciones)
            {

                case "+":

                    resultado = cantidad1 + cantidad2;
                    Txtpantalla.Text = resultado.ToString();
                    break;

                case "-":

                    resultado = cantidad1 - cantidad2;
                    Txtpantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = cantidad1 / cantidad2;
                    Txtpantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = cantidad1 * cantidad2;
                    Txtpantalla.Text = resultado.ToString();
                    break;

                case "pot":
                    resultado = Math.Pow(cantidad1, cantidad2);
                    Txtpantalla.Text = resultado.ToString();
                    break;


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(Txtpantalla.Text);
            operaciones = "raiz";
            detectaoperacion = true;
            button15.Enabled = true;
            resultado = Math.Sqrt(cantidad1);
            Txtpantalla.Text = resultado.ToString();


        }

        private void Txtpantalla_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operaciones = "pot";
            detectaoperacion = true;
            button15.Enabled = true;
            if (Txtpantalla.Text == "") { noOperar = true; return; }
            noOperar = false;
            cantidad1 = double.Parse(Txtpantalla.Text);
        }
    }
}
