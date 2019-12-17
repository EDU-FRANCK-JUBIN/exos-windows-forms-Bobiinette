using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void buttonN0_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 0;
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 1;
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 2;
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 3;
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 4;
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 5;
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 6;
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 7;
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 8;
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += 9;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBoxCalcul.Text == "" && textBoxResult.Text != "")
            {
                textBoxCalcul.Text = textBoxResult.Text;
            }
            textBoxCalcul.Text += '/';
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBoxCalcul.Text == "" && textBoxResult.Text != "")
            {
                textBoxCalcul.Text = textBoxResult.Text;
            }
            textBoxCalcul.Text += '*';
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            if (textBoxCalcul.Text == "" && textBoxResult.Text != "")
            {
                textBoxCalcul.Text = textBoxResult.Text;
            }
            textBoxCalcul.Text += '-';
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(textBoxCalcul.Text == "" && textBoxResult.Text != "")
            {
                textBoxCalcul.Text = textBoxResult.Text;
            } 
            textBoxCalcul.Text += '+';
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if(textBoxCalcul.Text[0] == '+')
            {
                textBoxCalcul.Text = '-' + textBoxCalcul.Text.Remove(0, 1);
            } else if (textBoxCalcul.Text[0] == '-')
            {
                textBoxCalcul.Text = textBoxCalcul.Text.Remove(0, 1);
            } else
            {
                textBoxCalcul.Text = '-' + textBoxCalcul.Text;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            textBoxCalcul.Text = textBoxCalcul.Text.Replace(',', '.');
            try
            {
                var v = dt.Compute(textBoxCalcul.Text, "");
                double d = Convert.ToDouble(v.ToString());
                if (Double.IsInfinity(d))
                {
                    throw new System.DivideByZeroException();
                }
                textBoxResult.Text = v.ToString();
                textBoxCalcul.Text = "";
            } catch(System.Data.SyntaxErrorException exception)
            {
                MessageBox.Show("Erreur dans l'expression " + textBoxCalcul.Text,
                    "Erreur de calcul",
                    MessageBoxButtons.OK);
            } catch (System.DivideByZeroException exception)
            {
                MessageBox.Show("Division par zéro dans l'expression " + textBoxCalcul.Text,
                    "Division par zéro",
                    MessageBoxButtons.OK);
            } catch (System.FormatException exception)
            {
                MessageBox.Show("Erreur de format dans l'expression " + textBoxCalcul.Text,
                    "Erreur de format",
                    MessageBoxButtons.OK);
            }
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text += ',';
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxCalcul.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxCalcul.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(textBoxCalcul.Text.Length > 0)
            {
                textBoxCalcul.Text = textBoxCalcul.Text.Remove(textBoxCalcul.Text.Length - 1, 1);
            }
        }
    }
}
