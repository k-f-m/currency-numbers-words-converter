namespace AngularASP.NETCore.Server.Data.Services
{
    public class Translate
    {
        private static readonly string[] Ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly string[] Tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        internal static string ConvertCurrencyToWords(string text)
        {
            decimal amount;
            // if successful conversion
            if (Decimal.TryParse(text, out amount))
            {
                //Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            if (amount == 0) return "zero dollars";

            int dollars = (int)Math.Floor(amount);
            int cents = (int)Math.Round((amount - dollars) * 100);

            string result = "100.20";

            return result;
        }

    }
}
