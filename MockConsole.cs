using CleanCodeLaborationOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLaborationOneTests
{
    public class MockConsole : IConsole
    {
        private string _mockInput;

        public MockConsole(string mockInput)
        {
            _mockInput = mockInput;
        }
        public string ReadLine()
        {
            return _mockInput;
        }
    }
}
