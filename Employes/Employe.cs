using System;

namespace ByteBank.Employes
{
    public abstract class Employe
    {
        public static int TotalOfEmployes { get; private set; }

        public string Name { get; set; }
        private string CPF { get; set; }

        public double Salary { get; protected set; }

        public Employe(string cpf,double salary)
        {
            Salary = salary;
            CPF = cpf;
            TotalOfEmployes++;
        }

        public abstract void IncrementSalary();
        public abstract double GetBonification();
        

    }
}
