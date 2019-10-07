using System;
using System.Collections.Generic;
using System.Text;

namespace HW18
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        [Price("Цена книги")]
        public int Price { get; set; }
        public int Year { get; set; }
    }
}
