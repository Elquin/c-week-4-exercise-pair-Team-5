using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalcTest
    {


        [DataTestMethod]
        [DataRow("", 0)] //First test will test for and empty string and return "0"
        [DataRow("1", 1)]//If only a number is provided in the string, then the number should be returned.
        public void EmptyString(string stringToTest, int expectedResult)
        {
            //Arrange
            // Create a StringCalculatorKata object
            StringCalculatorKata value = new StringCalculatorKata();

            //Act
            int actualResult = value.EmptyString(stringToTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
