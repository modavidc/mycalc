using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Calc : Form
    {
        private double number1;
        private double number2;
        private String operation;

        public Calc()
        {
            InitializeComponent();
        }
        
        private void MouseHover(object sender, EventArgs e)
        {
        }

        private void Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void InputNumber(object sender, EventArgs e)
        {
            String value = ((Button)sender).Text;

            if(label2.Text == "0")
            {
                label2.Text = "";
            }
            label2.Text += value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear(object sender, EventArgs e)
        {
            label2.Text = 0.ToString();
        }

        private void Sum(object sender, EventArgs e)
        {
            this.operation = ((Button)sender).Text;

            this.UpdateLabelResult();
        }

        private void UpdateLabelResult()
        {
            this.label1.Text = this.number1.ToString() + " " + this.operation;
        }
        
        private void Calculate(object sender, EventArgs e)
        {
            this.number1 = Convert.ToDouble(label2.Text);

            Console.WriteLine(this.number1 + " " + this.operation);
        }
    }
}
