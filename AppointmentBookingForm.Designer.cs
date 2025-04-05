using System;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace BookingAppointment
{
    public partial class AppointmentBookingForm : Form
    {
        public AppointmentBookingForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lstTimeSlots = new System.Windows.Forms.ListBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFetchSlots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(30, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lstTimeSlots
            // 
            this.lstTimeSlots.FormattingEnabled = true;
            this.lstTimeSlots.Location = new System.Drawing.Point(120, 70);
            this.lstTimeSlots.Name = "lstTimeSlots";
            this.lstTimeSlots.Size = new System.Drawing.Size(200, 95);
            this.lstTimeSlots.TabIndex = 3;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(30, 180);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
           
            "Nail-Care",
            "Eyelash-Care",
            "Spray-Tanning"});
            this.cmbService.Location = new System.Drawing.Point(120, 180);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(200, 21);
            this.cmbService.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(230, 220);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnFetchSlots
            // 
            this.btnFetchSlots.Location = new System.Drawing.Point(120, 220);
            this.btnFetchSlots.Name = "btnFetchSlots";
            this.btnFetchSlots.Size = new System.Drawing.Size(90, 30);
            this.btnFetchSlots.TabIndex = 6;
            this.btnFetchSlots.Text = "Fetch Slots";
            this.btnFetchSlots.UseVisualStyleBackColor = true;
            this.btnFetchSlots.Click += new System.EventHandler(this.btnFetchSlots_Click);
            // 
            // AppointmentBookingForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnFetchSlots);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lstTimeSlots);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Name = "AppointmentBookingForm";
            this.Text = "Appointment Booking";
            this.Load += new System.EventHandler(this.AppointmentBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnFetchSlots_Click(object sender, EventArgs e)
        {
            // Trigger the load event to fetch time slots
            AppointmentBookingForm_Load(sender, e);
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstTimeSlots.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            var firebaseClient = new FirebaseClient("https://appointment-system-e766f-default-rtdb.firebaseio.com/");
            var selectedDate = dtpDate.Value.ToString("yyyy-MM-dd");
            var selectedService = cmbService.SelectedItem.ToString();
            var selectedTime = lstTimeSlots.SelectedItem.ToString();

            // Save the booking to Firebase
            var booking = new Booking
            {
                Date = selectedDate,
                Time = selectedTime,
                Service = selectedService,
                CustomerName = "Customer Name" // Replace with actual customer name
            };

            await firebaseClient
                .Child("Bookings")
                .PostAsync(booking);

            MessageBox.Show("Appointment booked successfully!");
        }

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lstTimeSlots;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Button btnFetchSlots;
        private System.Windows.Forms.Button btnConfirm;

    }

    public class TimeSlot
    {
        public string Time { get; set; }
    }

    public class Booking // can call it Appointment
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Service { get; set; }
        public string CustomerName { get; set; }
    }
}
