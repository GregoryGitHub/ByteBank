using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employes
{
    class Designer: Employe
    {
        public Designer(string cpf, double salary=4000): base(cpf, salary)
        {

        }


        public override void IncrementSalary()
        {
            Salary *= 0.50;
        }

        override public double GetBonification()
        {
            return Salary *= 0.4;
        }
    }
}
