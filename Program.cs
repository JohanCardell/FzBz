using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CleanCodeLaborationOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            IConsole console = new ReadConsole();
            Console.WriteLine(program.RunFizzBuzz(console));
        }

        public string RunFizzBuzz(IConsole console)
        {
            const int MINNUMBER = 1;
            const int MAXNUMBER = 300;
            int inputNumber;
            var userInput = console.ReadLine();
            var isNumber = int.TryParse(userInput, out inputNumber);

            if (!isNumber || inputNumber < MINNUMBER || inputNumber > MAXNUMBER)
            {
                return "Must enter a positive number between 1 and 300";
            }
            else
            { 
                string concatenatedString = "";
                int currentNumber = 1;
                return RecursiveFizzBuzzCheck(currentNumber, inputNumber, concatenatedString);
            }
        }

        public string RecursiveFizzBuzzCheck(int currentNumber, int maxNumber, string concatenatedOutput)
        {
            if(currentNumber == 42)
            {
                concatenatedOutput += "Answer to the Ultimate Question of Life, the Universe, and Everything" + Environment.NewLine;
            }
            else if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
            {
                concatenatedOutput += "Fizzbuzz" + Environment.NewLine;
            }
            else if(currentNumber % 5 == 0)
            {
                concatenatedOutput += "Buzz" + Environment.NewLine;
            }
            else if (currentNumber % 3 == 0)
            {
                concatenatedOutput += "Fizz" + Environment.NewLine;
            }
            else
            {
                concatenatedOutput += currentNumber.ToString() + Environment.NewLine;
            }
           
            if (currentNumber < maxNumber)
            {
                return RecursiveFizzBuzzCheck(currentNumber + 1, maxNumber, concatenatedOutput);
            }
            else
            {
                return concatenatedOutput;
            }
        }
    }
}
