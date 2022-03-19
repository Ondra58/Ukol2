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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int[] pole = new int[textBox1.Lines.Length];
                int i, pomocna = 0;
                for (i = 0; i < textBox1.Lines.Length && int.Parse(textBox1.Lines[i]) != 0; i++)
                {
                    pole[i] = int.Parse(textBox1.Lines[i]);
                    if(pole[i] < 0)
                    {
                        MessageBox.Show("Pole nesmí obsahovat záporná čísla!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    pomocna++;
                }
                int posledni = pole[i - 1];
                for (i = 0; i < pomocna; i++)
                {
                    if (pole[i] < posledni)
                    {
                        listBox1.Items.Add(pole[i] + ", pozice " + (i + 1));
                    }
                }
                if (posledni != 0)
                {
                    double podil = (double)pole[0] / (double)posledni;
                    label2.Text = podil.ToString();
                    label2.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           } 

    }
}
