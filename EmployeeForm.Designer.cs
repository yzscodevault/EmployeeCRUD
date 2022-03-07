
namespace Mod7EmpDBSystem
{
    partial class EmployeeForm
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
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.grpbxEmpRcrd = new System.Windows.Forms.GroupBox();
            this.cmbxDesignation = new System.Windows.Forms.ComboBox();
            this.cmbxDept = new System.Windows.Forms.ComboBox();
            this.txbxSalary = new System.Windows.Forms.TextBox();
            this.txbxFName = new System.Windows.Forms.TextBox();
            this.txbxLName = new System.Windows.Forms.TextBox();
            this.txbxEId = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEDept = new System.Windows.Forms.Label();
            this.lblELName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelRcrd = new System.Windows.Forms.Button();
            this.btnSubmNew = new System.Windows.Forms.Button();
            this.btnSlct2Updt = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnRfrsh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.grpbxEmpRcrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Location = new System.Drawing.Point(62, 35);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.Size = new System.Drawing.Size(555, 66);
            this.dataGridEmployee.TabIndex = 0;
            // 
            // grpbxEmpRcrd
            // 
            this.grpbxEmpRcrd.Controls.Add(this.cmbxDesignation);
            this.grpbxEmpRcrd.Controls.Add(this.cmbxDept);
            this.grpbxEmpRcrd.Controls.Add(this.txbxSalary);
            this.grpbxEmpRcrd.Controls.Add(this.txbxFName);
            this.grpbxEmpRcrd.Controls.Add(this.txbxLName);
            this.grpbxEmpRcrd.Controls.Add(this.txbxEId);
            this.grpbxEmpRcrd.Controls.Add(this.lblSalary);
            this.grpbxEmpRcrd.Controls.Add(this.lblDesignation);
            this.grpbxEmpRcrd.Controls.Add(this.lblEDept);
            this.grpbxEmpRcrd.Controls.Add(this.lblELName);
            this.grpbxEmpRcrd.Controls.Add(this.lblFName);
            this.grpbxEmpRcrd.Controls.Add(this.lblId);
            this.grpbxEmpRcrd.Location = new System.Drawing.Point(35, 136);
            this.grpbxEmpRcrd.Name = "grpbxEmpRcrd";
            this.grpbxEmpRcrd.Size = new System.Drawing.Size(281, 217);
            this.grpbxEmpRcrd.TabIndex = 1;
            this.grpbxEmpRcrd.TabStop = false;
            this.grpbxEmpRcrd.Text = "Employee Record";
            // 
            // cmbxDesignation
            // 
            this.cmbxDesignation.FormattingEnabled = true;
            this.cmbxDesignation.Location = new System.Drawing.Point(142, 143);
            this.cmbxDesignation.Name = "cmbxDesignation";
            this.cmbxDesignation.Size = new System.Drawing.Size(121, 21);
            this.cmbxDesignation.TabIndex = 2;
            // 
            // cmbxDept
            // 
            this.cmbxDept.FormattingEnabled = true;
            this.cmbxDept.Location = new System.Drawing.Point(142, 113);
            this.cmbxDept.Name = "cmbxDept";
            this.cmbxDept.Size = new System.Drawing.Size(121, 21);
            this.cmbxDept.TabIndex = 2;
            // 
            // txbxSalary
            // 
            this.txbxSalary.Location = new System.Drawing.Point(142, 171);
            this.txbxSalary.Name = "txbxSalary";
            this.txbxSalary.Size = new System.Drawing.Size(100, 20);
            this.txbxSalary.TabIndex = 1;
            // 
            // txbxFName
            // 
            this.txbxFName.Location = new System.Drawing.Point(142, 58);
            this.txbxFName.Name = "txbxFName";
            this.txbxFName.Size = new System.Drawing.Size(100, 20);
            this.txbxFName.TabIndex = 1;
            // 
            // txbxLName
            // 
            this.txbxLName.Location = new System.Drawing.Point(142, 86);
            this.txbxLName.Name = "txbxLName";
            this.txbxLName.Size = new System.Drawing.Size(100, 20);
            this.txbxLName.TabIndex = 1;
            // 
            // txbxEId
            // 
            this.txbxEId.Location = new System.Drawing.Point(142, 29);
            this.txbxEId.Name = "txbxEId";
            this.txbxEId.Size = new System.Drawing.Size(100, 20);
            this.txbxEId.TabIndex = 1;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalary.Location = new System.Drawing.Point(7, 174);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDesignation.Location = new System.Drawing.Point(7, 146);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEDept
            // 
            this.lblEDept.AutoSize = true;
            this.lblEDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEDept.Location = new System.Drawing.Point(7, 116);
            this.lblEDept.Name = "lblEDept";
            this.lblEDept.Size = new System.Drawing.Size(72, 13);
            this.lblEDept.TabIndex = 0;
            this.lblEDept.Text = "Department";
            // 
            // lblELName
            // 
            this.lblELName.AutoSize = true;
            this.lblELName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblELName.Location = new System.Drawing.Point(6, 89);
            this.lblELName.Name = "lblELName";
            this.lblELName.Size = new System.Drawing.Size(125, 13);
            this.lblELName.TabIndex = 0;
            this.lblELName.Text = "Employee Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFName.Location = new System.Drawing.Point(7, 59);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(125, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "Employee First Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.Location = new System.Drawing.Point(7, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(76, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Employee Id";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddNew.Location = new System.Drawing.Point(348, 147);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(86, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelRcrd
            // 
            this.btnDelRcrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelRcrd.Location = new System.Drawing.Point(633, 147);
            this.btnDelRcrd.Name = "btnDelRcrd";
            this.btnDelRcrd.Size = new System.Drawing.Size(115, 23);
            this.btnDelRcrd.TabIndex = 3;
            this.btnDelRcrd.Text = "Delete Record";
            this.btnDelRcrd.UseVisualStyleBackColor = true;
            this.btnDelRcrd.Click += new System.EventHandler(this.btnDelRcrd_Click);
            // 
            // btnSubmNew
            // 
            this.btnSubmNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmNew.Location = new System.Drawing.Point(348, 197);
            this.btnSubmNew.Name = "btnSubmNew";
            this.btnSubmNew.Size = new System.Drawing.Size(86, 23);
            this.btnSubmNew.TabIndex = 2;
            this.btnSubmNew.Text = "Submit New";
            this.btnSubmNew.UseVisualStyleBackColor = true;
            this.btnSubmNew.Click += new System.EventHandler(this.btnSubmNew_Click);
            // 
            // btnSlct2Updt
            // 
            this.btnSlct2Updt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSlct2Updt.Location = new System.Drawing.Point(477, 147);
            this.btnSlct2Updt.Name = "btnSlct2Updt";
            this.btnSlct2Updt.Size = new System.Drawing.Size(114, 23);
            this.btnSlct2Updt.TabIndex = 2;
            this.btnSlct2Updt.Text = "Select to Update";
            this.btnSlct2Updt.UseVisualStyleBackColor = true;
            this.btnSlct2Updt.Click += new System.EventHandler(this.btnSlct2Updt_Click);
            // 
            // btnUpdt
            // 
            this.btnUpdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdt.Location = new System.Drawing.Point(477, 197);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(114, 23);
            this.btnUpdt.TabIndex = 2;
            this.btnUpdt.Text = "Update Record";
            this.btnUpdt.UseVisualStyleBackColor = true;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnRfrsh
            // 
            this.btnRfrsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRfrsh.Location = new System.Drawing.Point(633, 197);
            this.btnRfrsh.Name = "btnRfrsh";
            this.btnRfrsh.Size = new System.Drawing.Size(115, 23);
            this.btnRfrsh.TabIndex = 3;
            this.btnRfrsh.Text = "Refresh Data";
            this.btnRfrsh.UseVisualStyleBackColor = true;
            this.btnRfrsh.Click += new System.EventHandler(this.btnRfrsh_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnSlct2Updt);
            this.Controls.Add(this.btnSubmNew);
            this.Controls.Add(this.btnRfrsh);
            this.Controls.Add(this.btnDelRcrd);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpbxEmpRcrd);
            this.Controls.Add(this.dataGridEmployee);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.grpbxEmpRcrd.ResumeLayout(false);
            this.grpbxEmpRcrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.GroupBox grpbxEmpRcrd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbxSalary;
        private System.Windows.Forms.TextBox txbxFName;
        private System.Windows.Forms.TextBox txbxLName;
        private System.Windows.Forms.TextBox txbxEId;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEDept;
        private System.Windows.Forms.Label lblELName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cmbxDesignation;
        private System.Windows.Forms.ComboBox cmbxDept;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelRcrd;
        private System.Windows.Forms.Button btnSubmNew;
        private System.Windows.Forms.Button btnSlct2Updt;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnRfrsh;
    }
}

