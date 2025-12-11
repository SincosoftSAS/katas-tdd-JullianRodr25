namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var resultList = new List<string>();

            for (var i = 1; i <= count; i++)
            {
                if (CheckDivisibilityByFifteen(i))
                    resultList.Add("FizzBuzz");
                else if (CheckDivisibilityByThree(i))
                    resultList.Add("Fizz");
                else if (CheckDivisibilityByFive(i))
                    resultList.Add("Buzz");
                else
                    resultList.Add(i.ToString());
            }

            return resultList;
        }

        private static bool CheckDivisibilityByFifteen(int i) => i % 15 == 0;

        private static bool CheckDivisibilityByFive(int i) => i % 5 == 0;

        private static bool CheckDivisibilityByThree(int i) => i % 3 == 0;
    }
}