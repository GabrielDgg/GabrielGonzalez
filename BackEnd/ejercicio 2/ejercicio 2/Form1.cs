using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int noPalindromo = 0;

            for (int i = 0, j= textBox1.Text.Length-1; i < j; i++, j--)
            {
                
                    if (textBox1.Text[i]!= textBox1.Text[j])
                    {
                        noPalindromo++;
                    }
                
            }

            switch (noPalindromo)
            {
                case 0:
                    label2.Text = "Es palindromo";
                    break;

                case 1:
                    label2.Text = "Casi es palindromo";
                    break;

                default:
                    label2.Text = "No palindromo";
                    break;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
