using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    interface ISinger
    {
        void Sing()
        {
            Console.WriteLine("Singing...");
        }
        void RecordSing();
    }
}