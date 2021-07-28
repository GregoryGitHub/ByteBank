using ByteBank.Employes;
using ByteBank.Systems;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            UseSystem();

        }

        public static void UseSystem()
        {
            var sarah = new Director("222.333.444-98", 20000);
            sarah.Name = "Sarah Felix";

            var victor = new AccountManager("222.333.444-98", 20000);
            victor.Name = "Victor Wooten";

            var peter = new CommercialPartner("Peter");
            peter.Password = "3344";

            var jonh = new Designer("21312");
            jonh.Name = "jonh";

            var system = new InternalSystem();

            system.Login(peter, "3344");
            system.Login(sarah, "123");
            system.Login(victor, "1234");
        }

        public static void CalculateBonifications()
        {

            var bob = new Designer("123.123.123-32", 3500);
            bob.Name = "Bob Joe";

            var sarah = new Director("222.333.444-98", 20000);
            sarah.Name = "Sarah Felix";

            var victor = new AccountManager("222.333.444-98", 20000);
            victor.Name = "Victor Wooten";

            // Register Employes.
            var bm = new BonificationManager();
            bm.Register(bob);
            bm.Register(sarah);
            bm.Register(victor);


            Console.WriteLine("Bob's bonifications:.....{0:c}", bob.GetBonification());
            Console.WriteLine("Sarah's bonifications:...{0:c}", sarah.GetBonification());
            Console.WriteLine("Victor's bonifications:..{0:c}", victor.GetBonification());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Total bonifications:.....{0:c}", bm.GetTotalBonifications());
        }
    }
}
