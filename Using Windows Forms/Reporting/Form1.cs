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

namespace Reporting
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=.\SQLEXPESS;Database=Emloyees;Integrated Security=true;");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("Select * From tbl_employees", cn);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Dt.Clear();
            Da = new SqlDataAdapter("Select * From tbl_employees Where convert(varchar,ID)+Fullname+Address+Job+Convert(varchar,age) Like '%"+textBox1.Text+"%'", cn);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReportForm frm = new ReportForm();
                        Da = new SqlDataAdapter("Select * From tbl_employees", cn);
            Da.Fill(frm.EmloyeesDataSet.tbl_employees);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            Da = new SqlDataAdapter("Select * From tbl_employees Where ID ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            Da.Fill(frm.EmloyeesDataSet.tbl_employees);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchResult frm = new frmSearchResult();
            Da = new SqlDataAdapter("Select * From tbl_employees Where convert(varchar,ID)+Fullname+Address+Job+Convert(varchar,age) Like '%" + textBox1.Text + "%'", cn);
            Da.Fill(frm.EmloyeesDataSet.tbl_employees);
            frm.reportViewer1.RefreshReport();
            frm.Show();
        }
    }
}
