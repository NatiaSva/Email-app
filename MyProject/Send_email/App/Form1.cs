using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {
        private string userName;
        private string password;
        private User[] users;

        public Form1()
        {
            InitializeComponent();
            ResetUserInfo(); 

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            //A new window is created for registering to the system
            registerForm rf = new registerForm();
            this.Hide();
            rf.ShowDialog();
            ResetUserInfo();
        }

        private void ResetUserInfo()
        {
            //Reset all fields so we can enter new data 
            txtUserName.Text = "";
            txtPassword.Text = "";
            ActiveControl = txtUserName;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }


        private void CheckLogin()
        {
            //Perform check that the user has enterd content in all fields
            userName = txtUserName.Text;
            password = txtPassword.Text;

            if (userName.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("You must fill all the fields");
                return;
            }


            /*
            Execute Http request to the server to check if the user and password entered exist in a database.
            If the user and password exist, the user will be able to enter the application window.
            */
            HttpUtils.SendHttpGetRequest("http://localhost:5000/api/Users/pull", (ls) =>
            {

                users = JsonConvert.DeserializeObject<User[]>(ls);

                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Usr == userName && users[i].Password == password)
                    {
                        Action showApp = () =>
                        {
                            mainApp ma = new mainApp();
                            Hide();
                            ma.ShowDialog();
                            ResetUserInfo();
                        };
                        this.Invoke(showApp);
                        return;
                    }

                }

                MessageBox.Show("User or password does not exist");
                Action deleteUser = () =>
                {
                    ResetUserInfo();
                };
                this.Invoke(deleteUser);

            });


        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            //When the delete button is pressed,it is checked if the user has enterd content in the field.
            userName = txtUserName.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("User required");
                return;
            }

            /*
            Execute http request to the server to check if the enterd user exist in the database.
            If the user exist, we delete user and if the user does not exist the  application will display a message.
            */
            HttpUtils.SendHttpPostRequest("http://localhost:5000/api/Users/delete", (f) =>
            {
                bool isTrue = Convert.ToBoolean(f);
                if (isTrue)
                {
                    MessageBox.Show("Successfully deleted");
                    Action deleteUser = () =>
                    {
                        ResetUserInfo();
                    };
                    this.Invoke(deleteUser);
                }
                else
                {
                    MessageBox.Show("User does not exist");
                    Action action = () =>
                    {
                        ResetUserInfo();
                    };
                    this.Invoke(action);

                }
            }, Newtonsoft.Json.JsonConvert.SerializeObject(new User { Usr = userName }));
        }

        
        private void label4_Click(object sender, EventArgs e)
        {
            //A new window is created and we can reset the password
            ResetPassword rp = new ResetPassword();
            Hide();
            rp.ShowDialog();
        }
    }





}
