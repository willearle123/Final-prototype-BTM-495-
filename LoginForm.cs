using System;
using System.Linq;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace BookingAppointment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(50, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(100, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 150);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var firebaseClient = new FirebaseClient("https://appointment-system-e766f-default-rtdb.firebaseio.com/");
            var customers = await firebaseClient
                .Child("Customers")
                .OnceAsync<Customer>();

            var customer = customers.FirstOrDefault(c => c.Object.Username == txtUsername.Text && c.Object.Password == txtPassword.Text);

            if (customer != null)
            {
                MessageBox.Show("Login successful! You can now book an appointment or leave a review.");

                // Navigate to Post Login page
                var postLoginForm = new PostLoginForm();
                postLoginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void txtField_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text == textBox.Name.Replace("txt", ""))
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void txtField_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = textBox.Name.Replace("txt", "");
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Country { get; set; }
        }

    }
}
