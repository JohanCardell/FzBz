using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeLaborationOne;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CleanCodeLaborationOneTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void RunFizzBuzzTest()
        {
            //Arrange
            Program program = new Program();

            var notANumber = new MockConsole("not a number");
            var outOfBounds = new MockConsole("301");
            var withinBounds = new MockConsole("1");

            var expectedRejection = "Must enter a positive number between 1 and 300";
            var expectedAcceptance = "1" + Environment.NewLine; 
            
            //Act
            var actualInputNotANumber = program.RunFizzBuzz(notANumber);
            var actualOutOfBounds = program.RunFizzBuzz(outOfBounds);
            var actualWithinBounds = program.RunFizzBuzz(withinBounds);

            //Assert
            Assert.AreEqual(expectedRejection, actualInputNotANumber);
            Assert.AreEqual(expectedRejection, actualOutOfBounds);
            Assert.AreEqual(expectedAcceptance, actualWithinBounds);
        }

        [TestMethod()]
        public void RecursiveFizzBuzzCheckTest()
        {
            //Arrange
            Program program = new Program();
            
            var currentNumber = 1;
            var fizzAndBuzzNumber = 5;
            var concatenatedOutput = "";
            var fizzBuzzNumber = 15;
            var ultimateAnswerNumber = 42;

            var expectedOutputUpToFive =
                "1" + Environment.NewLine +
                "2" + Environment.NewLine +
                "Fizz" + Environment.NewLine +
                "4" + Environment.NewLine +
                "Buzz" + Environment.NewLine;
            var expectedFizzBuzz = "Fizzbuzz" + Environment.NewLine;
            var expectedUltimateAnswer = "Answer to the Ultimate Question of Life, the Universe, and Everything" + Environment.NewLine;
            
            //Act
            var actualUpToFive = program.RecursiveFizzBuzzCheck(currentNumber, fizzAndBuzzNumber, concatenatedOutput);
            var actualFizzBuzz = program.RecursiveFizzBuzzCheck(fizzBuzzNumber, fizzBuzzNumber, concatenatedOutput);
            var actualUltimateAnswer = program.RecursiveFizzBuzzCheck(ultimateAnswerNumber, ultimateAnswerNumber, concatenatedOutput);

            //Assert
            Assert.AreEqual(expectedOutputUpToFive, actualUpToFive);
            Assert.AreEqual(expectedFizzBuzz, actualFizzBuzz);
            Assert.AreEqual(expectedUltimateAnswer, actualUltimateAnswer);

        }
    }
}