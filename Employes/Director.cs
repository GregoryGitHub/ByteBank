namespace ByteBank.Employes
{
    class Director: Employe
    {
        public Director(string cpf,double salary=5000):base(cpf, salary)
        {
        }

        public override void IncrementSalary()
        {
            Salary *= 1.15;
        }

        override public double GetBonification()
        {
            return Salary + base.GetBonification();
        }
    }
}
