using System;
using System.Collections.Generic;
using System.Linq;

namespace CSAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<User> userList = new List<User>();

                User newUser1 = new User();
                newUser1.Email = "esteban@sonething.com";
                newUser1.Password = "Password1";
                newUser1.UserId = 1;
                newUser1.UserName = "Esteban";
                userList.Add(newUser1);

                User newUser2 = new User();
                newUser2.Email = "esteban2@sonething.com";
                newUser2.Password = "Password2";
                newUser2.UserId = 2;
                newUser2.UserName = "Esteban2";
                userList.Add(newUser2);

                User newUser3 = new User();
                newUser3.Email = "esteban3@sonething.com";
                newUser3.Password = "Password3";
                newUser3.UserId = 3;
                newUser3.UserName = "Esteban3";
                userList.Add(newUser3);

                User newUser4 = new User();
                newUser4.Email = "esteban4@sonething.com";
                newUser4.Password = "Password4";
                newUser4.UserId = 4;
                newUser4.UserName = "Esteban4";
                userList.Add(newUser4);

                User newUser5 = new User();
                newUser5.Email = "esteban5@sonething.com";
                newUser5.Password = "Password5";
                newUser5.UserId = 5;
                newUser5.UserName = "Esteban5";
                userList.Add(newUser5);

                User newUser6 = new User();
                newUser6.Email = "esteban6@sonething.com";
                newUser6.Password = "Password6";
                newUser6.UserId = 6;
                newUser6.UserName = "Esteban6";
                userList.Add(newUser6);

                User newUser7 = new User();
                newUser7.Email = "esteban7@sonething.com";
                newUser7.Password = "Password7";
                newUser7.UserId = 7;
                newUser7.UserName = "Esteban7";
                userList.Add(newUser7);

                User newUser8 = new User();
                newUser8.Email = "esteban8@sonething.com";
                newUser8.Password = "Password8";
                newUser8.UserId = 8;
                newUser8.UserName = "Esteban8";
                userList.Add(newUser8);

                User newUser9 = new User();
                newUser9.Email = "esteban9@sonething.com";
                newUser9.Password = "Password9";
                newUser9.UserId = 9;
                newUser9.UserName = "Esteban9";
                userList.Add(newUser9);

                User newUser10 = new User();
                newUser10.Email = "esteban10@sonething.com";
                newUser10.Password = "Password10";
                newUser10.UserId = 10;
                newUser10.UserName = "Esteban10";
                userList.Add(newUser10);

                userList = userList.Where(user => user.UserName == "Esteban").ToList();

                if (userList.Count > 0)
                {
                    Console.WriteLine("Users found and they have the following properties:");
                    string format = "My user has these properties: " +
                                    "Email: {0}, UserId: {1}, Password: {2}, " +
                                    "UserName: {3}";

                    foreach (var user in userList)
                    {
                        Console.WriteLine(format, user.Email, user.UserId,
                                          user.Password, user.UserName);
                    }
                }
                else
                {
                    throw new UserNotFound("No users found for the specified query");
                }
            }
            catch(UserNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended.");
            }
        }
        public class User
        {
            public User()
            {
            }

            public string Email { get; set; }

            public string UserName { get; set; }

            public string Password { get; set; }

            public int UserId { get; set; }

        }
    }
}

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}
