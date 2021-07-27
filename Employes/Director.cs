using ByteBank.Systems;

namespace ByteBank.Employes
{
    class Director: Authenticable
    {
        
        public Director(string cpf,double salary=5000):base(cpf, salary)
        {
            Password = "123";
        }

        public override void IncrementSalary()
        {
            Salary *= 1.15;
        }

        override public double GetBonification()
        {
            return Salary * 1.25;
        }

    }
}
