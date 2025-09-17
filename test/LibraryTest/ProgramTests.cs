using NUnit.Framework;
using Library;

namespace LibraryTest
{
    public class Tests
    {
        [Test]
        [TestCase("There is a bomb.", ExpectedResult = "Duck!!!")]
        [TestCase("Hey, did you think there is a bomb?", ExpectedResult = "Duck!!!")]
        [TestCase("This goes boom!!!", ExpectedResult = "There is no bomb, relax.")]
        public static string FixedTest(string str1)
        {
            return Program.Bomb(str1);
        }
    }
}