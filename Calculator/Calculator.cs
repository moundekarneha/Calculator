using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double num1, num2=0;
        string operation="";
        bool checkOpeartion = false, checkDisplay = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                txtResult.Text = txtResult.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
            txtResult.Text = txtResult.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || checkOpeartion == true)
            { txtResult.Clear(); checkOpeartion = false; checkDisplay = true; }
                if (txtResult.Text.Contains("."))
                txtResult.Text = txtResult.Text + "";
            else
                txtResult.Text = txtResult.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text);
            Button button = (Button)sender;
            operation = button.Text;
            lblCurrentOperation.Text = num1.ToString() + " " + operation;
            checkOpeartion = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text);
            Button button = (Button)sender;
            operation = button.Text;
            lblCurrentOperation.Text = num1.ToString() + " " + operation;
            checkOpeartion = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text);
            Button button = (Button)sender;
            operation = button.Text;
            lblCurrentOperation.Text = num1.ToString() + " " + operation;
            checkOpeartion = true;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtResult.Text);
            Button button = (Button)sender;
            operation = button.Text;
            lblCurrentOperation.Text = num1.ToString() + " " + operation;
            checkOpeartion = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    num2=double.Parse(txtResult.Text); 
                    if (checkDisplay == true)
                    {
                        txtResult.Text = (num1 + num2).ToString();
                        lblCurrentOperation.Text = lblCurrentOperation.Text + " " + num2.ToString() + " = " + txtResult.Text;
                    }
                    checkDisplay = false;
                    break;
                case "-":
                    num2 = double.Parse(txtResult.Text);
                    if (checkDisplay==true)
                    {
                        txtResult.Text = (num1 - num2).ToString();
                        lblCurrentOperation.Text = lblCurrentOperation.Text + " " + num2.ToString() + " = " + txtResult.Text;
                    }
                    checkDisplay = false;
                    break;
                case "*":
                    num2 = double.Parse(txtResult.Text);
                    if (checkDisplay == true)
                    {
                        txtResult.Text = (num1 * num2).ToString();
                        lblCurrentOperation.Text = lblCurrentOperation.Text + " " + num2.ToString() + " = " + txtResult.Text;
                    }
                    checkDisplay = false;
                    break;
                case "/":
                    num2 = double.Parse(txtResult.Text);
                    if (checkDisplay == true)
                    {
                        txtResult.Text = (num1 / num2).ToString();
                        lblCurrentOperation.Text = lblCurrentOperation.Text + " " + num2.ToString() + " = " + txtResult.Text;
                    }
                    checkDisplay = false;
                    break;
                default:
                    break;
            }
              
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text="0";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text="0";
            lblCurrentOperation.Text = "";
        }
    }
}
