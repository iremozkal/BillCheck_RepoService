using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillCheck_RepoService.DATA.Model_DTO;
using BillCheck_RepoService.BLL.UIService;

namespace BillCheck_RepoService.UI
{
    public partial class FormPersonel : Form
    {
        EmployeeUIService empUI = new EmployeeUIService();

        public FormPersonel()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDTO newEmpDto = new EmployeeDTO()
            {
                EmployeeName = txtEmployeeName.Text,
                EmployeeSalary = Convert.ToDecimal(txtEmployeeSalary.Text)
            };

            if (empUI.Insert(newEmpDto)) MessageBox.Show("The operation was executed successfully!");
            else MessageBox.Show("Failed! The operation could not be performed.");

            FillEmployeesToListBox();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            FillEmployeesToListBox();
        }

        private void FillEmployeesToListBox()
        {
            // lbxEmployeeList.Items.Clear(); 
            lbxEmployeeList.DataSource = empUI.GetAllEmpDTO();
            lbxEmployeeList.DisplayMember = "EmployeeName";
        }

    }
}
