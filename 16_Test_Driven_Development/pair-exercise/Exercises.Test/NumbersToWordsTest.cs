using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Test
{
     [TestClass]
     public class NumbersToWordsTest
    {
    
        [DataTestMethod]
        [DataRow(1, "one")] //Testing for converting int 1 to string "one"

        public void NumberString(int numberToTest, string expectedResult)
        {
            //Arrange
            // Create a NumberToWords Object
            NumbersToWords number = new NumbersToWords();

            //Act
            string actualResult = number.NumberString(numberToTest);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
