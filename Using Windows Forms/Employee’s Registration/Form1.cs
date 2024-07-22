using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_s_Registration
{
    public partial class Form1 : Form
    {

        SqlConnection cn=new SqlConnection(@"Server=.\; DataBase=Company; Integrated Security=true;");
       
        SqlCommand cmd;

        SqlDataAdapter DataAdapter;
        DataTable dt=new DataTable();


        public Form1()
        {
            InitializeComponent();
            DataAdapter = new SqlDataAdapter("Select * From Employees", cn);
            DataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                cmd = new SqlCommand("Insert Into Employees(ID,Name,Address,Governorate,Monthly_Salary,Mangement)" +
               " Values (" + txtCode.Text + ",'" + txtEmployeeName.Text + "','" + txtAddress.Text + "','" + txtGoverorate.Text + "'," + txtMonthlySalary.Text + ",'" + txtMangement.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Some Error was occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally 
            {
                cn.Close();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
