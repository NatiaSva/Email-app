using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfo;

namespace Send_email
{
    public partial class registerForm : Form
    {

        private string userName;
        private string password;
        private string firstName;
        private string lastName;
        public registerForm()
        {
            InitializeComponent();
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the current window
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUpdate();
        }

        private void RegisterUpdate()
        {
            userName = txtUserName.Text;
            password = txtPassword.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;

            //Check that the user has enterd content in all fields
            if (userName.Length == 0 || password.Length == 0 || firstName.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("You must fill all the fields");
                return;
            }
            else
            {
                //Execute http request to the server to enter data that the user has enterd into a databse.
                HttpUtils.SendHttpPostRequest("http://localhost:5000/api/Users/insert", (f) =>
                {
                    bool isTrue = Convert.ToBoolean(f);
                    if (isTrue)
                    {
                        MessageBox.Show("Successfully inserted");

                        Action action = () =>
                        {
                            Close();
                        };
                        this.Invoke(action);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }, Newtonsoft.Json.JsonConvert.SerializeObject(new User { Usr = userName, Password = password, FirstName = firstName, LastName = lastName }));


            }
        }

        //When the current window close, the login window is displayed
        private void registerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                }
            }
        }
    }
}
