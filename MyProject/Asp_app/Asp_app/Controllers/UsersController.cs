using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Email;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserInfo;

namespace Asp_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        //Receiving http request and executing a query string that pulling username and password.
        [HttpGet("pull")]
        public List<User> Pull()
        {
            return DB.PullData<User>(
                "SELECT Usr, Password FROM Usrtb",
                (dr) => new User
                {
                    Usr = dr.GetString(0),
                    Password = dr.GetString(1)

                });
        }


        //Receiving http request and executing a query string that enters all user information into a database
        [HttpPost("insert")]
        public bool Insert(User user)
        {
            return DB.Modify("INSERT INTO Usrtb (Usr, Password, FirstName, LastName) VALUES (@Usr, @Password, @FirstName, @LastName)",
                (cmd) => {
                    cmd
                    .AddWithValue("@Usr", user.Usr)
                    .AddWithValue("@Password", user.Password)
                    .AddWithValue("@FirstName", user.FirstName)
                    .AddWithValue("@LastName", user.LastName);

                }) == 1;
        }




        //Receiving http request and executing a query string that delete the user from the database.
        [HttpPost("delete")]
        public bool Delete(User user)
        {
            return DB.Modify("DELETE FROM Usrtb WHERE Usr=@Usr",
                (cmd) => cmd.AddWithValue("@Usr", user.Usr)) == 1;
        }



        //Receiving http request and executing a query string that update the password of specific user in database.
        [HttpPost("update")]
        public bool Update(User user)
        {
            return DB.Modify("UPDATE Usrtb SET Password=@Password WHERE Usr = @Usr",
                (cmd) => {
                    cmd
                    .AddWithValue("@Password", user.Password)
                    .AddWithValue("@Usr", user.Usr);
                    
                
                }) == 1;
        }



    }


    //Extention method 
    public static class MyExtensionMethod
    {
        public static SqlCommand AddWithValue(this SqlCommand cmd, string parameterName, object value)
        {
            if (value == null)
                cmd.Parameters.AddWithValue(parameterName, DBNull.Value);
            else
                cmd.Parameters.AddWithValue(parameterName, value);
            return cmd;
        }

        

    }

}
