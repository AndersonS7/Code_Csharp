using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Aulas.Entities.Seção_10___Herança_e__polimorfismo
{
    class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount()
        {
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {

        }
    }
}
