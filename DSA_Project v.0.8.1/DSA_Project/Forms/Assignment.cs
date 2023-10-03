using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;



namespace DSA_Project.Forms
{
    public partial class Assignment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.8.1\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");

        string id,dept;
        private SqlDataReader dr;

        public Assignment(string id)
        {
            InitializeComponent();

            this.id = id;
            dept = getDept();
            //Load Course from DB to Combobox
            CBCourse();

            //fill datagridview
            LoadTable(AssigmentCB.Text);

        }

        public void LoadTable(string course)
        {
            //Get Assigments
            getAssigmet(course, dept);

            //Create Button in cells
            //Upload button
            DataGridViewButtonColumn uploadBtn = new DataGridViewButtonColumn();
            uploadBtn.Name = "Upload";
            uploadBtn.Text = "Upload";
            uploadBtn.HeaderText = "Upload";
            uploadBtn.UseColumnTextForButtonValue = true;
            int columnIndex = 2;
            if (DGVAssignment.Columns["Upload"] == null)
            {
                DGVAssignment.Columns.Insert(columnIndex, uploadBtn);
            }

            //Download button
            DataGridViewButtonColumn downloadBtn = new DataGridViewButtonColumn();
            downloadBtn.Name = "Download";
            downloadBtn.Text = "Download";
            downloadBtn.HeaderText = "Download";
            downloadBtn.UseColumnTextForButtonValue = true;
            int columnIndex2 = 3;
            if (DGVAssignment.Columns["Download"] == null)
            {
                DGVAssignment.Columns.Insert(columnIndex2, downloadBtn);
            }
        }
        public void CBCourse() { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Courses From tbl_Student Where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            dr = cmd.ExecuteReader();
            dr.Read();
            String Courses = dr["Courses"].ToString();
            string[] Course = Courses.Split(',');

            for(int i = 0; i<Course.Length; i++)
            {
                AssigmentCB.Items.Add(Course[i]);
            }
            con.Close();
        }

        public string getDept()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Department From tbl_Student Where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            dr = cmd.ExecuteReader();
            dr.Read();
            string dept = dr["Department"].ToString();
            con.Close();
            return dept;
        }

        public string getAssigId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Assignment_Id from tbl_Assigment where ");
            return "";
        }

        public void getAssigmet(string course, string dept)
        {
            con.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter("Select * From tbl_Assignment Where Course = @Course and Class = @Class",con);
            query.SelectCommand.Parameters.AddWithValue("@Course", course);
            query.SelectCommand.Parameters.AddWithValue("@Class", dept);
            query.Fill(tbl);
            DGVAssignment.DataSource = tbl;
            con.Close();
        }

        private void comboBoxAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable(AssigmentCB.Text);
        }

        private void tableAssignment_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assigment_DS_1.tbl_Assignment' table. You can move, or remove it, as needed.
            //this.tbl_AssignmentTableAdapter3.Fill(this.assigment_DS_1.tbl_Assignment);
            // TODO: This line of code loads data into the 'assignmet_DataSet.tbl_Assignment' table. You can move, or remove it, as needed.
            this.tbl_AssignmentTableAdapter2.Fill(this.assignmet_DataSet.tbl_Assignment);
            // TODO: This line of code loads data into the 'dSA_Project_DBDataSet1.tbl_Assignment' table. You can move, or remove it, as needed.
            //this.tbl_AssignmentTableAdapter1.Fill(this.dSA_Project_DBDataSet1.tbl_Assignment);
            // TODO: This line of code loads data into the 'dSA_Project_DBDataSet.tbl_Assignment' table. You can move, or remove it, as needed.
            //this.tbl_AssignmentTableAdapter.Fill(this.dSA_Project_DBDataSet.tbl_Assignment);

        }

        private void DGVAssignment_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DGVAssignment.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void DGVAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVAssignment.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if(DGVAssignment.CurrentCell != null && DGVAssignment.CurrentCell.Value != null)
                {
                    UploadBtn(e.RowIndex);
                }
            }
            if (DGVAssignment.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (DGVAssignment.CurrentCell != null && DGVAssignment.CurrentCell.Value != null)
                {
                    DownloadBtn(e.RowIndex);
                }
            }
        }

        public void DownloadBtn(int row)
        {
            FolderBrowserDialog FileDialog2 = new FolderBrowserDialog();

            if (FileDialog2.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                textBox1.Text = FileDialog2.SelectedPath;
            }

            string filePath = FileDialog2.SelectedPath;        // save the path of file from open dialogue box into string variable
            filePath += "\\"+DateTime.Now.ToString("h_mm_ss")+".pdf";

            con.Open();
            using (SqlCommand command = new SqlCommand("SELECT Files From [tbl_Assignment] WHERE Course = @Course And Class=@Class And Sno = @Sno", con))
            {
                command.Parameters.AddWithValue("@Course", AssigmentCB.Text);
                command.Parameters.AddWithValue("@Class", dept);
                command.Parameters.AddWithValue("@Sno", row);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] fileData = (byte[])reader["Files"];

                        //Decompress
                        Program.ExtractPdfFile(fileData,filePath);
                        MessageBox.Show("Download Success Success");
                    }
                }
            }
            con.Close();
        }
        public void UploadBtn(int row)
        {
            openFileDialog2.InitialDirectory = "C:";    // open the C drive as default directory in open dialog box
            openFileDialog2.Title = "Select Path";
            openFileDialog2.FileName = " ";
            openFileDialog2.Filter = "All Files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
            {

            }
            else
            {
                textBox1.Text = openFileDialog2.FileName;
            }

            string filePath = openFileDialog2.FileName;         // save the path of file from open dialogue box into string variable
            string binPath = filePath;                          // set the path for .bin file
            string codingSchemePath = filePath;

            int index = codingSchemePath.IndexOf(".");
            if (index > 0)
            {
                codingSchemePath = codingSchemePath.Substring(0, index);
            }
            codingSchemePath = codingSchemePath + "_codingScheme.txt";      // concate the string

            index = binPath.IndexOf(".");
            if (index > 0)
            {
                binPath = binPath.Substring(0, index);
            }
            binPath = binPath + ".bin";         // concate the string with .bin
            textBox1.Text = filePath;
            textBox2.Text = binPath;            // new path

            // Get the extension of input file
            string extension = System.IO.Path.GetExtension(filePath);

            if (extension == ".pdf")
            {
                // Call the function to compress and Upload the pdf file
                Program.CompressUploadPdfFile(filePath, binPath, codingSchemePath, id, AssigmentCB.Text,row);
            }
            else if (extension != ".pdf")
            {
                MessageBox.Show("Please select PDF File.");
            }
        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
