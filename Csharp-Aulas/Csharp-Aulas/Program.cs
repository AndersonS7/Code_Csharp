using Csharp_Aulas.Entities.Seção_10___Herança_e__polimorfismo;

namespace Csharp_Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Marcia", 200.0);
            Account acc2 = new SavingsAccount(1002, "Júlio", 200.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);
            System.Console.WriteLine("Conta 1: " + acc1.Balance);
            System.Console.WriteLine("Conta 2: " + acc2.Balance);
        }
    }
}
