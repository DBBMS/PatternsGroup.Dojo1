namespace FizzBuzz
{
    public class FizzBuzzStudent
    {
        public string Speak(int i)
        {
            string result = string.Empty;
            if (i%3 == 0)
            {
                result = "Fizz";
            }

            if (i%5 == 0)
            {
                result += "Buzz";
            }
            
            return result.Length > 0 ? result : i.ToString();
        }
    }
}