using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorr
{
    public partial class Form1 : Form
    {
        bool operation = false;
        double result = 0;
        string operation1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void NumResult(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || operation)
            {
                textBox.Clear();
            }

            operation = false;
            Button btn = (Button)sender;
            textBox.Text += btn.Text;
        }

        private void Operations(object sender, EventArgs e)
        {
            operation = true;
            Button btn = (Button)sender;
            string newOp = btn.Text;

            lb.Text = lb.Text + " " + textBox.Text + " " + newOp;
            switch (operation1)
            {
                case "+": textBox.Text = (result + Double.Parse(textBox.Text)).ToString(); break;
                case "-": textBox.Text = (result - Double.Parse(textBox.Text)).ToString(); break;
                case "*": textBox.Text = (result * Double.Parse(textBox.Text)).ToString(); break;
                case "/": textBox.Text = (result / Double.Parse(textBox.Text)).ToString(); break;

            }
            result = Double.Parse(textBox.Text);
            textBox.Text = result.ToString();
            operation1 = newOp;
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            string Operation;
            result = Double.Parse(textBox.Text);
            Operation = "x";

            if (Operation == "x")
            {
                result = Math.Sqrt(result);
                textBox.Text = result.ToString();

            }
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void MemoryResult(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;
            decimal MemoryStore = 0;
            decimal EndResult = 0;

            if (ButtonText == "M+")
            {
                // Memory add 

                MemoryStore += EndResult;
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                MemoryStore -= EndResult;
                textBox.Text = MemoryStore.ToString();
                return;
            }

            if (ButtonText == "MR")
            {
                //Memory Recall
                textBox.Text = MemoryStore.ToString();
                return;
            }

            if (ButtonText == "MC")
            {
                //Memory Clear
                lb.Text = "0";
                MemoryStore = 0;
                return;
            }
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            lb.Text = "";

            switch (operation1)
            {
                case "+": textBox.Text = (result + Double.Parse(textBox.Text)).ToString(); break;
                case "-": textBox.Text = (result - Double.Parse(textBox.Text)).ToString(); break;
                case "*": textBox.Text = (result * Double.Parse(textBox.Text)).ToString(); break;
                case "/": textBox.Text = (result / Double.Parse(textBox.Text)).ToString(); break;

            }
            result = Double.Parse(textBox.Text);
            textBox.Text = result.ToString();
            operation1 = " ";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            lb.Text = "";
            operation1 = "";
            result = 0;
            operation = false;
        }
    }
}
    

