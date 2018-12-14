using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        public string author;
        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Author: " + author);
        }

    }
}
