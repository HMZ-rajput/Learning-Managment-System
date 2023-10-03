using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class FormLogin : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+"DSA_Project_DB.mdf;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.8.1\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
            optionCB.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show.StudentForm();
        }

        private void showpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassCB.Checked)
            {
                passwordTB.PasswordChar = '\0';
            }
            else
            {
                passwordTB.PasswordChar = '•';
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            passwordTB.Text = "";
            optionCB.Text = "";
            IdTB.Focus();
        }

        private void gotoRegisterBtn_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (IdTB.Text == "" | passwordTB.Text == ""| optionCB.Text == "")
            {
                MessageBox.Show("All Fields must be filles", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string password = passwordTB.Text;
                EncryptPass(ref password);

                // Login process
                //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.7\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");
                con.Open();

                if(optionCB.Text == "Student")
                {
                    SqlCommand cmd = new SqlCommand("Select Count(*) From tbl_Student Where Id = @Id and Password = @Password" , con);
                    cmd.Parameters.AddWithValue("@Id", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int UserExist = (int)cmd.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        // Note!
                        //Also send Id to next form to get correct records
                        con.Close();
                        new FormStudent(IdTB.Text).Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Enrollment or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select Count(*) From tbl_Faculty Where Id = @Id and Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Id", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int UserExist = (int)cmd.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        // Note!
                        //Also send Id to next form to get correct records
                        con.Close();
                        new FormFaculty().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Enrollment or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
            }
        }

        public void EncryptPass(ref string password)
        {
            var sha = SHA256.Create();
            var ByteArr = Encoding.Default.GetBytes(password);
            var encryptPass = sha.ComputeHash(ByteArr);

            password = Convert.ToBase64String(encryptPass);
        }

        string oldText = String.Empty;
        private void IdTB_TextChanged_1(object sender, EventArgs e)
        {
            //prevent Alphabate in username
            if (IdTB.Text.All(chr => char.IsDigit(chr)))
            {
                oldText = IdTB.Text;
                IdTB.Text = oldText;

                IdTB.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
                IdTB.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                IdTB.Text = oldText;

                IdTB.BackColor = System.Drawing.Color.FromArgb(185, 35, 45);
                IdTB.ForeColor = System.Drawing.Color.White;

            }
            IdTB.SelectionStart = IdTB.Text.Length;
        }

        private void optionCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
