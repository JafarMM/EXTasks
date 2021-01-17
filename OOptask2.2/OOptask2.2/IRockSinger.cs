using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    interface IRockSinger : ISinger
    {
        void SwingGuitar()
        {
            Console.WriteLine("Swinging guitar");
        }
    }
}