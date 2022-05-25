using AuthTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = AuthTesting.Program.Something();
            Assert.AreEqual("Holaa Mundo", result);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = AuthTesting.Program.Login("hdeleon", "132456");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool result = AuthTesting.Program.Login("hdeleons", "132456");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue()
        {
            //Arrange
            int a = 4;
            int b = 5;
            int expected = 9;

            //Act
            int actual = Calcs.Sum(a, b);


            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Substract_ShouldCalcAndReturnSameValue()
        {
            //Arrange
            int a = 6;
            int b = 5;
            int expected = 1;

            //Act
            int actual = Calcs.Substract(a, b);


            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_ShouldCalcAndReturnSameValue()
        {
            //Arrange
            int a = 6;
            int b = 5;
            int expected = 30;

            //Act
            int actual = Calcs.Multiply(a, b);


            //Assert

            Assert.AreEqual(expected, actual);
        }

    }
}
