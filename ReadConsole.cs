using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLaborationOne
{
    public class ReadConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
