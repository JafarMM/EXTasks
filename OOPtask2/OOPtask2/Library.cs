using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class Library
    {
        Book book = new Book()
        {
            Author = "Dostoyevski",
            Title = "Such ve Ceza",
            PublishYear = 1865
        };
        public override string ToString()
        {
            return $"Yazar: {book.Author}Adı: {book.Title}Chap olunma tarixi: {book.PublishYear}";
        }

    }
}