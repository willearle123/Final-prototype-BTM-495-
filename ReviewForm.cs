using System;
using System.Windows.Forms;
using Firebase.Database;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace BookingAppointment
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(20, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;
            this.txtComment.Text = "Enter Name";
            this.txtComment.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtComment.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(20, 60);
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(200, 20);
            this.numRating.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(20, 100);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(200, 60);
            this.txtComment.TabIndex = 2;
            this.txtComment.Text = "Add Comment for Review";
            this.txtComment.Enter += new System.EventHandler(this.txtField_Enter);
            this.txtComment.Leave += new System.EventHandler(this.txtField_Leave);
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(20, 180);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(200, 30);
            this.btnSubmitReview.TabIndex = 3;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // ReviewForm
            // 
            this.ClientSize = new System.Drawing.Size(250, 230);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.txtUserName);
            this.Name = "ReviewForm";
            this.Text = "Leave a Review";
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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

        private async void btnSubmitReview_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var rating = (int)numRating.Value;
            var comment = txtComment.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter your name and comment.");
                return;
            }

            await SubmitReviewAsync(userName, rating, comment);
            MessageBox.Show("Review submitted successfully.");

            // Clear the input fields
            txtUserName.Clear();
            numRating.Value = 1;
            txtComment.Clear();
        }

        private async Task SubmitReviewAsync(string userName, int rating, string comment)
        {
            var firebaseClient = new FirebaseClient("https://appointment-system-e766f-default-rtdb.firebaseio.com/");
            var review = new
            {
                UserName = userName,
                Rating = rating,
                Comment = comment
            };

            await firebaseClient
                .Child("Reviews")
                .PostAsync(review);
        }

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitReview;
    }
}
