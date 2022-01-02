using System.Globalization;
using System.Text;

namespace Exercicio_Proposto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual StringBuilder PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb;
        }
    }
}
