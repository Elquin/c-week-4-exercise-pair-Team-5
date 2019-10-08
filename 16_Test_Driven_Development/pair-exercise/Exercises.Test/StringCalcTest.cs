using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Test
{
    [TestClass]
    public class StringCalcTest
    {


        [DataTestMethod]
        [DataRow("", 0, DisplayName = "Empty String")] //First test will test for and empty string and return "0"
        [DataRow("1", 1, DisplayName = "One Number")]//If only a number is provided in the string, then the number should be returned.
        [DataRow("1,2", 3, DisplayName = "Comma Seperator")]//If more than one number is provided in the string, then the sums of the numbers should be returned.
        [DataRow("1\n2,3", 6, DisplayName = "\n Seperator")]//Returns sum using either comma or \n seperator
        [DataRow("5,4\n3\n2,1", 15, DisplayName = "Final Test")]//Testing for multiple instances of each delimitor

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
