namespace GreetingTDD
{
    public class UserLoginService : IUserLoginService
    {
        public string GreetUser(string validName)
        {
            return string.Format($"Hello {validName}!");
        }
    }
}