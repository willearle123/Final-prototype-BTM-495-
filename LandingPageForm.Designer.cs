using System;
using System.Windows.Forms;

namespace BookingAppointment
{
    public partial class LandingPageForm : Form
    {
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHeading.Location = new System.Drawing.Point(50, 30);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(250, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Appointment Setter";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(50, 100);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(200, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LandingPageForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblHeading);
            this.Name = "LandingPageForm";
            this.Text = "Landing Page";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Redirect to Register form
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Redirect to Login form
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
    }
}
