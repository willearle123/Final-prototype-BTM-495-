using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingAppointment
{
    public partial class AppointmentBookingForm : Form
    {
        //public AppointmentBookingForm()
        //{
        //    InitializeComponent();
        //}

        private async void AppointmentBookingForm_Load(object sender, EventArgs e)
        {
            // Fetch available time slots from Firebase
            var firebaseClient = new FirebaseClient("https://appointment-system-e766f-default-rtdb.firebaseio.com/");
            var selectedDate = dtpDate.Value.ToString("yyyy-MM-dd");
            var selectedService = cmbService.SelectedItem?.ToString();

            if (selectedService == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            var timeSlots = await firebaseClient
                .Child("TimeSlots")
                .Child(selectedDate)
                .Child(selectedService)
                .OnceAsync<TimeSlot>();

            lstTimeSlots.Items.Clear();

            if (timeSlots == null || timeSlots.Count == 0)
            {
                MessageBox.Show("No time slots available for the selected date and service.");
                return;
            }

            foreach (var slot in timeSlots)
            {
                lstTimeSlots.Items.Add(slot.Object.Time);
            }
        }

    }
}
