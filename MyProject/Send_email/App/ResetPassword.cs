using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfo;

namespace Send_email
{
    public partial class ResetPassword : Form
    {
        private string userName;
        private string newPassword;
        private string oldPassword;
        private User[] users;
        private bool isUserExist;
        public ResetPassword()
        {
            InitializeComponent();
            isUserExist = false;
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            CheckLogin();

        }

        private void CheckLogin()
        {
            userName = txtUsername.Text;
            oldPassword = txtOldPassword.Text;
            newPassword = txtNewPassword.Text;

            // Check that the user has enterd content in all fields
            if (userName.Length == 0 || oldPassword.Length == 0 || newPassword.Length==0)
            {
                MessageBox.Show("You must fill all the fields");
                return;
            }


            /*
            Execute Http request to the server to check if the user and password entered exist in a database.
            If the user and password exist, the user can resset his password.
            */

            HttpUtils.SendHttpGetRequest("http://localhost:5000/api/Users/pull", (ls) =>
            {
                users = JsonConvert.DeserializeObject<User[]>(ls);

                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Usr == userName && users[i].Password == oldPassword)
                    {
                        isUserExist = true;
                        Action action = () =>
                        {
                            UpdatePassword();
                        };
                        this.Invoke(action);
                        return;
                    }

                }
                if (isUserExist == false)
                {
                    MessageBox.Show("User or password does not exist");

                }
            });
        }


        private void UpdatePassword()
        {
            //Execute http request to the server to enter the new password into database.
            HttpUtils.SendHttpPostRequest("http://localhost:5000/api/Users/update", (f) =>
            {
                bool isTrue = Convert.ToBoolean(f);
                if (isTrue)
                {
                    MessageBox.Show("Successfully updated password");
                    Action action = () =>
                    {
                        Close();
                    };
                    this.Invoke(action);
                }
                else
                {
                    MessageBox.Show("User or password is incorrect");
                }
            }, Newtonsoft.Json.JsonConvert.SerializeObject(new User {Usr=userName, Password = newPassword }));
        }


    }
}
