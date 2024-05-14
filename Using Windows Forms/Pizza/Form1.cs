using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                
                return Convert.ToSingle(rbSmall.Tag);
            
            else if (rbMedium.Checked)
            
                return Convert.ToSingle(rbMedium.Tag);
            
            else
            
                return Convert.ToSingle(rbLarge.Tag);
            
        }

        float CalculateToppingPrice() 
        {
            float toppingPrice = 0;

            if (chkExtraCheese.Checked) 
            {
                toppingPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }


            if (chkOnion.Checked)
            {
                toppingPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                toppingPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                toppingPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                toppingPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkTomatoes.Checked)
            {
                toppingPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return toppingPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)

                return Convert.ToSingle(rbThin.Tag);

            else

                return Convert.ToSingle(rbThick.Tag);

        }

        float CaculateTotalPrice() 
        {
            return GetSelectedCrustPrice() + CalculateToppingPrice() + GetSelectedSizePrice();
        }

        void UpdateTotalPrice() 
        {
            lbPrice.Text = "$" + CaculateTotalPrice().ToString();
        }

        void UpdateOrderSummary() 
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }


        void UpdateToppings() 
        {
            UpdateTotalPrice();

            string sToppings = "";

            if(chkExtraCheese.Checked) 
            {
                sToppings += "Extra Cheese";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked) 
            {
                sToppings += ", Olives";

            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", GreenPeppers";

            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";

            }

            if (sToppings == "") 
            {
                sToppings = "No Toppings";
            }

            if (sToppings.StartsWith(",")) 
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            lbTopping.Text = sToppings;
        }

        void UpdateSize() 
        {
            UpdateTotalPrice();

            if(rbSmall.Checked) 
            {
                lbSize.Text = "Samll";
                return;
            }

            if (rbMedium.Checked) 
            {
                lbSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lbSize.Text = "Large";
                return ;
            }
        }

        void UpdateCrust() 
        {
            UpdateTotalPrice();

            if (rbThin.Checked) 
            {
                lbCrustType.Text= "Thin Crust";
                return;
            }

            if (rbThick.Checked)
            {
                lbCrustType.Text = "Thick Crust";
                return;
            }


        }

        void UpdateWhereToEat() 
        {
            if(rbEatIn.Checked) 
            {
                lbWhereToEat.Text = "Eat In";
                return;
            }

            if(rbTakeAway.Checked)
            {
                lbWhereToEat.Text = "Take Away";
                return;
            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust() ;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize() ;
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            btnOrderPizza.Enabled = true;
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbEatIn.Checked = true;
            rbMedium.Checked = true;
            rbThin.Checked = true;

            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            chkTomatoes.Checked = false;

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Order Confirm", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbTopping.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
