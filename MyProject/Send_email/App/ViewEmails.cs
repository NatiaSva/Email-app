using Send_email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email;
using Newtonsoft.Json;

namespace App
{
    public partial class ViewEmails : Form
    {
      
        private List<EmailInfo> allEmailInfo;
        private EmailInfo[] emailInfo;
        public ViewEmails()
        {
            InitializeComponent();
            GetAllemailInfo();
        }

        private void ViewEmails_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the current window close, the Email sending window is displayed
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is mainApp)
                {
                    frm.Show();
                }
            }
        }

     
        private void GetAllemailInfo()
        {
            //Execute http request to the server to pull email information from a database and display to table.
            HttpUtils.SendHttpGetRequest("http://localhost:5000/api/EmailInfo/pull", (ls) =>
            {

                emailInfo = JsonConvert.DeserializeObject<EmailInfo[]>(ls);

                allEmailInfo = emailInfo.OfType<EmailInfo>().ToList();

                Action action = () => {
                    dataGridView1.DataSource = allEmailInfo;
                };
                this.Invoke(action);

            });

           
        }



    }
}
