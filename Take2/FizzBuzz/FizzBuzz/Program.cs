using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FizzbuzzSpeaker speaker = new FizzbuzzSpeaker();
            for(int index =1; index<= 100; index++)
            {
                Console.WriteLine(speaker.Speak(index));
            }
        }
    }
}