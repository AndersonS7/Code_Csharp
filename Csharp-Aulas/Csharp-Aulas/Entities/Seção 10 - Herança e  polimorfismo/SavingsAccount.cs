using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Aulas.Entities.Seção_10___Herança_e__polimorfismo
{
    class SavingsAccount : Account
    {
        public double InterestRite { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRite)
            : base(number, holder, balance)
        {
            InterestRite = InterestRite;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRite;
        }

        public override void WithDraw(double amount) // override para poder sobrescrever a superclass Account
        {
            Balance -= amount;
        }
    }
}
