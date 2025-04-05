using System;
using System.Windows.Forms;

namespace BookingAppointment
{
    public partial class PostLoginForm : Form
    {
        public PostLoginForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void InitializeComponent()
        {
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnLeaveReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(50, 50);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(200, 50);
            this.btnBookAppointment.TabIndex = 0;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnLeaveReview
            // 
            this.btnLeaveReview.Location = new System.Drawing.Point(50, 120);
            this.btnLeaveReview.Name = "btnLeaveReview";
            this.btnLeaveReview.Size = new System.Drawing.Size(200, 50);
            this.btnLeaveReview.TabIndex = 1;
            this.btnLeaveReview.Text = "Leave Review";
            this.btnLeaveReview.UseVisualStyleBackColor = true;
            this.btnLeaveReview.Click += new System.EventHandler(this.btnLeaveReview_Click);
            // 
            // PostLoginForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.btnLeaveReview);
            this.Controls.Add(this.btnBookAppointment);
            this.Name = "PostLoginForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            var appointmentForm = new AppointmentBookingForm();
            appointmentForm.Show();
            this.Hide();
        }

        private void btnLeaveReview_Click(object sender, EventArgs e)
        {
            var reviewForm = new ReviewForm();
            reviewForm.Show();
            this.Hide();
        }

        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnLeaveReview;
    }
}
