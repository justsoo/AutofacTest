using Autofac.Extras.DynamicProxy;

namespace AutofacTest.Services
{
    [Intercept(typeof(UserServiceInterceptor))]
    public class UserService : IUserService
    {
        public string GetUserName()
        {
            return "oec2003";
        }
    }
}
