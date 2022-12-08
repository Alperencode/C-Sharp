using System;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(textBox1.Text, out result))
            {
                double not = (float)Convert.ToDouble(textBox1.Text);

                double resul = (4 * not) / 100;

                label1.Text = resul.ToString();
            }
            else
            {
                label1.Text = "Invalid input";
            }

        }
    }
}
