
namespace Rotujici_prvocisla.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod] //Test, e èíslo není prvoèíslo
        public void TestMethod1()
        {
            // arrange
            int input = 8;
            bool expected = false;

            // act
            bool result = Pepa.isPrime(input);

            // assert
            Assert.IsFalse(result);
        }

        //Test, e èíslo je prvoèíslo
        public void TestMethod2()
        {
            // arrange
            int input = 7;
            bool expected = true;

            // act
            bool result = Pepa.isPrime(input);

            // assert
            Assert.IsTrue(result);
        }
    }
}