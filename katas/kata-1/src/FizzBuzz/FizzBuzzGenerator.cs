namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                result.Add(i.ToString());
            }

            return result;
        }
    }
}