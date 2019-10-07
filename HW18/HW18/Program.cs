using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>()
            {
                new Book
                {
                    Name = "Сказки",
                    Author = "Пушкин",
                    Price = 1000,
                    Year = 1992
                },
                new Book
                {
                    Name = "Рассказы",
                    Author = "Лермонтов",
                    Price = 1200,
                    Year = 1990
                },
                new Book
                {
                    Name = "Стихи",
                    Author = "Блок",
                    Price = 800,
                    Year = 1995
                },
            };

            var serialize = new BinaryFormatter();
            if (File.Exists("listSerial.dat"))
            {
                Console.WriteLine("Файл будет перезаписан");
            }

            using (var stream = new FileStream("listSerial.dat", FileMode.OpenOrCreate))
            {
                serialize.Serialize(stream, books);
                Console.WriteLine("Сериализация произведена успешна!");
            }


            // #2.
            //var serialize = new BinaryFormatter();
            //List<Book> booksNew = new List<Book>();
            //using (var stream = new FileStream("listSerial.dat", FileMode.OpenOrCreate))
            //{
            //    booksNew = serialize.Deserialize(stream) as List<Book>;
            //    Console.WriteLine("Десериализация произведена успешна!");
            //}

            //foreach (var book in booksNew)
            //{
            //    Console.WriteLine(book.Name);
            //    Console.WriteLine(book.Author);
            //    Console.WriteLine(book.Price);
            //    Console.WriteLine(book.Year);
            //    Console.WriteLine();
            //}

            //Console.Read();
        }
    }
}
