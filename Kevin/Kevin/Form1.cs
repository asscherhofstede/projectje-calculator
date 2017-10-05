using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin
{
    public partial class Form1 : Form
    {
        double Value = 0;
        string operation = "";
        bool Operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((TextBoxResult.Text == "0")||Operation_pressed)
            {
                TextBoxResult.Clear();
            }
            Operation_pressed = false;
            Button BN = (Button)sender;
            
            
            TextBoxResult.Text = TextBoxResult.Text + BN.Text;
        }

        private void buttonClearEverything_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button BN = (Button)sender;
            operation = BN.Text;
            Value = double.Parse(TextBoxResult.Text);
            Operation_pressed = true;
            EquationLabel.Text = Value + " " + operation;

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
           
            EquationLabel.Text = "";
            switch(operation)
            {
                case "+":
                    TextBoxResult.Text = (Value + double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "-":
                    TextBoxResult.Text = (Value - double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "/":
                    TextBoxResult.Text = (Value / double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "*":
                    TextBoxResult.Text = (Value * double.Parse(TextBoxResult.Text)).ToString();
                    break;
                default:
                    break;
                    //end switch
                    
            }

            
                   
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxResult.Clear();
            Value = 0;
        }
    }
}
