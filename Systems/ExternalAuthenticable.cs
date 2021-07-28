using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public class ExternalAuthenticable : IAuthenticable
    {
        public string Password { get; set; }
        private string Name { get; set; }

        public ExternalAuthenticable(string name)
        {
            Name = name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
