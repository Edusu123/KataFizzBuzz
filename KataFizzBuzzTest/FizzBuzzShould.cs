using KataFizzBuzz;

namespace KataFizzBuzzTest
{
    [TestClass]
    public class FizzBuzzShould
    {
        [TestMethod]
        public void Convert_1_to_1()
        {
            Assert.AreEqual("1", FizzBuzz.Convert(1));
        }
    }
}