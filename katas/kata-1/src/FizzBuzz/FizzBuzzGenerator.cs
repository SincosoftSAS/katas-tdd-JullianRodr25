namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var resultList = new List<string>();

            for (var i = 1; i <= count; i++)
            {
                if (i == 3)
                    resultList.Add("Fizz");
                else if (i == 5)
                    resultList.Add("Buzz");
                else
                    resultList.Add(i.ToString());
            }

            return resultList;
        }
    }
}