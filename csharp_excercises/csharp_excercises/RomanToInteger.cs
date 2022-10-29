namespace csharp_excercises
{
    public class RomanToInteger
    {
        public static int RomanToDecimal(string romanNumber)
        {
            var total = 0;
            var symbols = romanNumber.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                var firstValue = GetSymbolValue(symbols[i]);
                if (i + 1 < symbols.Length)
                {
                    var secondValue = GetSymbolValue(symbols[i + 1]);
                    if (firstValue >= secondValue)
                    {
                        total += firstValue;
                    }
                    else
                    {
                        total = total + secondValue - firstValue;
                        i++;
                    }
                }
                else
                {
                    total += firstValue;
                }
            }
            return total;
        }


        private static int GetSymbolValue(char symbol)
        {
            var symbolValues = new List<KeyValuePair<char, int>>
            {
                new KeyValuePair<char, int>('I', 1),
                new KeyValuePair<char, int>('V', 5),
                new KeyValuePair<char, int>('X', 10),
                new KeyValuePair<char, int>('L', 50),
                new KeyValuePair<char, int>('C', 100),
                new KeyValuePair<char, int>('D', 500),
                new KeyValuePair<char, int>('M', 1000)
            };
            return symbolValues.SingleOrDefault(s => s.Key == symbol).Value;
        }
    }
}
