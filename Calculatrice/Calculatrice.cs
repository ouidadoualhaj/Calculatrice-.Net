using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        private decimal term1 = 0.0m;
        private decimal term2 = 0.0m;
        private decimal resultat = 0.0m;
        private string  operation = "+";

        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void effacer_Click(object sender, EventArgs e)
        {
            ecran.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(ecran.Text);
            ecran.Clear();
            operation = "+";
        }
        private void produit_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(ecran.Text);
            ecran.Clear();
            operation = "*";
        }

        private void moins_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(ecran.Text);
            ecran.Clear();
            operation = "-";
        }

        private void division_Click(object sender, EventArgs e)
        {
            term1 = decimal.Parse(ecran.Text);
            ecran.Clear();
            operation = "/";
        }

        private void egale_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    term2 = decimal.Parse(ecran.Text);
                    resultat = term1 + term2;
                    ecran.Text = resultat.ToString();
                    break;

                case "-":
                    term2 = decimal.Parse(ecran.Text);
                    resultat = term1 - term2;
                    ecran.Text = resultat.ToString();
                    break;

                case "*":
                    term2 = decimal.Parse(ecran.Text);
                    resultat = term1 * term2;
                    ecran.Text = resultat.ToString();
                    break;

                case "/":
                    term2 = decimal.Parse(ecran.Text);
                    resultat = term1 / term2;
                    ecran.Text = resultat.ToString();
                    break;
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if(!ecran.Text.Contains (".") )
            {
                ecran.Text += ".";
            }
        }


        private void ecran_TextChanged(object sender, EventArgs e)
        {

        }

        private void chiff0_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "0")
            {
                ecran.Text = "0";
            }
            else
            {
                ecran.Text += "0";
            }
        }

        private void chiff1_Click(object sender, EventArgs e)
        {
            if(ecran.Text == "O")
            {
                ecran.Text = "1";
            }
            else
            {
                ecran.Text += "1";
            }
        }

        private void chiff2_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "2";
            }
            else
            {
                ecran.Text += "2";
            }
        }

        private void chiff3_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "3";
            }
            else
            {
                ecran.Text += "3";
            }
        }

        private void chiff4_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "4";
            }
            else
            {
                ecran.Text += "4";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "5";
            }
            else
            {
                ecran.Text += "5";
            }
        }
        private void chiff6_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "6";
            }
            else
            {
                ecran.Text += "6";
            }
        }

        private void chiff7_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "7";
            }
            else
            {
                ecran.Text += "7";
            }
        }

        private void chiff8_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "8";
            }
            else
            {
                ecran.Text += "8";
            }
        }

        private void chiff9_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "9";
            }
            else
            {
                ecran.Text += "9";
            }
        }

        private void double0_Click(object sender, EventArgs e)
        {
            if (ecran.Text == "O")
            {
                ecran.Text = "00";
            }
            else
            {
                ecran.Text += "00";
            }
        }

    }
}
