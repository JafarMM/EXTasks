using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Singers
{
    class RockSinger : IRockSinger
    {
        public string name { set; get; }
        public string surname { set; get; }
        public void RecordSing()
        {
            Console.WriteLine("Recording Rock song");
        }
    }
}