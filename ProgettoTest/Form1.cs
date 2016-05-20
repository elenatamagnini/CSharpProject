using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgettoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ifButton_Click(object sender, EventArgs e)
        {
            string nome = "Pippo";
            int anni = 28;

            /* 
             * a > b,
             * a < b,
             * a >= b,
             * a <= b,
             * a == b,
             * a != b <-- DIVERSO
             */

            /*
             * && <-- and
             * || <-- or
             */

            if ( (nome == "Giovanni" || nome == "Gio") && anni == 28)
            {
                Console.WriteLine("Ciao sei Giovanni");
            }
            else if (anni == 28)
            {
                Console.WriteLine("L'età è giusta ma non sei Giovanni");
            }
            else
            {
                Console.WriteLine("Non sei Giovanni");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            string nome = "Pippo";
            int anni = 28;

            switch (nome)
            {
                case "Gio":
                case "Giovanni":
                    if (anni == 28) Console.WriteLine("Sei Giovanni");
                    else Console.WriteLine("Non sei Giovanni che sto cercando");

                    break;
                case "Paolo":
                    Console.WriteLine("Non sei Giovanni ma sei suo amico");
                    break;
                case "Pino":
                    Console.WriteLine("Non sei Giovanni e sei un suo acerrimo nemico");
                    break;
                default:
                    Console.WriteLine("Non sei Giovanni e non ti conosco");
                    break;
            }
        }

        private void forButton_Click(object sender, EventArgs e)
        {
            // i = i + 1;  ==  i += 1;  ==  i++;
            // i = i - 1;  ==  i -= 1;  ==  i--;
            // i = i + 2;  ==  i += 2;
            // i = i - 2;  ==  i -= 2,

            // for ( dichiaro e inizializzo contatore; condizione (fino a che è vera continuo); di quanto incremento il concatore ad ogni passo)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ciao");
            }
        }

        private int somma(int a, int b)
        {
            return a + b;
        }

        private void sommaButt_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = somma(int.Parse(aTxt.Text), int.Parse(bTxt.Text)).ToString();
            }
            catch
            {
                result.Text = "Valore non numerico!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private int sottrazione(int c, int d)
        {
            return c - d;
        }

        private void sottrazioneButt_Click(object sender, EventArgs e)
        {
            try
            {
                result2.Text = sottrazione(int.Parse(cTxt.Text), int.Parse(dTxt.Text)).ToString();
            }
            catch
            {
                result2.Text = "Valore non numerico!";
            }
        }
    }
}


