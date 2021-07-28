
using System;

namespace ByteBank.Systems
{
    class InternalSystem
    {
        public bool Login(IAuthenticable authenticable, string password)
        {
            bool userAuthenticated = authenticable.Authenticate(password);

            if (userAuthenticated)
            {
                Console.WriteLine("Welcome '{0}' to Internal System of ByteBank", authenticable.getName());
                return true;
            }else
            {
                Console.WriteLine("Invalid Credentials for employe '{0}'", authenticable.getName());
            }
            return false;
        }
    }
}
