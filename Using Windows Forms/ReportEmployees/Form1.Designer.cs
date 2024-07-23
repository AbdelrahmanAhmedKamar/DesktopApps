namespace ReportEmployees
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDataSet = new ReportEmployees.CompanyDataSet();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMangement = new System.Windows.Forms.ComboBox();
            this.lblMangement = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.txtGoverorate = new System.Windows.Forms.ComboBox();
            this.lblGoverorate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employeesTableAdapter = new ReportEmployees.CompanyDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.companyDataSet;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(1043, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 43);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Text = "تسجيل";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMangement
            // 
            this.txtMangement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMangement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMangement.FormattingEnabled = true;
            this.txtMangement.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3"});
            this.txtMangement.Location = new System.Drawing.Point(331, 144);
            this.txtMangement.Name = "txtMangement";
            this.txtMangement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMangement.Size = new System.Drawing.Size(307, 33);
            this.txtMangement.TabIndex = 43;
            // 
            // lblMangement
            // 
            this.lblMangement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMangement.AutoSize = true;
            this.lblMangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangement.Location = new System.Drawing.Point(644, 147);
            this.lblMangement.Name = "lblMangement";
            this.lblMangement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMangement.Size = new System.Drawing.Size(60, 25);
            this.lblMangement.TabIndex = 42;
            this.lblMangement.Text = "الإدارة:";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlySalary.Location = new System.Drawing.Point(490, 96);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonthlySalary.Size = new System.Drawing.Size(148, 30);
            this.txtMonthlySalary.TabIndex = 41;
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySalary.Location = new System.Drawing.Point(644, 99);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMonthlySalary.Size = new System.Drawing.Size(109, 25);
            this.lblMonthlySalary.TabIndex = 40;
            this.lblMonthlySalary.Text = "الأجر الشهري:";
            // 
            // txtGoverorate
            // 
            this.txtGoverorate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoverorate.DropDownHeight = 200;
            this.txtGoverorate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGoverorate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoverorate.FormattingEnabled = true;
            this.txtGoverorate.IntegralHeight = false;
            this.txtGoverorate.ItemHeight = 25;
            this.txtGoverorate.Items.AddRange(new object[] {
            "أسوان",
            "أسيوط",
            "الإسكندرية",
            "الإسماعيلية",
            "الأقصر",
            "البحر الأحمر",
            "البحيرة",
            "الجيزة",
            "الدقهلية",
            "السويس",
            "الشرقية",
            "الغربية",
            "الفيوم",
            "القاهرة",
            "القليوبية",
            "المنوفية",
            "المنيا",
            "الوادي الجديد",
            "بني سويف",
            "بورسعيد",
            "جنوب سيناء",
            "دمياط ",
            "سوهاج",
            "شمال سيناء",
            "قنا",
            "كفر الشيخ",
            "مطروح"});
            this.txtGoverorate.Location = new System.Drawing.Point(872, 246);
            this.txtGoverorate.Name = "txtGoverorate";
            this.txtGoverorate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoverorate.Size = new System.Drawing.Size(307, 33);
            this.txtGoverorate.Sorted = true;
            this.txtGoverorate.TabIndex = 39;
            // 
            // lblGoverorate
            // 
            this.lblGoverorate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoverorate.AutoSize = true;
            this.lblGoverorate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoverorate.Location = new System.Drawing.Point(1185, 249);
            this.lblGoverorate.Name = "lblGoverorate";
            this.lblGoverorate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoverorate.Size = new System.Drawing.Size(75, 25);
            this.lblGoverorate.TabIndex = 38;
            this.lblGoverorate.Text = "المحافظة:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(872, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(307, 30);
            this.txtAddress.TabIndex = 37;
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(1185, 194);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdress.Size = new System.Drawing.Size(67, 25);
            this.lblAdress.TabIndex = 36;
            this.lblAdress.Text = "العنوان :";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(872, 144);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(307, 30);
            this.txtEmployeeName.TabIndex = 35;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(1185, 147);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployeeName.Size = new System.Drawing.Size(97, 25);
            this.lblEmployeeName.TabIndex = 34;
            this.lblEmployeeName.Text = "اسم الموظف:";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(1031, 99);
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCode.Size = new System.Drawing.Size(148, 30);
            this.txtCode.TabIndex = 33;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(1185, 102);
            this.lblCode.Name = "lblCode";
            this.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCode.Size = new System.Drawing.Size(86, 25);
            this.lblCode.TabIndex = 32;
            this.lblCode.Text = "رقم كودي :";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1053, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "تسجيل الموظفين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1290, 93);
            this.panel1.TabIndex = 31;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(872, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 43);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "استعادة";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportEmployees.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 349);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1290, 336);
            this.reportViewer1.TabIndex = 46;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 685);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtMangement);
            this.Controls.Add(this.lblMangement);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.lblMonthlySalary);
            this.Controls.Add(this.txtGoverorate);
            this.Controls.Add(this.lblGoverorate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox txtMangement;
        private System.Windows.Forms.Label lblMangement;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.ComboBox txtGoverorate;
        private System.Windows.Forms.Label lblGoverorate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private CompanyDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}

