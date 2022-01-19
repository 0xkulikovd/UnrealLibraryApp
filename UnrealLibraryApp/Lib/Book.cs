using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealLibraryApp.Lib
{
    public class Book
    {
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
        public string Year { get; set; } = "";
        public string Genre { get; set; } = "";
        public bool Readen { get; set; } = false;
        public int Mark { get; set; } = 0;
        public string Comment { get; set; } = "";
        public DateTime DayRead { get; set; } = DateTime.Now;

        public Book(string inputName)
        {
            this.Name = inputName;
        }
    }
}
