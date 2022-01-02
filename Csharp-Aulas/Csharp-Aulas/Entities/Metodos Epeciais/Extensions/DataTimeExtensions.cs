using System.Globalization;

namespace System
{
    static class DataTimeExtensions
    {
        public static string ElapsedTime (this DateTime thisObj){
            TimeSpan duraction = DateTime.Now.Subtract(thisObj);

            if (duraction.TotalHours < 24.0)
            {
                return duraction.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
                
            }
            else
            {
                return duraction.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}


/*
 * Exemplo:
 DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
 Console.WriteLine(dt.ElapsedTime());
 */