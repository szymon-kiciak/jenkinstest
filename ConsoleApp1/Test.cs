using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Test : ITest
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
