﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Some book", "Nemo", "About nothing");
            book.Show();
            Console.ReadKey();
        }
    }
}
