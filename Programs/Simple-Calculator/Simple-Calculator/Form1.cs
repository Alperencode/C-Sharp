using System;

using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            // numbers button and point
            if (result_text.Text == "0" || PerformedOp)
                result_text.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result_text.Text.Contains("."))
                    result_text.Text += button.Text;
            }

            else
                result_text.Text += button.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Operator_click_Event(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                btn_op_equal.PerformClick();
                Operator_Performed = button.Text;
                prev_operation.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {
                Operator_Performed = button.Text;
                Result_Value = Double.Parse(result_text.Text);
                prev_operation.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void op_CE_Click(object sender, EventArgs e)
        {
            // Clear Entry Button
            result_text.Text = "0";
        }

        private void op_C_Click(object sender, EventArgs e)
        {
            // Clear Button
            result_text.Text = "0";
            Result_Value = 0;
            prev_operation.Text = " ";
        }

        private void equal_op_Click(object sender, EventArgs e)
        {
            // Operations
            switch (Operator_Performed)
            {
                case "+":
                    result_text.Text = (Result_Value + Double.Parse(result_text.Text)).ToString();
                    break;

                case "-":
                    result_text.Text = (Result_Value - Double.Parse(result_text.Text)).ToString();
                    break;

                case "*":
                    result_text.Text = (Result_Value * Double.Parse(result_text.Text)).ToString();
                    break;

                case "/":
                    result_text.Text = (Result_Value / Double.Parse(result_text.Text)).ToString();
                    break;

                default:
                    break;

            }
            Result_Value = Double.Parse(result_text.Text);
            prev_operation.Text = " ";
        }
    }
}