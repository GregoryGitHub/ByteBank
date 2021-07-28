
using ByteBank.Systems;

namespace ByteBank.Employes
{
    public abstract class AuthenticableEmploye : Employe, IAuthenticable
    {
        public string Password { get; set; }
        public AuthenticableEmploye(string cpf, double salary) : base(cpf,salary)
        {

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
