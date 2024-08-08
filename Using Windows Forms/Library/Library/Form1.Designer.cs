
namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddNewBook = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBook = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateNumberOfPages = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.DeleteBook = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ShowAllBook = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CRUD = new System.Windows.Forms.TabPage();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.sNumberofPages = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sAuthor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCrudEdit = new System.Windows.Forms.Button();
            this.btnCrudDelete = new System.Windows.Forms.Button();
            this.btnCrudAdd = new System.Windows.Forms.Button();
            this.btnCrudNew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddNewBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UpdateBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DeleteBook.SuspendLayout();
            this.ShowAllBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CRUD.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddNewBook);
            this.tabControl1.Controls.Add(this.UpdateBook);
            this.tabControl1.Controls.Add(this.DeleteBook);
            this.tabControl1.Controls.Add(this.ShowAllBook);
            this.tabControl1.Controls.Add(this.CRUD);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 415);
            this.tabControl1.TabIndex = 3;
            // 
            // AddNewBook
            // 
            this.AddNewBook.Controls.Add(this.btnCancel);
            this.AddNewBook.Controls.Add(this.btnAdd);
            this.AddNewBook.Controls.Add(this.groupBox1);
            this.AddNewBook.Location = new System.Drawing.Point(4, 22);
            this.AddNewBook.Name = "AddNewBook";
            this.AddNewBook.Padding = new System.Windows.Forms.Padding(3);
            this.AddNewBook.Size = new System.Drawing.Size(508, 389);
            this.AddNewBook.TabIndex = 0;
            this.AddNewBook.Text = "Add New Book";
            this.AddNewBook.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(355, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumberOfPages);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Book";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Publishing:";
            // 
            // txtNumberOfPages
            // 
            this.txtNumberOfPages.Location = new System.Drawing.Point(126, 155);
            this.txtNumberOfPages.Name = "txtNumberOfPages";
            this.txtNumberOfPages.Size = new System.Drawing.Size(234, 20);
            this.txtNumberOfPages.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Pages:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(126, 122);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(234, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(126, 89);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(234, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // UpdateBook
            // 
            this.UpdateBook.Controls.Add(this.btnShow);
            this.UpdateBook.Controls.Add(this.btnClose);
            this.UpdateBook.Controls.Add(this.btnUpdate);
            this.UpdateBook.Controls.Add(this.groupBox2);
            this.UpdateBook.Controls.Add(this.label11);
            this.UpdateBook.Controls.Add(this.txtUpdateID);
            this.UpdateBook.Location = new System.Drawing.Point(4, 22);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateBook.Size = new System.Drawing.Size(508, 389);
            this.UpdateBook.TabIndex = 2;
            this.UpdateBook.Text = "Update Book";
            this.UpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(350, 41);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(364, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUpdateNumberOfPages);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUpdateAuthor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUpdateTitle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(38, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books Details";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Publishing:";
            // 
            // txtUpdateNumberOfPages
            // 
            this.txtUpdateNumberOfPages.Location = new System.Drawing.Point(128, 114);
            this.txtUpdateNumberOfPages.Name = "txtUpdateNumberOfPages";
            this.txtUpdateNumberOfPages.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateNumberOfPages.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of Pages:";
            // 
            // txtUpdateAuthor
            // 
            this.txtUpdateAuthor.Location = new System.Drawing.Point(128, 81);
            this.txtUpdateAuthor.Name = "txtUpdateAuthor";
            this.txtUpdateAuthor.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateAuthor.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Book Author:";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(128, 48);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateTitle.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Book Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enter the  ID of Books:";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(166, 41);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateID.TabIndex = 1;
            // 
            // DeleteBook
            // 
            this.DeleteBook.Controls.Add(this.btnDelete);
            this.DeleteBook.Controls.Add(this.txtBookID);
            this.DeleteBook.Controls.Add(this.label10);
            this.DeleteBook.Location = new System.Drawing.Point(4, 22);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteBook.Size = new System.Drawing.Size(508, 389);
            this.DeleteBook.TabIndex = 1;
            this.DeleteBook.Text = "Delete Book";
            this.DeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(153, 137);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(218, 20);
            this.txtBookID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enter the Book ID:";
            // 
            // ShowAllBook
            // 
            this.ShowAllBook.Controls.Add(this.dataGridView1);
            this.ShowAllBook.Location = new System.Drawing.Point(4, 22);
            this.ShowAllBook.Name = "ShowAllBook";
            this.ShowAllBook.Padding = new System.Windows.Forms.Padding(3);
            this.ShowAllBook.Size = new System.Drawing.Size(508, 389);
            this.ShowAllBook.TabIndex = 3;
            this.ShowAllBook.Text = "Show Books";
            this.ShowAllBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.btnCrudEdit);
            this.CRUD.Controls.Add(this.btnLast);
            this.CRUD.Controls.Add(this.btnNext);
            this.CRUD.Controls.Add(this.btnCrudDelete);
            this.CRUD.Controls.Add(this.btnPrevious);
            this.CRUD.Controls.Add(this.btnFirst);
            this.CRUD.Controls.Add(this.btnCrudAdd);
            this.CRUD.Controls.Add(this.lblPageNumber);
            this.CRUD.Controls.Add(this.groupBox3);
            this.CRUD.Controls.Add(this.btnCrudNew);
            this.CRUD.Location = new System.Drawing.Point(4, 22);
            this.CRUD.Name = "CRUD";
            this.CRUD.Padding = new System.Windows.Forms.Padding(3);
            this.CRUD.Size = new System.Drawing.Size(508, 389);
            this.CRUD.TabIndex = 4;
            this.CRUD.Text = "CRUD Operation";
            this.CRUD.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(375, 341);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>||";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(284, 341);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(127, 341);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(36, 341);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "||<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(218, 341);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(50, 24);
            this.lblPageNumber.TabIndex = 2;
            this.lblPageNumber.Text = "1 / 3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.sNumberofPages);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.sAuthor);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.sTitle);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.sID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(36, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 242);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Book";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(126, 190);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Date of Publishing:";
            // 
            // sNumberofPages
            // 
            this.sNumberofPages.Location = new System.Drawing.Point(126, 155);
            this.sNumberofPages.Name = "sNumberofPages";
            this.sNumberofPages.Size = new System.Drawing.Size(234, 20);
            this.sNumberofPages.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Number of Pages:";
            // 
            // sAuthor
            // 
            this.sAuthor.Location = new System.Drawing.Point(126, 122);
            this.sAuthor.Name = "sAuthor";
            this.sAuthor.Size = new System.Drawing.Size(234, 20);
            this.sAuthor.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Book Author:";
            // 
            // sTitle
            // 
            this.sTitle.Location = new System.Drawing.Point(126, 89);
            this.sTitle.Name = "sTitle";
            this.sTitle.Size = new System.Drawing.Size(234, 20);
            this.sTitle.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Book Title:";
            // 
            // sID
            // 
            this.sID.Location = new System.Drawing.Point(126, 56);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(234, 20);
            this.sID.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Book ID:";
            // 
            // btnCrudEdit
            // 
            this.btnCrudEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudEdit.Location = new System.Drawing.Point(333, 282);
            this.btnCrudEdit.Name = "btnCrudEdit";
            this.btnCrudEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCrudEdit.TabIndex = 10;
            this.btnCrudEdit.Text = "Edit";
            this.btnCrudEdit.UseVisualStyleBackColor = true;
            this.btnCrudEdit.Click += new System.EventHandler(this.btnCrudEdit_Click);
            // 
            // btnCrudDelete
            // 
            this.btnCrudDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudDelete.Location = new System.Drawing.Point(243, 282);
            this.btnCrudDelete.Name = "btnCrudDelete";
            this.btnCrudDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCrudDelete.TabIndex = 9;
            this.btnCrudDelete.Text = "Delete";
            this.btnCrudDelete.UseVisualStyleBackColor = true;
            this.btnCrudDelete.Click += new System.EventHandler(this.btnCrudDelete_Click);
            // 
            // btnCrudAdd
            // 
            this.btnCrudAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudAdd.Location = new System.Drawing.Point(153, 282);
            this.btnCrudAdd.Name = "btnCrudAdd";
            this.btnCrudAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCrudAdd.TabIndex = 8;
            this.btnCrudAdd.Text = "Add";
            this.btnCrudAdd.UseVisualStyleBackColor = true;
            this.btnCrudAdd.Click += new System.EventHandler(this.btnCrudAdd_Click);
            // 
            // btnCrudNew
            // 
            this.btnCrudNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrudNew.Location = new System.Drawing.Point(63, 282);
            this.btnCrudNew.Name = "btnCrudNew";
            this.btnCrudNew.Size = new System.Drawing.Size(75, 23);
            this.btnCrudNew.TabIndex = 7;
            this.btnCrudNew.Text = "New";
            this.btnCrudNew.UseVisualStyleBackColor = true;
            this.btnCrudNew.Click += new System.EventHandler(this.btnCrudNew_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(516, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddNewBook.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UpdateBook.ResumeLayout(false);
            this.UpdateBook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DeleteBook.ResumeLayout(false);
            this.DeleteBook.PerformLayout();
            this.ShowAllBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CRUD.ResumeLayout(false);
            this.CRUD.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddNewBook;
        private System.Windows.Forms.TabPage DeleteBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage UpdateBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateNumberOfPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ShowAllBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage CRUD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sNumberofPages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sAuthor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCrudEdit;
        private System.Windows.Forms.Button btnCrudDelete;
        private System.Windows.Forms.Button btnCrudAdd;
        private System.Windows.Forms.Button btnCrudNew;
    }
}

