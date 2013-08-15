using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Speaking_First_Says_One()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void Speaking_Second_Says_Two()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(2);
            var expected = "2";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Third_Says_Fizz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(3);
            var expected = "Fizz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Five_Says_Buzz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(5);
            var expected = "Buzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Six_Says_Fizz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(6);
            var expected = "Fizz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Ten_Says_Buzz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(10);
            var expected = "Buzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Fifteen_Says_FizzBuzz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(15);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_Thirty_Says_FizzBuzz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(30);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Speaking_FourtyFive_Says_FizzBuzz()
        {
            var fizzbuzzSpeaker = new FizzbuzzSpeaker();
            var result = fizzbuzzSpeaker.Speak(45);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, result);
        }
    }
}