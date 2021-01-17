using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public byte Age { set; get; }

        Library library = new Library();

        public string myFavoriteBook
        {
            get
            {
                return library.ToString();
            }
            set
            {

            }
        }

        public Person(string firstname, string lastname, byte age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }
    }
}