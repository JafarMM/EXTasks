using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    interface IPopSinger : ISinger
    {
        void GoMoonwalk()
        {
            Console.WriteLine("Going moonwalk");
        }
    }
}