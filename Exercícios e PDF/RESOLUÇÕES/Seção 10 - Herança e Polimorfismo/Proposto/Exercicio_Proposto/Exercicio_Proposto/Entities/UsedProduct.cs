using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Proposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override StringBuilder PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name
                + " (used) $ "
                + Price
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")");

            return sb;
        }
    }
}
