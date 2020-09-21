using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Email;
namespace Asp_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailInfoController : ControllerBase
    {

        //Receiving http request and executing a query string that enters the email data into a database.
        [HttpPost("InsertEmailInfo")]
        public bool Insert(EmailInfo email)
        {
            return DB.Modify("INSERT INTO Email (Sender,Subject, Recieve, Body) VALUES (@Sender,@Subject, @Recieve, @Body)",
                (cmd) => {
                    cmd.AddWithValue("@Sender", email.Sender)
                    .AddWithValue("@Subject", email.Subject)
                    .AddWithValue("@Recieve", email.Recieve)
                    .AddWithValue("@Body", email.Body);

                }) == 1;
        }

        //Receiving http request and executing a query string that pulling all email data from databse and send to the client.
        [HttpGet("pull")]
        public List<EmailInfo> Pull()
        {
            return DB.PullData<EmailInfo>(
                "SELECT Sender, Subject, Recieve, Body FROM Email",
                (dr) => new EmailInfo
                {
                    Sender = dr.IsDBNull(0)?"Empty":dr.GetString(0),
                    Subject = dr.IsDBNull(1) ? "Empty" : dr.GetString(1),
                    Recieve = dr.IsDBNull(2) ? "Empty" : dr.GetString(2),
                    Body = dr.IsDBNull(3) ? "Empty" : dr.GetString(3)
                }); 
        }


    }
}
