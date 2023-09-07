using _6UzduotisWhile_UnitTesting;

namespace Test_6Uzduotis_while
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Factorial()
        {
            int num = 5;
            int expected = 120;
            int actual = Program.CalculateFactorial(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial2()
        {
            int num = 6;
            int expected = 720;
            int actual = Program.CalculateFactorial(num);
            Assert.AreEqual(expected, actual);
        }
    }
}