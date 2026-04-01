using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Домашняя библиотека");

        List<string> books = new List<string>
        {
            "1984",
            "Мастер и Маргарита",
            "Гарри Поттер"
        };

        Console.WriteLine("Список книг:");
        foreach (var book in books)
        {
            Console.WriteLine("- " + book);
        }
    }
}




