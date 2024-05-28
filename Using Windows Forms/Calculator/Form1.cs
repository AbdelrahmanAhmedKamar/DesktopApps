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
        public Form1()
        {
            InitializeComponent();
        }

        float _LastNumber = 0;
        float _Result = 0;
        char _LastOperation = '\0';


        void ShowNumber(Button btn) 
        {
            txtStore.Text += btn.Text.ToString();

        }

        private void btn_Click(object sender, MouseEventArgs e)
        {
            ShowNumber((Button)sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStore.Clear();
            txtResult.Clear();
            _LastNumber = 0;
            _Result = 0;
            _LastOperation = '\0';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStore.Text != "") 
            {
                _LastNumber = Convert.ToSingle(txtStore.Text);
                txtResult.Text = txtStore.Text + " + ";
                txtStore.Clear();
                _LastOperation = '+';
            }


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            if (txtStore.Text != "")
            {
                _LastNumber = Convert.ToSingle(txtStore.Text);
                txtResult.Text = txtStore.Text + " - ";
                txtStore.Clear();
                _LastOperation = '-';
            }else
                txtStore.Text = "-";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtStore.Text != "")
            {
                _LastNumber = Convert.ToSingle(txtStore.Text);
                txtResult.Text = txtStore.Text + " × ";
                txtStore.Clear();
                _LastOperation = '×';
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtStore.Text != "")
            {
                _LastNumber = Convert.ToSingle(txtStore.Text);
                txtResult.Text = txtStore.Text + " ÷ ";
                txtStore.Clear();
                _LastOperation = '÷';
            }
        }

        void CalculateResult()
        {
            if (txtStore.Text != "") 
            {
                switch (_LastOperation)
                {
                    case '+':
                        _Result = _LastNumber + Convert.ToSingle(txtStore.Text);
                        txtResult.Text = txtResult.Text + txtStore.Text + " = " + _Result;
                        txtStore.Text = _Result.ToString();
                        break;

                    case '-':
                        _Result = _LastNumber - Convert.ToSingle(txtStore.Text);
                        txtResult.Text = txtResult.Text + txtStore.Text + " = " + _Result;
                        txtStore.Text = _Result.ToString();
                        break;

                    case '×':
                        _Result = _LastNumber * Convert.ToSingle(txtStore.Text);
                        txtResult.Text = txtResult.Text + txtStore.Text + " = " + _Result;
                        txtStore.Text = _Result.ToString();
                        break;

                    case '÷':
                        _Result = _LastNumber / Convert.ToSingle(txtStore.Text);
                        txtResult.Text = txtResult.Text + txtStore.Text + " = " + _Result;
                        txtStore.Text = _Result.ToString();
                        break;

                    default:
                        break;
                }
            }
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculateResult();
            _LastOperation = '\0';
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtStore.Text != "") 
            {
                txtStore.Text = txtStore.Text.Substring(0, txtStore.Text.Length - 1);
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtStore.Text = (Convert.ToSingle(txtStore.Text) / 100).ToString();
        }
    }
}
