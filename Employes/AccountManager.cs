using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Systems;

namespace ByteBank.Employes
{
    class AccountManager : Authenticable
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
