using System.Globalization;

namespace Csharp_Aulas
{
    #region Seção 05
    //class Produto
    //{
    //    private string _nome;
    //    public double Preco { get; private set; }
    //    public int Quantidade { get; private set; }

    //    public Produto(string nome, double preco, int quantidade)
    //    {
    //        _nome = nome;
    //        Preco = preco;
    //        Quantidade = quantidade;
    //    }

    //    public string Nome
    //    {
    //        get { return _nome; }
    //        set
    //        {
    //            if (value != null && value.Length > 2)
    //            {
    //                _nome = value;
    //            }
    //        }
    //    }

    //    public double ValorTotalEmEstoque()
    //    {
    //        return Preco * Quantidade;
    //    }
    //    public void AdicionarProdutos(int quantidade)
    //    {
    //        Quantidade += quantidade;
    //    }
    //    public void RemoverProdutos(int quantidade)
    //    {
    //        Quantidade -= quantidade;
    //    }
    //    public override string ToString()
    //    {
    //        return _nome + ", $"
    //            + Preco.ToString("F2", CultureInfo.InvariantCulture)
    //            + ", "
    //            + Quantidade
    //            + " unidades, Total $ "
    //            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    //    }
    //}
    #endregion
    class Calculator
    {
        public static double sum { get; private set; }

        public static double Sum(params double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
