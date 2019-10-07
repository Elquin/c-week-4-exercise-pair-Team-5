using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalcTest
    {


        [DataTestMethod]
        [DataRow("", 0)] //First test will test for and empty string and return "0"
        public void EmptyString(string stringToTest, int expectedResult)
        {
            //Arrange
            // Create a new KataFizzBuzz Object
            StringCalculatorKata value = new StringCalculatorKata();

            //Act
            string actualResult = value.EmptyString(stringToTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
