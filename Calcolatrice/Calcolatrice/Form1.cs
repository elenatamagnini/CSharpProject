using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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


        private int divisione (int e, int f)
        {
            return e / f;
        }

        private void divisioneButt_Click(object sender, EventArgs e)
        {
            try
            {
                result3.Text = divisione(int.Parse(eTxt.Text), int.Parse(fTxt.Text)).ToString();
            }
            catch
            {
                result3.Text = "Valore non numerico!";
            }
        }

        private int moltiplicazione (int g, int h)
        {
            return g * h;
        }

        private void moltButt_Click(object sender, EventArgs e)
        {
            try
            {
                result4.Text = moltiplicazione(int.Parse(gTxt.Text), int.Parse(hTxt.Text)).ToString();
            }
            catch
            {
                result4.Text = "Valore non numerico!";
            }
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
                result4.Text = "Valore non numerico!";
            }
        
        }
    }
}











