using System;

namespace GreetingTDD
{
    public class UserLoginService : IUserLoginService
    {
        public string GreetUser(string UserName)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                throw new ArgumentNullException("UserName");
            }
            if (UserName.Length == 0)
            {
                throw new ArgumentException("UserName cannot be empty");
            }
            return string.Format($"Hello {UserName}!");
        }
    }
}