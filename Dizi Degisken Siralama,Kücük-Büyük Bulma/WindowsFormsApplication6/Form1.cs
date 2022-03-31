using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] sayi = new int [50];
        Random yunus = new Random();
        string [] sehir ={"İstanbul","Ankara","İzmir"};
        
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++) 
            {
                listBox1.Items.Add(sayi[i]);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Array.Reverse(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALLAH( c.c. )");
            label1.Text = sayi.Max().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = sayi.Min().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = sayi.Sum().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = sayi.Average().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = sayi.First().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label6.Text = sayi.Last().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = yunus.Next(0, 1000);
                listBox1.Items.Add(i + 1 + " = " + sayi [i]);
            }
        }

    }
}
