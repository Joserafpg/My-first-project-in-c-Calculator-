using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void txtnumero2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void txtnumero3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void txtnumero4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void txtnumero5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void txtnumero6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void txtnumero7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void txtnumero8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void txtnumero9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void txtnumero0_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void txtnumerosuma_Click(object sender, EventArgs e)
        {
            operacion = "+"; primero = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operacion = "*"; primero = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void txtnumeroresta_Click(object sender, EventArgs e)
        {
            operacion = "-"; primero = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operacion = "%"; primero = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "/"; primero = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void txtnumeroresultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtresultado.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo; txtresultado.Text = resultado.ToString(); break;

                case "-":
                    resultado = primero - segundo; txtresultado.Text = resultado.ToString(); break;

                case "*":
                    resultado = primero * segundo; txtresultado.Text = resultado.ToString(); break;

                case "/":
                    resultado = primero / segundo; txtresultado.Text = resultado.ToString(); break;

                case "%":
                    resultado = primero % segundo; txtresultado.Text = resultado.ToString(); break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}