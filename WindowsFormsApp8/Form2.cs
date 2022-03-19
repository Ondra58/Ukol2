using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int pocet;
        int[] pole;
        Random rng = new Random();
        int B;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                pocet = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                pole = new int[pocet];
                for (int i = 0; i < pocet; i++)
                {
                    int random = rng.Next(0, 101);
                    pole[i] = random;
                    listBox1.Items.Add(pole[i].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                B = int.Parse(textBox1.Text);
                Array.Sort(pole);
                if (pocet != 0)
                {
                    for (int i = 0; i < pocet; i++)
                    {
                        if (pole[i] < B)
                        {
                            listBox2.Items.Add(pole[i].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            try
            {
                B = int.Parse(textBox1.Text);
                Array.Sort(pole);
                if (pocet != 0)
                {
                    for (int i = 0; i < pocet; i++)
                    {
                        if (pole[i] > B)
                        {
                            listBox3.Items.Add(pole[i].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
