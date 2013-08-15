namespace FizzBuzz
{
    public class FizzbuzzSpeaker
    {
        public string Speak(int number)
        {
            var result = string.Empty;
            if (number % 3 == 0) result += "Fizz";
            if (number % 5 == 0) result += "Buzz";
            
            return string.IsNullOrEmpty(result) 
                       ? number.ToString() : result;
        }
    }
}