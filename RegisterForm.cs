using System;
using System.Linq;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;


namespace BookingAppointment
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDOB.Value,
                Gender = cmbGender.SelectedItem.ToString(),
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Phone = txtPhone.Text,
                Country = txtCountry.Text
            };

            var firebaseClient = new FirebaseClient("https://appointment-system-e766f-default-rtdb.firebaseio.com/");
            await firebaseClient
                .Child("Customers")
                .PostAsync(JsonConvert.SerializeObject(customer));

            MessageBox.Show("Customer registered successfully!");
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
                MessageBox.Show("Login successful! You can now book an appointment.");
                // Navigate to the appointment booking form
                AppointmentBookingForm bookingForm = new AppointmentBookingForm();
                bookingForm.Show();
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
