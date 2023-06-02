using System.Security.Cryptography.Pkcs;

namespace scientific_calculator
{
    public partial class Calculator : Form
    {
        bool isfirst = true;
        int p, d;
        char opr;
        public Calculator()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "2";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "0";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += "9";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                Screen.Text = "";
                isfirst = false;
            }
            Screen.Text += ".";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '+';
            isfirst = true;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            d = int.Parse(Screen.Text);
            switch (opr)
            {
                case '+':
                    Screen.Text = (p + d).ToString();
                    break;
                case '-':
                    Screen.Text = (p - d).ToString();
                    break;
                case '*':
                    Screen.Text = (p * d).ToString();
                    break;
                case '/':
                    Screen.Text = (p / d).ToString();
                    break;
                case '%':
                    Screen.Text = (p % d).ToString();
                    break;
                case '!':
                    int result = 1;
                    for (int i = p; i >= 1; i--)
                    {
                        result *= i;
                    }
                    Screen.Text = (result).ToString();
                    break;
                case '^':
                    int r = 1;
                    while (d != 0)
                    {
                        r *= p;
                        d--;
                    }
                    Screen.Text = (r).ToString();
                    break;
                case 'S':
                    Screen.Text = (Math.Sin(d * (Math.PI) / 180)).ToString();
                    break;
                case 'C':
                    Screen.Text = (Math.Cos(d * (Math.PI) / 180)).ToString();
                    break;
                case 'T':
                    Screen.Text = (Math.Tan(d * (Math.PI) / 180)).ToString();
                    break;
                case 'L':
                    Screen.Text = (Math.Log10(d)).ToString();
                    break;
                case 's':
                    Screen.Text = (Math.Sinh(d)).ToString();
                    break;
                case 'c':
                    Screen.Text = (Math.Cosh(d)).ToString();
                    break;
                case 't':
                    Screen.Text = (Math.Tanh(d)).ToString();
                    break;
                case 'n':
                    Screen.Text=(p+(-d)).ToString();
                    break;

            }
            isfirst = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '-';
            isfirst = true;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '*';
            isfirst = true;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '/';
            isfirst = true;
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '%';
            isfirst = true;
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            if(Screen.Text.Length > 0)
            {
                Screen.Text=Screen.Text.Remove(Screen.TextLength-1,1);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            isfirst = true;
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '!';
            isfirst = true;

        }

        private void Power_Click(object sender, EventArgs e)
        {
            p = int.Parse(Screen.Text);
            opr = '^';
            isfirst = true;
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "Sin(";
            opr = 'S';
            isfirst = true;
        }

        private void Cosine_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "Cos(";
            opr = 'C';
            isfirst = true;
        }

        private void Tangent_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "tan(";
            opr = 'T';
            isfirst = true;

        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "log(";
            opr = 'L';
            isfirst = true;
        }

        private void Sinhyperbolic_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "sinh(";
            opr = 's';
            isfirst = true;
        }

        private void coshyperbolic_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "cosh(";
            opr = 'c';
            isfirst = true;
        }

        private void tanhyperbolic_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            Screen.Text += "tanh(";
            opr = 't';
            isfirst = true;
        }

        private void Negation_Click(object sender, EventArgs e)
        {
            p=int.Parse(Screen.Text);
            opr = 'n';
            isfirst = true;
        }
    }
}