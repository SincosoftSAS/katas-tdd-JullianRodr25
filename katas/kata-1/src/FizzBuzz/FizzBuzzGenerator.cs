namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var  resultList = new List<string>();

            for (var i = 1; i <= count; i++)
            {
                resultList.Add(i.ToString());
            }

            return resultList;
        }
    }
}