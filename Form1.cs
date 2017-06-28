//=============================================================
//   Jean Zambrano
//   CIST
//   Area Program application
//  
//=============================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//============================= SIMPLE CALCULATOR APPLICATION ================================
namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //============================= VARIABLES ================================
        String memory = "0";
        Double resultValue = 0;
        String answer1;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //============================= BUTTON (NUMBER) CLICK EVENT ================================
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        //============================= OPERATOR (OPERATOR) CLICK EVENT ================================
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            label1.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        //============================= EQUAL SIGN CLICK EVENT ================================
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //============================= CLEAR BUTTON CLICK EVENT ================================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            label1 = null;
        }

        //============================= FOR LOOP CLICK EVENT ================================
        private void Forloop_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Go Falcons");
                textBox1.Text = "Go Falcons";
            }

            Console.Read();

        }

        //============================= WHILE LOOP CLICK EVENT ================================
        private void Whileloop_Click(object sender, EventArgs e)
        {
            int i = 1; // Declare and set value
            while( i <= 10)
            {
                Console.WriteLine("Go Falcons!");
                textBox1.Text = "Go Falcons";
                i++;
            }
            Console.Read();
        }

        //============================= M CLICK EVENT ================================
        private void M_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        //============================= M+ CLICK EVENT ================================
        private void Mplusbutton_Click(object sender, EventArgs e)
        {
            memory = label2.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //============================= LABEL2 HOVER EVENT ================================
        private void label2_MouseHover(object sender, System.EventArgs e)
        {
            label2.Visible = !label2.Visible;
        }
    }
}