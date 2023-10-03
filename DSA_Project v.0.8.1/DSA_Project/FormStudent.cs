using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class FormStudent : Form
    {
       
        private Form activeForm;
        public string id;
        public FormStudent(string id)
   
        {
          InitializeComponent();
            this.id = id;
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
       
        //private void ActivateButton(object btnSender)
        //{
        //    if (btnSender != null)
        //    {
        //        if (currentButton != (Button)btnSender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            currentButton = (Button)btnSender;
        //            currentButton.BackColor = color;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            panelTitleBar.BackColor = color;
        //            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            ThemeColor.PrimaryColor = color;
        //            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            btnCloseChildForm.Visible = true;
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CourseOutline(), sender);

        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Forms.Assignment( id), sender);
        }

        private void btnLectureNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LectureNotes(), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

    }
}

