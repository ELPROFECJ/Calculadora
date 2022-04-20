using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (textPrincipal.Text == "0")
                textPrincipal.Text = "";

            textPrincipal.Text += boton.Text;
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(textPrincipal.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                textPrincipal.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                textPrincipal.Text = Numero1.ToString();
            }

            else
                {
                
                textPrincipal.Text = "0";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "3";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textPrincipal.Text);

            if (Operador == '+')
            {
                textPrincipal.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textPrincipal.Text);
            }
            else if (Operador == '-')
            {
                textPrincipal.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textPrincipal.Text);
            }
            else if (Operador
                == '*')
            {
                textPrincipal.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textPrincipal.Text);
            }
            else if (Operador == '/')
            {
                textPrincipal.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(textPrincipal.Text);
            }
        }

        private void butN1_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "1";
        }

        private void butN2_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "2";
        }

        private void butn5_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "5";
        }

        private void butn6_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "6";
        }

        private void butn7_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "7";
        }

        private void butn8_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "8";
        }

        private void butn9_Click(object sender, EventArgs e)
        {
            textPrincipal.Text = textPrincipal.Text + "9";
        }

        private void butnPunto_Click(object sender, EventArgs e)
        {
            if (!textPrincipal.Text.Contains('.')) 
            {
                textPrincipal.Text += ".";
            }
        }

        private void butnComa_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(textPrincipal.Text);
            Numero1 *= -1;
            textPrincipal.Text = Numero1.ToString();
        }

       
        private void butnQuitar1_Click(object sender, EventArgs e)
        {
            if (textPrincipal.Text.Length > 0)
            {
                textPrincipal.Text = textPrincipal.Text.Substring(0, textPrincipal.Text.Length - 1);
            }
            else
            {
                textPrincipal.Text = "0";
            }
        }

        private void butnBorrartodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            textPrincipal.Text = "0";
        }

        private void textPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
