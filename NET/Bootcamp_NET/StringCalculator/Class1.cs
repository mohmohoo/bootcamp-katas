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
            foreach (var s in strArry)
            {
                if (int.TryParse(s, out int res)) 
                {
                    output += res;
                }
            }

            return output;
        }
    }
}
