namespace DSA_Project.Forms
{
    partial class Assignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AssigmentCB = new System.Windows.Forms.ComboBox();
            this.testLB = new System.Windows.Forms.Label();
            this.DGVAssignment = new System.Windows.Forms.DataGridView();
            this.tblAssignmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAssignmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSA_Project_DBDataSet1 = new DSA_Project.DSA_Project_DBDataSet1();
            this.dSA_Project_DBDataSet = new DSA_Project.DSA_Project_DBDataSet();
            this.tblAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AssignmentTableAdapter = new DSA_Project.DSA_Project_DBDataSetTableAdapters.tbl_AssignmentTableAdapter();
            this.tbl_AssignmentTableAdapter1 = new DSA_Project.DSA_Project_DBDataSet1TableAdapters.tbl_AssignmentTableAdapter();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.assignmetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmet_DataSet = new DSA_Project.Assignmet_DataSet();
            this.tbl_AssignmentTableAdapter2 = new DSA_Project.Assignmet_DataSetTableAdapters.tbl_AssignmentTableAdapter();
            this.assigment_DS_1 = new DSA_Project.Assigment_DS_1();
            this.tblAssignmentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AssignmentTableAdapter3 = new DSA_Project.Assigment_DS_1TableAdapters.tbl_AssignmentTableAdapter();
            this.SNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSA_Project_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSA_Project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmet_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assigment_DS_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // AssigmentCB
            // 
            this.AssigmentCB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssigmentCB.FormattingEnabled = true;
            this.AssigmentCB.Location = new System.Drawing.Point(117, 90);
            this.AssigmentCB.Name = "AssigmentCB";
            this.AssigmentCB.Size = new System.Drawing.Size(121, 20);
            this.AssigmentCB.TabIndex = 0;
            this.AssigmentCB.Text = "Select Course";
            this.AssigmentCB.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssignment_SelectedIndexChanged);
            // 
            // testLB
            // 
            this.testLB.AutoSize = true;
            this.testLB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLB.Location = new System.Drawing.Point(26, 90);
            this.testLB.Name = "testLB";
            this.testLB.Size = new System.Drawing.Size(70, 17);
            this.testLB.TabIndex = 1;
            this.testLB.Text = "Course: ";
            // 
            // DGVAssignment
            // 
            this.DGVAssignment.AllowUserToAddRows = false;
            this.DGVAssignment.AutoGenerateColumns = false;
            this.DGVAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNum,
            this.FilesName,
            this.Action});
            this.DGVAssignment.DataSource = this.tblAssignmentBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAssignment.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAssignment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVAssignment.Location = new System.Drawing.Point(0, 149);
            this.DGVAssignment.Name = "DGVAssignment";
            this.DGVAssignment.Size = new System.Drawing.Size(740, 310);
            this.DGVAssignment.TabIndex = 2;
            this.DGVAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAssignment_CellClick);
            this.DGVAssignment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVAssignment.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVAssignment.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGVAssignment_RowPostPaint);
            // 
            // tblAssignmentBindingSource2
            // 
            this.tblAssignmentBindingSource2.DataMember = "tbl_Assignment";
            this.tblAssignmentBindingSource2.DataSource = this.assignmetDataSetBindingSource;
            // 
            // tblAssignmentBindingSource1
            // 
            this.tblAssignmentBindingSource1.DataMember = "tbl_Assignment";
            this.tblAssignmentBindingSource1.DataSource = this.dSA_Project_DBDataSet1;
            // 
            // dSA_Project_DBDataSet1
            // 
            this.dSA_Project_DBDataSet1.DataSetName = "DSA_Project_DBDataSet1";
            this.dSA_Project_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSA_Project_DBDataSet
            // 
            this.dSA_Project_DBDataSet.DataSetName = "DSA_Project_DBDataSet";
            this.dSA_Project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAssignmentBindingSource
            // 
            this.tblAssignmentBindingSource.DataMember = "tbl_Assignment";
            this.tblAssignmentBindingSource.DataSource = this.dSA_Project_DBDataSet;
            // 
            // tbl_AssignmentTableAdapter
            // 
            this.tbl_AssignmentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_AssignmentTableAdapter1
            // 
            this.tbl_AssignmentTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // assignmetDataSetBindingSource
            // 
            this.assignmetDataSetBindingSource.DataSource = this.assignmet_DataSet;
            this.assignmetDataSetBindingSource.Position = 0;
            // 
            // assignmet_DataSet
            // 
            this.assignmet_DataSet.DataSetName = "Assignmet_DataSet";
            this.assignmet_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_AssignmentTableAdapter2
            // 
            this.tbl_AssignmentTableAdapter2.ClearBeforeFill = true;
            // 
            // assigment_DS_1
            // 
            this.assigment_DS_1.DataSetName = "Assigment_DS_1";
            this.assigment_DS_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAssignmentBindingSource3
            // 
            this.tblAssignmentBindingSource3.DataMember = "tbl_Assignment";
            this.tblAssignmentBindingSource3.DataSource = this.assigment_DS_1;
            // 
            // tbl_AssignmentTableAdapter3
            // 
            this.tbl_AssignmentTableAdapter3.ClearBeforeFill = true;
            // 
            // SNum
            // 
            this.SNum.DataPropertyName = "Serial No.";
            this.SNum.FillWeight = 30.45685F;
            this.SNum.HeaderText = "Serial No.";
            this.SNum.Name = "SNum";
            // 
            // FilesName
            // 
            this.FilesName.DataPropertyName = "FilesName";
            this.FilesName.HeaderText = "FilesName";
            this.FilesName.Name = "FilesName";
            // 
            // Action
            // 
            this.Action.FillWeight = 134.7716F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 459);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGVAssignment);
            this.Controls.Add(this.testLB);
            this.Controls.Add(this.AssigmentCB);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSA_Project_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSA_Project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmet_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assigment_DS_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignmentBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AssigmentCB;
        private System.Windows.Forms.Label testLB;
        private System.Windows.Forms.DataGridView DGVAssignment;
        private DSA_Project_DBDataSet dSA_Project_DBDataSet;
        private System.Windows.Forms.BindingSource tblAssignmentBindingSource;
        private DSA_Project_DBDataSetTableAdapters.tbl_AssignmentTableAdapter tbl_AssignmentTableAdapter;
        private DSA_Project_DBDataSet1 dSA_Project_DBDataSet1;
        private System.Windows.Forms.BindingSource tblAssignmentBindingSource1;
        private DSA_Project_DBDataSet1TableAdapters.tbl_AssignmentTableAdapter tbl_AssignmentTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource assignmetDataSetBindingSource;
        private Assignmet_DataSet assignmet_DataSet;
        private System.Windows.Forms.BindingSource tblAssignmentBindingSource2;
        private Assignmet_DataSetTableAdapters.tbl_AssignmentTableAdapter tbl_AssignmentTableAdapter2;
        private Assigment_DS_1 assigment_DS_1;
        private System.Windows.Forms.BindingSource tblAssignmentBindingSource3;
        private Assigment_DS_1TableAdapters.tbl_AssignmentTableAdapter tbl_AssignmentTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}