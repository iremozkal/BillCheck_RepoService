namespace BillCheck_RepoService.UI
{
	partial class FormPersonel
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
            this.lbxEmployeeList = new System.Windows.Forms.ListBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.gbxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxEmployeeList
            // 
            this.lbxEmployeeList.FormattingEnabled = true;
            this.lbxEmployeeList.ItemHeight = 16;
            this.lbxEmployeeList.Location = new System.Drawing.Point(49, 46);
            this.lbxEmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxEmployeeList.Name = "lbxEmployeeList";
            this.lbxEmployeeList.Size = new System.Drawing.Size(845, 228);
            this.lbxEmployeeList.TabIndex = 0;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(161, 33);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(243, 22);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(161, 78);
            this.txtEmployeeSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(243, 22);
            this.txtEmployeeSalary.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(565, 311);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(244, 28);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(565, 354);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(244, 28);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(565, 399);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(244, 28);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(20, 37);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(111, 17);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(20, 78);
            this.lblEmployeeSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(114, 17);
            this.lblEmployeeSalary.TabIndex = 7;
            this.lblEmployeeSalary.Text = "Employee Salary";
            // 
            // gbxInput
            // 
            this.gbxInput.Controls.Add(this.lblEmployeeSalary);
            this.gbxInput.Controls.Add(this.txtEmployeeSalary);
            this.gbxInput.Controls.Add(this.lblEmployeeName);
            this.gbxInput.Controls.Add(this.txtEmployeeName);
            this.gbxInput.Location = new System.Drawing.Point(105, 300);
            this.gbxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxInput.Size = new System.Drawing.Size(435, 132);
            this.gbxInput.TabIndex = 8;
            this.gbxInput.TabStop = false;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 506);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbxEmployeeList);
            this.Controls.Add(this.gbxInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPersonel";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbxEmployeeList;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.TextBox txtEmployeeSalary;
		private System.Windows.Forms.Button btnAddEmployee;
		private System.Windows.Forms.Button btnUpdateEmployee;
		private System.Windows.Forms.Button btnDeleteEmployee;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Label lblEmployeeSalary;
		private System.Windows.Forms.GroupBox gbxInput;
	}
}