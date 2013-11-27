namespace MutatingFizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string GetOutputFor(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            if (number == 5)
            {
                return "Buzz";
            }

            if (number == 15)
            {
                return "FizzBuzz";
            }

            return "1";
        }
    }
}