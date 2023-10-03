using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DSA_Project
{
    public partial class FormRegister : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Documents\\University\\BSE 3B\\DSA Data Structure and Algorithme\\Project\\DSA_Project v.0.8.1\\DSA_Project\\DSA_Project_DB.mdf\";Integrated Security=True");

        public FormRegister()
        {
            InitializeComponent();
            optionCB.SelectedIndex = 0;
            DeptCB.SelectedIndex = 0;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "" | passwordTB.Text == "" | cpasswordTB.Text == "" | optionCB.Text == "")
            {
                MessageBox.Show("All Fields must be filles", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (optionCB.Text == "Student" & DeptCB.Text == "")
            {
                MessageBox.Show("All Fields must be filles", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordTB.Text != cpasswordTB.Text)
            {
                MessageBox.Show("Password does not Match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int hashkey = HashFunction(usernameTB.Text);

                //Encrypt password
                string password = passwordTB.Text;
                EncryptPass(ref password);

                // Registration process
                //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\USERS\\HP\\DOCUMENTS\\UNI\\DSA_PROJECT - COPY\\DSA_PROJECT\\DSA_PROJECT_DB.MDF\";Integrated Security=True");
                con.Open();

                if (optionCB.Text == "Student")
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_Student values (@Id,@Name,@Department,@Password,@Courses)", con);

                    HandleCollision(con, 's', ref hashkey);

                    cmd.Parameters.AddWithValue("@Id", hashkey);
                    cmd.Parameters.AddWithValue("@Name", usernameTB.Text);
                    cmd.Parameters.AddWithValue("@Department", DeptCB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);
                    if(DeptCB.Text == "BSE")
                    {
                        cmd.Parameters.AddWithValue("@Courses", "Computer Programming,Computer Fundamentals");
                    }
                    else if(DeptCB.Text == "BBA")
                    {
                        cmd.Parameters.AddWithValue("@Courses", "Maths,English");
                    }
                    else if (DeptCB.Text == "BCS")
                    {
                        cmd.Parameters.AddWithValue("@Courses", "Computer Programming,Computer Fundamentals");
                    }
                    else if (DeptCB.Text == "BIT")
                    {
                        cmd.Parameters.AddWithValue("@Courses", "Software Requirments,Linear Algebra");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Courses", "Science,Psycology");
                    }

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_Faculty values (@Id,@Name,@Courses,@Password)", con);


                    HandleCollision(con, 'f', ref hashkey);

                    cmd.Parameters.AddWithValue("@Id", hashkey);
                    cmd.Parameters.AddWithValue("@Name", usernameTB.Text);
                    cmd.Parameters.AddWithValue("@Courses", DeptCB.Text);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Congratulations!! Registration Successfull\nYour Id is :" + hashkey, "Registraion Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void showpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassCB.Checked)
            {
                passwordTB.PasswordChar = '\0';
                cpasswordTB.PasswordChar = '\0';
            }
            else
            {
                passwordTB.PasswordChar = '•';
                cpasswordTB.PasswordChar = '•';
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void openLoginBtn_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionCB.Text == "Faculty")
            {
                //DeptCB.Enabled = false;
                DeptCB.Text = "";
                DeptLabel.Text = "Course";
                DeptCB.Items.Clear();
                DeptCB.Items.Add("Computer Programming");
                DeptCB.Items.Add("Computer Fundamentals");
                DeptCB.Items.Add("Software Requirments");
                DeptCB.Items.Add("Linear Algebra");
                DeptCB.Items.Add("Pakistan Studies");
                DeptCB.Items.Add("Psycology");
                DeptCB.Items.Add("Science");
                DeptCB.Items.Add("English");
                DeptCB.Items.Add("Maths");
                DeptCB.Items.Add("Islamyat");
                DeptCB.Items.Add("");
            }
            else
            {
                //DeptCB.Enabled = true;
                DeptCB.Text = "";
                DeptLabel.Text = "Department";
                DeptCB.Items.Clear();
                DeptCB.Items.Add("BSE");
                DeptCB.Items.Add("BCS");
                DeptCB.Items.Add("BBA");
                DeptCB.Items.Add("BIT");
                DeptCB.Items.Add("BES");
                DeptCB.Items.Add("");

            }
        }

        public void clear()
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
            cpasswordTB.Text = "";
            optionCB.Text = "";
            DeptCB.Text = "";
            usernameTB.Focus();
        }

        static int HashFunction(string s)
        {
            int total = 0;
            char[] c;
            c = s.ToCharArray();

            // Summing up all the ASCII values
            // of each alphabet in the string
            for (int k = 0; k <= c.GetUpperBound(0); k++)
                total += (int)c[k];

            //1000 ~ number of total rows possible in table

            return total % 1000;
        }

        public void HandleCollision(SqlConnection con, char tbl, ref int hashkey)
        {
            bool insert = false;
            do
            {
                SqlCommand CheckId;
                if (tbl == 's')
                {
                    CheckId = new SqlCommand("Select Count(*) From tbl_Student Where ([Id] = @Id)", con);

                }
                else
                {
                    CheckId = new SqlCommand("Select Count(*) From tbl_Faculty Where ([Id] = @Id)", con);

                }
                CheckId.Parameters.AddWithValue("@Id", hashkey);

                int IdCount = (int)CheckId.ExecuteScalar();
                if (IdCount > 0)
                {
                    hashkey++;
                }
                else
                {
                    insert = true;
                }
            } while (!insert);
        }

        public void EncryptPass(ref string password)
        {
            var sha = SHA256.Create();
            var ByteArr = Encoding.Default.GetBytes(password);
            var encryptPass = sha.ComputeHash(ByteArr);

            password = Convert.ToBase64String(encryptPass);
        }

        string oldText = string.Empty;
        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            //prevent number in username
            if (usernameTB.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = usernameTB.Text;
                usernameTB.Text = oldText;

                usernameTB.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
                usernameTB.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                usernameTB.Text = oldText;

                usernameTB.BackColor = System.Drawing.Color.FromArgb(185, 35, 45);
                usernameTB.ForeColor = System.Drawing.Color.White;

            }
            usernameTB.SelectionStart = usernameTB.Text.Length;
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
