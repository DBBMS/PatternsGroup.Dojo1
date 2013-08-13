using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Speaking_Fifteenth_Should_Say_FizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(15);
            string expected = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Fifth_Should_Say_Buzz()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(5);
            string expected = "Buzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_First_Should_Say_One()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(1);
            string expected = "1";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Ninth_Should_Say_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(9);
            string expected = "Fizz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Second_Should_Say_Two()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(2);
            string expected = "2";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Sixth_Should_Say_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(6);
            string expected = "Fizz";
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void Speaking_Tenth_Should_Say_Buzz()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(10);
            string expected = "Buzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Third_Should_Say_Three()
        {
            var fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Speak(3);
            string expected = "Fizz";
            Assert.AreEqual(expected, result);
        }
    }
}