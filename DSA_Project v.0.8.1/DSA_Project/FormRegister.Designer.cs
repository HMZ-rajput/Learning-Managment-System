namespace DSA_Project
{
    partial class FormRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cpasswordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showpassCB = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openLoginBtn = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.optionCB = new System.Windows.Forms.ComboBox();
            this.DeptCB = new System.Windows.Forms.ComboBox();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(33, 103);
            this.usernameTB.Multiline = true;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(216, 28);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(33, 275);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '•';
            this.passwordTB.Size = new System.Drawing.Size(216, 28);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // cpasswordTB
            // 
            this.cpasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.cpasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpasswordTB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpasswordTB.Location = new System.Drawing.Point(34, 334);
            this.cpasswordTB.Multiline = true;
            this.cpasswordTB.Name = "cpasswordTB";
            this.cpasswordTB.PasswordChar = '•';
            this.cpasswordTB.Size = new System.Drawing.Size(216, 28);
            this.cpasswordTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // showpassCB
            // 
            this.showpassCB.AutoSize = true;
            this.showpassCB.Location = new System.Drawing.Point(127, 368);
            this.showpassCB.Name = "showpassCB";
            this.showpassCB.Size = new System.Drawing.Size(122, 21);
            this.showpassCB.TabIndex = 7;
            this.showpassCB.Text = "Show Password";
            this.showpassCB.UseVisualStyleBackColor = true;
            this.showpassCB.CheckedChanged += new System.EventHandler(this.showpassCB_CheckedChanged);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(36, 416);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(216, 35);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.clearBtn.Location = new System.Drawing.Point(36, 466);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(216, 35);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(59, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an Account";
            // 
            // openLoginBtn
            // 
            this.openLoginBtn.AutoSize = true;
            this.openLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.openLoginBtn.Location = new System.Drawing.Point(86, 551);
            this.openLoginBtn.Name = "openLoginBtn";
            this.openLoginBtn.Size = new System.Drawing.Size(97, 17);
            this.openLoginBtn.TabIndex = 11;
            this.openLoginBtn.Text = "Back to LOGIN";
            this.openLoginBtn.Click += new System.EventHandler(this.openLoginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(255, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 30);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // optionCB
            // 
            this.optionCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.optionCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionCB.DisplayMember = "Student";
            this.optionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionCB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCB.FormattingEnabled = true;
            this.optionCB.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            ""});
            this.optionCB.Location = new System.Drawing.Point(33, 161);
            this.optionCB.MaxDropDownItems = 2;
            this.optionCB.Name = "optionCB";
            this.optionCB.Size = new System.Drawing.Size(216, 29);
            this.optionCB.TabIndex = 14;
            this.optionCB.ValueMember = "Student";
            this.optionCB.SelectedIndexChanged += new System.EventHandler(this.optionCB_SelectedIndexChanged);
            // 
            // DeptCB
            // 
            this.DeptCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.DeptCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeptCB.DisplayMember = "Student";
            this.DeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeptCB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCB.FormattingEnabled = true;
            this.DeptCB.Items.AddRange(new object[] {
            "BSE",
            "BCS",
            "BBA",
            "BIT",
            "BES",
            ""});
            this.DeptCB.Location = new System.Drawing.Point(34, 220);
            this.DeptCB.MaxDropDownItems = 2;
            this.DeptCB.Name = "DeptCB";
            this.DeptCB.Size = new System.Drawing.Size(216, 29);
            this.DeptCB.TabIndex = 16;
            this.DeptCB.ValueMember = "Student";
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.Location = new System.Drawing.Point(36, 200);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(82, 17);
            this.DeptLabel.TabIndex = 15;
            this.DeptLabel.Text = "Department";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 600);
            this.Controls.Add(this.DeptCB);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.optionCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.openLoginBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.showpassCB);
            this.Controls.Add(this.cpasswordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpasswordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showpassCB;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label openLoginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox optionCB;
        private System.Windows.Forms.ComboBox DeptCB;
        private System.Windows.Forms.Label DeptLabel;
    }
}