using FizzBuzzCS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ShouldReturnFizzforThree()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldReturnBuzzforFive()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void ShouldReturnFizzBuzzforFifteen()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ShouldReturnFizzforMultiplesOfThree(
                [Values(3, 6, 9, 12, 18, 21, 24, 27)] int x)
        {
            Assert.That(Program.FizzBuzz(x), Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldReturnBuzzforMultiplesOfFive(
        [Values(5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 95)] int x)
        {
            Assert.That(Program.FizzBuzz(x), Is.EqualTo("Buzz"));
        }

        [Test]
        public void ShouldReturnFizzBuzzforMultiplesOfFifteen(
                [Values(15,30,45,60,75,90)] int x)
        {
            Assert.That(Program.FizzBuzz(30), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ShouldReturnNumberforAnyOtherNbs()
        {
            Assert.That(Program.FizzBuzz(7), Is.EqualTo("7"));
        }

    }
}
