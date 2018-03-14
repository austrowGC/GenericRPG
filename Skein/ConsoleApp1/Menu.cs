using System;
using System.Collections.Generic;
using System.Text;

namespace Skein
{
    public class Menu
    {

        public ConsoleKeyInfo AcquireInput()
        {
            return Console.ReadKey(true);
        }
    }
}
