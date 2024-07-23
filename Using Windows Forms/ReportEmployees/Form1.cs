using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReportEmployees
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=.\; DataBase=Company; Integrated Security=true;");

        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.companyDataSet.Employees);
            this.reportViewer1.RefreshReport();
        }

        private bool ValidateCodeNumber()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                errorProvider1.SetError(txtCode, "!يجب ادخال رقم كودي");
                return false;

            }
            else
            {
                foreach (char c in txtCode.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(txtCode, "!يجب ان يحتوي علي ارقام فقط");
                        return false;
                    }
                }
            }

            errorProvider1.SetError(txtCode, "");

           return true;


        }

        private bool ValidateEmployeeName()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                errorProvider1.SetError(txtEmployeeName, "!يجب ادخال اسم الموظف");
                return false;
            }
            else 
            {
                foreach (char c in txtEmployeeName.Text)
                {
                    // Skip whitespace characters
                    if (char.IsWhiteSpace(c))
                    {
                        continue;
                    }

                    if (!char.IsLetter(c))
                    {
                        errorProvider1.SetError(txtEmployeeName, "!يجب ان يحتوي علي احرف فقط");
                        return false;
                    }
                }
            }

            errorProvider1.SetError(txtEmployeeName, "");
            return true;

        }

        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "!يجب ادخال العنوان");
                return false;

            }

            errorProvider1.SetError(txtAddress, "");

            return true;

        }
      
        private bool ValidateGoverorate() 
        {
            if (string.IsNullOrWhiteSpace(txtGoverorate.Text))
            {
                errorProvider1.SetError(txtGoverorate, "!يجب ادخال المحافظة");
                return false;

            }

            errorProvider1.SetError(txtGoverorate, "");

            return true;
        }

        private bool ValidateMonthlySalary()
        {
            if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text))
            {
                errorProvider1.SetError(txtMonthlySalary, "!يجب ادخال الاجر الشهري");
                return false;

            }
            else
            {
                foreach (char c in txtMonthlySalary.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        errorProvider1.SetError(txtMonthlySalary, "!يجب ان يحتوي علي ارقام فقط");
                        return false;
                    }
                }
            }

            errorProvider1.SetError(txtMonthlySalary, "");
            return true;
        }

        private bool ValidateMangement()
        {
            if (string.IsNullOrWhiteSpace(txtMangement.Text))
            {
                errorProvider1.SetError(txtMangement, "!يجب ادخال الإدارة");
                return false;

            }

            errorProvider1.SetError(txtMangement, "");
            return true;
        }

        private bool ValidationFields()
        {
            bool isValid = true;

            if (!ValidateCodeNumber())
                isValid = false;

            if (!ValidateEmployeeName())
                isValid = false;

            if (!ValidateAddress())
                isValid = false;


            if (!ValidateGoverorate())
                isValid = false;

            if (!ValidateMonthlySalary())
                isValid = false;

            if (!ValidateMangement())
                isValid = false;

            return isValid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (ValidationFields()) 
            {
                try
                {
                    cmd = new SqlCommand("Insert Into Employees(ID,Name,Address,Governorate,Monthly_Salary,Mangement)" +
                   " Values (" + txtCode.Text + ",'" + txtEmployeeName.Text + "','" + txtAddress.Text + "','" + txtGoverorate.Text + "'," + txtMonthlySalary.Text + ",'" + txtMangement.Text + "')", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("!تمت الاضافة بنجاح", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.employeesTableAdapter.Fill(this.companyDataSet.Employees);
                    this.reportViewer1.RefreshReport();
                }
                catch
                {
                    MessageBox.Show("!الرقم الكودي مستخدم بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtGoverorate.SelectedIndex = -1;
            txtMonthlySalary.Text = "";
            txtMangement.SelectedIndex = -1;

            errorProvider1.SetError(txtCode, "");
            errorProvider1.SetError(txtEmployeeName, "");
            errorProvider1.SetError(txtAddress, "");
            errorProvider1.SetError(txtGoverorate, "");
            errorProvider1.SetError(txtMonthlySalary, "");
            errorProvider1.SetError(txtMangement, "");
        }
    }
}
