
using ByteBank.Systems;

namespace ByteBank.Employes
{
    class AccountManager : AuthenticableEmploye
    {
        
        public AccountManager(string cpf, double salary=4000): base(cpf,salary)
        {
            Password = "1234";
        }

        public override void IncrementSalary()
        {
            Salary *= 0.80;
        }

        override public double GetBonification()
        {
            return Salary *= 0.3;
        }
    }
}
