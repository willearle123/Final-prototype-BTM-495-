using System.Windows.Forms;

namespace BookingAppointment
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            //this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            //this.lblFirstName.AutoSize = true;
            //this.lblFirstName.Location = new System.Drawing.Point(30, 33);
            //this.lblFirstName.Name = "lblFirstName";
            //this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            //this.lblFirstName.TabIndex = 0;
            //this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(120, 110);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(120, 150);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 21);
            this.cmbGender.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 310);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Text = "Phone";
            this.txtPhone.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 350);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.Text = "Country";
            this.txtCountry.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtCountry.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(120, 390);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 30);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(230, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 30);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            //this.Controls.Add(this.lblFirstName);
            this.Name = "RegisterForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;

        #endregion
    }
}
