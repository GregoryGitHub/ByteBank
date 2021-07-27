using ByteBank.Employes;
using System;

namespace ByteBank.Systems
{
    class InternalSystem
    {
        public bool Login(Authenticable employe, string password)
        {
            bool userAuthenticated = employe.Authenticate(password);

            if (userAuthenticated)
            {
                Console.WriteLine("Welcome '{0}' to Internal System of ByteBank",employe.Name);
                return true;
            }else
            {
                Console.WriteLine("Invalid Credentials for employe '{0}'", employe.Name);
            }
            return false;
        }
    }
}
