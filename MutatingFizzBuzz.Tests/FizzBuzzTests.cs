using NUnit.Framework;
using NinjaTurtles;

namespace MutatingFizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzzGivesCorrectOutputFor(int number, string expectedOutput)
        {
            Assert.That(new FizzBuzz().GetOutputFor(number), Is.EqualTo(expectedOutput));
        }
    }

    [TestFixture]
    public class FizzBuzzMutationTests
    {
        [Test, MutationTest]
        public void GivesCorrectOutputForMutationTests()
        {
            MutationTestBuilder<FizzBuzz>.For("GetOutputFor").Run();
        }
        
    }

}
