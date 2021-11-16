using System;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;

namespace Calculator.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void ShouldBeAbleToRunMain()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var str = new string[6]
            {
                "?","3","?","5","a","n"
            };
            var input = new StringReader(string.Join(Environment.NewLine, str));
            Console.SetIn(input);

            CalculatorProgram.Program.Main(new string[] { });

            var expectedResult = new string[14]
            {
                "Console Calculator in C#",
                "------------------------",
                "Type a number, and then press Enter: ",
                "This is not valid input. Please enter an integer value: ",
                "Type another number, and then press Enter: ",
                "This is not valid input. Please enter an integer value: ",
                "Choose an operator from the following list:",
                "a - Add",
                "s - Subtract",
                "m - Multiply",
                "d - Divide",
                "Your option? Your result: 8",
                "------------------------",
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: "
            };

            var result = output.ToString().Split(Environment.NewLine);
            
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Regex.Replace(result[i], @"[\r\t\n]+", string.Empty);
            }
            Assert.Equal(expectedResult, result);
        }
    }
}
