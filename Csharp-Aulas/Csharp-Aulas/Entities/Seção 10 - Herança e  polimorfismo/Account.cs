
namespace Csharp_Aulas.Entities.Seção_10___Herança_e__polimorfismo
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount) // virtual para o metodo poder ser sobre escrito pelas subclass
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
