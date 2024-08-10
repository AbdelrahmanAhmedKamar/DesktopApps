using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsingXml
{

    public partial class Form1 : Form
    {
        DataSet Ds = new DataSet();
        public Form1()
        {

            InitializeComponent();
            Ds.ReadXml("myFile.xml");
            dataGridView1.DataSource = Ds.Tables[0];
            Ds.Tables[0].TableName="Books";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow r = Ds.Tables[0].NewRow();
            r[0] = txtID.Text;
            r[1] = txtTitle.Text;

            r[2] = txtAuthor.Text;
            r[3] = txtNumberOfPages.Text;

            r[4] = dtPublishDate.Value;

            Ds.Tables[0].Rows.Add(r);
            Ds.WriteXml("myFile.xml");
            MessageBox.Show("Added Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNumberOfPages.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtPublishDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Ds.Tables[0].Rows.Count ; i++) 
            {
                if (txtID.Text == Ds.Tables[0].Rows[i]["ID"].ToString()) 
                {
                    Ds.Tables[0].Rows[i].Delete();
                    Ds.WriteXml("myFile.xml");
                    MessageBox.Show("Deleted Successfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ds.Tables["Books"].Rows.Count; i++)
            {
                if (txtID.Text == Ds.Tables["Books"].Rows[i]["ID"].ToString())
                {
                    DataRow r = Ds.Tables["Books"].Rows[i];
                    r["ID"] = txtID.Text;
                    r["Title"] = txtTitle.Text;
                    r["Author"] = txtAuthor.Text;
                    r["Pages_Number"] = txtNumberOfPages.Text;
                    r["Publish_Date"] = dtPublishDate.Value;

                    Ds.WriteXml("myFile.xml");
                    MessageBox.Show("Updated Successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
