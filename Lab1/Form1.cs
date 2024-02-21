using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int p, q, n, f, d, e;
        int lb = 100; // нижняя граница
        int hb = 1000; // верхняя граница

        int[] arr = new int[0];

        Random rnd = new Random();

        NumericManipulater num = new NumericManipulater();

        Encrypt enc = new Encrypt();
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = lb; i < hb; i++)
            {
                if(num.Check_simplenumber(i) == true)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length-1] = i; 
                }
                else 
                {
                    continue;
                }
            }

            string[] arrstr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrstr[i] = Convert.ToString(arr[i]);
            }

            listBox1.Items.AddRange(arrstr);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = arr[rnd.Next(arr.Length)];
            textBox1.Text = Convert.ToString(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            q = arr[rnd.Next(arr.Length)];
            textBox2.Text = Convert.ToString(q);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = p * q;
            textBox3.Text = Convert.ToString(n);
            f = (p - 1) * (q - 1);
            textBox4.Text = Convert.ToString(f);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            do
            {
                d = rnd.Next(1000, 10000);
            } while(num.MutuallyPrimeNumbers(f,d) == false);

            textBox5.Text = Convert.ToString(d);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.e = num.NumberE(d, f);

            textBox6.Text = Convert.ToString(this.e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

        }

    }
}
