using System;
using System.Globalization;
using System.Text;

namespace Exercicio_Proposto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsfee)
            :base(name, price)
        {
            CustomsFee = customsfee;
        }

        public override StringBuilder PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name + " $ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " ( Customs fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
                + " )");

            return sb;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
