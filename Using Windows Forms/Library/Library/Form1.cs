﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=.\SQLEXPESS;Database=LibraryDB;Integrated Security=true;");

        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Delete From Books_Table Where ID='" + txtBookID.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Sucessfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Insert into Books_Table(ID,Title,Author,Publish_Date,Pages_Number) Values('" + txtID.Text + "','" + txtTitle.Text + "','" + txtAuthor.Text + "','" + dateTimePicker1.Value + "'," + txtNumberOfPages.Text + ")", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select Title,Author,Pages_Number,Publish_Date From Books_Table Where ID='" + txtUpdateID.Text + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                txtUpdateTitle.Text = dr["Title"].ToString();
                txtUpdateAuthor.Text = dr["Author"].ToString();
                txtUpdateNumberOfPages.Text = dr["Pages_Number"].ToString();
                dateTimePicker2.Text = dr["Publish_Date"].ToString();
                this.Size=new Size(this.Width, 454);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                cmd = new SqlCommand("Update Books_Table Set Title='" + txtUpdateID.Text + "',Author='" + txtUpdateAuthor.Text + "',Publish_Date='" + dateTimePicker2.Value + "',Pages_Number=" + txtUpdateNumberOfPages.Text + "Where ID='" + txtUpdateID.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, 160);
        }
    }
}
