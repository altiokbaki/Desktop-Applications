using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne2Lab_1
{
    public partial class FormCalc : Form
    {
        Double result = 0.00;
        String operation = "";
        bool isOperation = false;
        public FormCalc()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            Applications app1 = new Applications();
            app1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperation))
                textBox_Result.Clear();
            isOperation = false;
            Button button = (Button)sender;
            button_Backcolor_Changeback();
            if (button != null)
            {
                button.BackColor = (button.BackColor == Color.Gray) ? Color.DarkOrange : Color.Gray;
            }
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "")
                textBox_Result.BackColor = Color.Red;
            else
            {
                if (Double.Parse(textBox_Result.Text) > 0)
                    textBox_Result.BackColor = Color.Green;
                else
                {
                    textBox_Result.BackColor = Color.Red;
                }
            }
        }

        private void operator_button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox_Result.Text);
            operationShow.Text = result + " " + operation;
            isOperation = true;
            button_Backcolor_Changeback();
            if (button != null)
            {
                button.BackColor = (button.BackColor == Color.Gray) ? Color.DarkOrange : Color.Gray;
            }
        }

        private void result_button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button_Backcolor_Changeback();
            if (button != null)
            {
                button.BackColor = (button.BackColor == Color.Gray) ? Color.DarkOrange : Color.Gray;
            }
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (result + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "x":
                    textBox_Result.Text = (result * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    if (textBox_Result.Text == "0")
                    {
                        operationShow.Text = "Cannot divide by zero";
                        break;
                    }
                    else
                    {
                        textBox_Result.Text = (result / Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    }
            }
        }

        private void clearentry_button_click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            Button button = (Button)sender;
            button_Backcolor_Changeback();
            if (button != null)
            {
                button.BackColor = (button.BackColor == Color.Gray) ? Color.DarkOrange : Color.Gray;
            }
        }

        private void clear_button_entry(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
            operationShow.Text = "";
            Button button = (Button)sender;
            button_Backcolor_Changeback();
            if (button != null)
            {
                button.BackColor = (button.BackColor == Color.Gray) ? Color.DarkOrange : Color.Gray;
            }
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            Button buttonhover = (Button)sender;
            buttonhover.ForeColor = Color.Red;
        }
        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            Button buttonhover = (Button)sender;
            buttonhover.ForeColor = System.Drawing.Color.Black;
        }
        void button_Backcolor_Changeback()
        {
            btn1.BackColor = Color.Gray;
            btn2.BackColor = Color.Gray;
            btn3.BackColor = Color.Gray;
            btn4.BackColor = Color.Gray;
            btn5.BackColor = Color.Gray;
            btn6.BackColor = Color.Gray;
            btn7.BackColor = Color.Gray;
            btn8.BackColor = Color.Gray;
            btn9.BackColor = Color.Gray;
            btn0.BackColor = Color.Gray;
            btnAddition.BackColor = Color.Gray;
            btnClear.BackColor = Color.Gray;
            btnDivision.BackColor = Color.Gray;
            btnEqual.BackColor = Color.Gray;
            btnMultiplication.BackColor = Color.Gray;
            btnSubstraction.BackColor = Color.Gray;
            btnClearEntry.BackColor = Color.Gray;
        }

        private void FormCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Applications appCalcClosed = new Applications();
            appCalcClosed.Show();
            this.Hide();
        }
    }
}
