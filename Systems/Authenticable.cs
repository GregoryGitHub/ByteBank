

using ByteBank.Employes;

namespace ByteBank.Systems
{
    abstract class Authenticable : Employe
    {
        public string Password { get; set; }

        public Authenticable(string cpf, double salary) : base(cpf, salary)
        {

        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
