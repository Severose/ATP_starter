using NUnit.Framework;

namespace csharp
{
    public class FizzbuzzProg
    {
        public static string Fizzbuzz (int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }

        public static void Main (string[] Args)
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(Fizzbuzz(i));
            }
        }
    }

    [TestFixture]
    public class FizzbuzzTest
    {
        [Test]
        public void NonThree_NonFive_Prints_Itself()
        {
            Assert.AreEqual("4", FizzbuzzProg.Fizzbuzz(4));
        }

        [Test]
        public void DivisibleByThree_Prints_Fizz()
        {
            Assert.AreEqual("Fizz", FizzbuzzProg.Fizzbuzz(6));
        }

        [Test]
        public void DivisibleByThree_Prints_Buzz()
        {
            Assert.AreEqual("Buzz", FizzbuzzProg.Fizzbuzz(10));
        }

        [Test]
        public void DivisibleByThree_DivisibleByFive_Prints_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzbuzzProg.Fizzbuzz(30));
        }
    }
}