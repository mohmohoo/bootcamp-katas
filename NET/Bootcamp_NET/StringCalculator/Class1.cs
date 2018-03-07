namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            var strArry = str.Split(',');
            var output = 0;
            var allowedInts = 1;
            foreach (var s in strArry)
            {
                if (int.TryParse(s, out int res) && allowedInts <= 2) 
                {
                    output += res;
                    allowedInts++;
                }
            }

            return output;
        }
    }
}
