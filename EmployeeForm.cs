using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod7EmpDBSystem
{
    //when press btnAddNew, EId should auto generate, the rest of the txbx & cmbx should .Clear();




    public partial class EmployeeForm : Form
    {
        EmpRepository repository;//EmpRepository is a custom defined class using interface CRUD, which has declared but not defined functions and variables needs to be implemented/defined
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            repository = new EmpRepository();
            dataGridEmployee.DataSource = repository.GetEmployees();
            btnSubmNew.Enabled = false;
            btnUpdt.Enabled = false;
            dataGridEmployee.Columns[6].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txbxEId.Clear();
            txbxEId.Text = (repository.GetMaxId() + 1).ToString();//increase the current largest EId by 1
            txbxEId.ReadOnly = true;
            txbxLName.Clear();
            txbxFName.Clear();
            txbxSalary.Clear();
            foreach (var d in repository.ReadDepts())
            {
                cmbxDept.Items.AddRange(d.DeptName);
            }
            cmbxDesignation.Items.AddRange(new string[] { "Sr.Dev", "Mngr", "Sr.Mngr" });
            btnSubmNew.Visible = true;
        }

        public void Clear()
        {
            txbxEid.Clear();
            txbxFName.Clear();
            txbxLName.Clear();
            cmbxDept.SelectedIndex = -1;
            cmbxDesignation.SelectedIndex = -1;

        }


        private void btnSubmNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbxFName.Text) && !
                (string.IsNullOrWhiteSpace(txbxLName.Text)) && !
                (string.IsNullOrWhiteSpace(txbxEId.Text)))
            {
                var newemp = new Employee();
                newemp.EmpId = Convert.ToInt32(txbxEId.Text);
                newemp.EmpFName = txbxFName.Text;
                newemp.EmpLName = txbxLName.Text;
                newemp.DeptId = cmbxDept.SelectedIndex + 1;
                newemp.Designation = cmbxDesignation.SelectedItem.ToString();
                newemp.Salary = Convert.ToDecimal(txbxSalary.Text);
                repository.AddRecord(newemp);
            }
            Clear();
        }

        private void btnRfrsh_Click(object sender, EventArgs e)
        {
            dataGridEmployee.DataSource = null;
            dataGridEmployee.DataSource = repository.GetEmployees();
            dataGridEmployee.Columns[6].Visible = false;

        }

        private void btnSlct2Updt_Click(object sender, EventArgs e)//select records, records shows in txbx & cmbx, once changes made, btnUpdate enabled and make updates
        {
            var id = dataGridEmployee.CurrentRow.Cells[0].Value;
            var emptoupdate = repository.FindEmployee((int)id);//call fndemp emthod in repository by using id
            txbxEId.Text = emptoupdate.EmpId.ToString();
            txbxEId.ReadOnly = true;
            txbxFName.Text = emptoupdate.EmpFName;
            txbxLName.Text = emptoupdate.EmpLName;
            txbxSalary.Text = emptoupdate.txbxSalary.ToString();
            foreach (var d in repository.ReadDepts())
            {
                cmbxDept.Items.AddRange(d.DeptName);
                if (d.DeptId == emptoupdate.DeptId)//comparing each DeptId in Department tbl w each DeptId of each Employee records
                {
                    cmbxDept.SelectedItem = d.DeptName;
                }
            }
            cmbxDesignation.Items.AddRange(new string[] { "Sr.Dev", "Mngr", "Sr.Mngr" });
            
            cmbxDept.SelectedItem = emptoupdate.DeptId;
            cmbxDesignation.SelectedItem = emptoupdate.Designation;
            btnUpdt.Enabled = true;
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txbxEId.Text);
            var emptoupdate = repository.FindEmployee(id);
            emptoupdate.EmpFName = txbxFName.Text;
            emptoupdate.EmpLName = txbxLName.Text;
            emptoupdate.Salary = Convert.ToDecimal(txbxSalary.Text);
            emptoupdate.Designation = cmbxDesignation.SelectedItem.ToString();
            emptoupdate.DeptId = cmbxDept.SelectedIndex + 1;
            repository.UpdateRecord(id, emptoupdate);
            Clear();
        }

        private void btnDelRcrd_Click(object sender, EventArgs e)
        {
            var id = dataGridEmployee.CurrentRow.Cells[0].Value;
            var emptodel = repository.FindEmployee((int)id);
            repository.DeleteRecord(emptodel);
            MessageBox.Show("Record is deleted");
            Clear();
        }
    }
}
