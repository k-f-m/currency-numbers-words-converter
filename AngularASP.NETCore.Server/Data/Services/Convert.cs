namespace AngularASP.NETCore.Server.Data.Services
{
    class Convert
    {
        private static readonly string[] Ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly string[] Tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        internal static string ConvertToWords(decimal amount)
        {
            if (amount == 0) return "zero dollars";

            int dollars = (int)Math.Floor(amount);
            int cents = (int)Math.Round((amount - dollars) * 100);

            string result = "";

            if (dollars > 0)
            {
                if (dollars >= 1000000)
                {
                    result += ConvertToWords(dollars / 1000000) + " million ";
                    dollars %= 1000000;
                }

                if (dollars >= 1000)
                {
                    result += ConvertToWords(dollars / 1000) + " ";

                    if (dollars >= 10000 && dollars <= 99999)
                    {
                        result += "ten-thousand ";
                    }
                    else if (dollars >= 100000 && dollars <= 999999)
                    {
                        result += $"{ConvertToWords(dollars / 1000)}-thousand ";
                    }
                    else
                    {
                        result += "thousand ";
                    }

                    dollars %= 1000;
                }

                if (dollars >= 100)
                {
                    result += Ones[dollars / 100] + " hundred ";
                    dollars %= 100;
                }

                if (dollars > 0)
                {
                    if (result != "") result += "and ";

                    if (dollars < 20)
                    {
                        result += Ones[dollars];
                    }
                    else
                    {
                        result += Tens[dollars / 10 - 2] + " ";
                        if (dollars % 10 > 0)
                        {
                            result += Ones[dollars % 10];
                        }
                    }
                }
                result += "dollars";
            }

            if (cents > 0)
            {
                if (result != "") result += " and ";
                if (cents < 20)
                {
                    result += Ones[cents];
                }
                else
                {
                    result += Tens[cents / 10 - 2] + " ";
                    if (cents % 10 > 0)
                    {
                        result += Ones[cents % 10];
                    }
                }
                result += "cents";
            }

            return result;
        }
    }
}
