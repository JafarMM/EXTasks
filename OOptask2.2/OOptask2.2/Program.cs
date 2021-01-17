using HomeWork3.Singers;
using System;
using System.Text;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPopSinger popSinger = new PopSinger()
            {
                name = "Sevda",
                surname = "Yahyayeva"
            };
            IRockSinger rockSinger = new RockSinger()
            {
                name = "Brithan",
                surname = "Sherloth"
            };
            ISinger singer = new Singer()
            {
                name = "Polad",
                surname = "Bulbuloglu"
            };

            popSinger.GoMoonwalk();
            rockSinger.SwingGuitar();
            singer.RecordSing();

        }
    }
}