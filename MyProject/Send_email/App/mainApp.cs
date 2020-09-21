using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net;
using Email;
using App;

namespace Send_email
{
    public partial class mainApp : Form
    {
        private string sender, recieve, password, subject, body;
        public mainApp()
        {
            InitializeComponent();
            ResetEmailInfo();
        }

        private void mainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the current window close, the login window is displayed
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GetData();
            SendEmail();
        }

        private void btnViewEmails_Click(object sender, EventArgs e)
        {
            //A new window created and we can see all the sharing emails 
            ViewEmails viewEmails = new ViewEmails();
            this.Hide();
            viewEmails.ShowDialog();
        }

        private void GetData()
        {
            //Get all information about sending email
            sender = txtFrom.Text;
            recieve = txtTo.Text;
            password = txtPassword.Text;
            subject = txtSubject.Text;
            body = txtBody.Text;

        }




        private void SendEmail()
        {
            //Perform a check that the user has enterd content in all fields.
            if (sender.Length == 0 || recieve.Length == 0 || password.Length == 0 || subject.Length == 0 || body.Length == 0)
            {
                MessageBox.Show("You must fill all the fields");
                return;
            }


            try
            {
                //step 1- Creating a message!
                MailMessage message = new MailMessage(sender, recieve, subject, body);
                //step 2- creating a smtp protocol
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                //step 3 -setting up the password and username
                client.Credentials = new System.Net.NetworkCredential(sender, password);
                client.EnableSsl = true;
                client.Send(message);
                MessageBox.Show("Successfully send");
                UpdateToDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong \n" + ex.Message, "Error");
            }

        }

        private void UpdateToDatabase()
        {
            //Execute http request to the server to update all the data of the email that user has inserted to database.
            HttpUtils.SendHttpPostRequest("http://localhost:5000/api/EmailInfo/InsertEmailInfo", (f) =>
            {
                bool isTrue = Convert.ToBoolean(f);
                if (isTrue)
                {
                    Action action = () =>
                    {
                        ResetEmailInfo();
                    };
                    this.Invoke(action);
                }
            }, Newtonsoft.Json.JsonConvert.SerializeObject(new EmailInfo { Sender = sender, Recieve = recieve, Subject = subject, Body = body }));
        }

        private void ResetEmailInfo()
        {
            //Reset all fields so we can enter new data 
            txtFrom.Text = "";
            txtPassword.Text = "";
            txtTo.Text = "";
            txtSubject.Text = "";
            txtBody.Text = "";
            txtBody.ScrollBars = ScrollBars.Both;
            ActiveControl = txtFrom;
        }
    }
}
