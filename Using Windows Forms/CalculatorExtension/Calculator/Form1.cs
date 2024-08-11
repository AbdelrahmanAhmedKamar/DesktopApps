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
    public partial class Form1 : Form
    {
        private float _FirstName = 0;
        private float _LastName = 0;
        private float _Result = 0;
        private char _LastOperation= '\0';
        private bool _OpClick = false;
        private bool _IsEqual = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (_OpClick)
                txtResult.Text = "";

            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
            txtResult.Text += ((Button)sender).Text;

            _LastName = Convert.ToSingle(txtResult.Text);
            _OpClick = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
                txtResult.Text += ((Button)sender).Text.ToString();
            else
                return;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtStore.Clear();
            txtResult.Text = "0";
            _LastName = 0;
            _Result = 0;
            _FirstName = 0;
            _LastOperation = '\0';
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == _Result.ToString()) 
            {
                txtStore.Text = "";
                return;
            }

            if (txtResult.Text != "")
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }

            if (txtResult.Text == "")
                txtResult.Text = "0";
            
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtStore.Text = "√" + txtResult.Text;
            txtResult.Text = Math.Sqrt(Convert.ToSingle(txtResult.Text)).ToString();
            _Result = Convert.ToSingle(txtResult.Text);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            txtStore.Text = "1/" + txtResult.Text;
            txtResult.Text = (1/Convert.ToSingle(txtResult.Text)).ToString();
            _Result = Convert.ToSingle(txtResult.Text);

        }

        private void btnPowerOf2_Click(object sender, EventArgs e)
        {
            txtStore.Text = txtResult.Text + "²";
            txtResult.Text = Math.Pow(Convert.ToSingle(txtResult.Text),2).ToString();
            _Result = Convert.ToSingle(txtResult.Text);
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToSingle(txtResult.Text) * -1).ToString();
            _Result = Convert.ToSingle(txtResult.Text);

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            _Result = 0;

            if (_IsEqual) 
            {
                txtStore.Clear();
                txtResult.Text = "0";
                _LastName = 0;
                _Result = 0;
                _FirstName = 0;
                _LastOperation = '\0';
            }

        }

        private void btnPrecent_Click(object sender, EventArgs e)
        {
            txtStore.Text = txtResult.Text + " %";
            txtResult.Text = (Convert.ToSingle(txtResult.Text)/100).ToString();
            _Result = Convert.ToSingle(txtResult.Text);
        }

        void Calculate(char Op)
        {

            switch (Op)
            {
                case '+':

                    _Result = _LastName + _FirstName;
                    break;

                case '-':
                    _Result = _FirstName - _LastName;

                    break;

                case '×':
                    _Result = _LastName * _FirstName;

                    break;

                case '÷':
                    if (_FirstName == 0)
                        _Result = 0;
                    else
                        _Result = _FirstName / _LastName;
                    break;


                case '%':
                    _Result = _LastName / 100;
                    break;

                default:
                    break;

            }

        }

        void CheckResult()
        {

            if (txtResult.Text != _Result.ToString() && _Result != 0)
            {
                Calculate(_LastOperation);
                txtStore.Text = _Result.ToString() + " " + _LastOperation + " ";
                txtResult.Text = _Result.ToString();

            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            _OpClick = true;
            _LastOperation = Convert.ToChar(((Button)sender).Text);

            CheckResult();

            _FirstName = Convert.ToSingle(txtResult.Text);


            txtStore.Text = txtResult.Text + " " + _LastOperation + " ";

            _IsEqual = false;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate(_LastOperation);


            txtStore.Text = _FirstName.ToString() + " " + _LastOperation + " " + _LastName.ToString() + " = ";
            txtResult.Text = _Result.ToString();
            _FirstName = _Result;
            _IsEqual = true;
        }


    }
}
