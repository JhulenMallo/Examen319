using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta2___Examen319
{
    public partial class Form1 : Form
    {
        float term1, term2;
        string operac;
        public Form1()
        {
            InitializeComponent();
        }

        private void botones_numericos_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
                pantalla.Text = ((Button)sender).Text;
            else
                pantalla.Text += ((Button)sender).Text;
        }

        private void borrar_pantalla_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
        }

        private void coma_decimal_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains(","))
            {
                if (pantalla.Text == "")
                    pantalla.Text += "0,";
                else
                    pantalla.Text += ",";
            }
        }

        private void operaciones_aritmeticas_Click(object sender, EventArgs e)
        {
            if (pantalla.Text != "")
            {
                term1 = float.Parse(pantalla.Text);
                operac = ((Button)sender).Text;
                pantalla.Text = "";
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            if (pantalla.Text != "")
            {
                term2 = float.Parse(pantalla.Text);
                float res = 0;
                switch (operac)
                {
                    case "+":
                        res = term1 + term2;
                        break;
                    case "-":
                        res = term1 - term2;
                        break;
                    case "*":
                        res = term1 * term2;
                        break;
                    case "/":
                        res = term1 / term2;
                        break;
                    default:
                        res = float.Parse(pantalla.Text);
                        break;
                }
                pantalla.Text = res.ToString();
                operac = "";
            }
        }

    }
}
