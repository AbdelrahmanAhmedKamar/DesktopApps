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

namespace Stored_Procedures
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=.\SQLEXPESS;Database=LibraryDB;Integrated Security=true;");
        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();

        void LoadAllRecord() 
        {
            Dt.Clear();
            Cmd = new SqlCommand("SelectBooks", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            this.dataGridView1.DataSource = Dt;
        }
        public Form1()
        {
            InitializeComponent();
            LoadAllRecord();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("InsertBook", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];

            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = txtID.Text;

            Param[1] = new SqlParameter("@Title", SqlDbType.VarChar, 75);
            Param[1].Value = txtTitle.Text;

            Param[2] = new SqlParameter("@Author", SqlDbType.VarChar, 100);
            Param[2].Value = txtAuthor.Text;

            Param[3] = new SqlParameter("@Pages_Number", SqlDbType.Int);
            Param[3].Value = txtNumberOfPages.Text;

            Param[4] = new SqlParameter("@Publish_Date", SqlDbType.DateTime);
            Param[4].Value = dtPublishDate.Text;

            Cmd.Parameters.AddRange(Param);

            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Added Sucessfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllRecord();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("DeleteBook", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter Param = new SqlParameter();

            Param = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param.Value = txtID.Text;

            Cmd.Parameters.Add(Param);

            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Deleted Sucessfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllRecord();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
            txtNumberOfPages.Text = dataGridView1.CurrentRow.Cells["Pages_Number"].Value.ToString();
            dtPublishDate.Text = dataGridView1.CurrentRow.Cells["Publish_Date"].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtNumberOfPages.Clear();
            dtPublishDate.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("UpdateBook", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];

            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = txtID.Text;

            Param[1] = new SqlParameter("@Title", SqlDbType.VarChar, 75);
            Param[1].Value = txtTitle.Text;

            Param[2] = new SqlParameter("@Author", SqlDbType.VarChar, 100);
            Param[2].Value = txtAuthor.Text;

            Param[3] = new SqlParameter("@Pages_Number", SqlDbType.Int);
            Param[3].Value = txtNumberOfPages.Text;

            Param[4] = new SqlParameter("@Publish_Date", SqlDbType.DateTime);
            Param[4].Value = dtPublishDate.Text;

            Cmd.Parameters.AddRange(Param);

            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Updated Sucessfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllRecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
