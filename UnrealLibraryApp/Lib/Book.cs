using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealLibraryApp.Lib
{
    public class Book
    {
        private string name = "";
        private string author = "";
        private string year = "";
        private string genre = "";
        private bool readen = false;
        private int mark = 0;
        private string comment = "";
        private DateTime dayRead = DateTime.Now;

        public Book()
        {

        }

        public Book(string inputName)
        {
            this.Name = inputName;
        }
        public Book(string inputName, string inputAuthor, string inputYear, string inputGenre)
        {
            this.Name = inputName;
            this.Author = inputAuthor;
            this.Year = inputYear;
            this.Genre = inputGenre;
        }

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Year { get => year; set => year = value; }
        public string Genre { get => genre; set => genre = value; }
        public bool Readen { get => readen; set => readen = value; }
        public int Mark { get => mark; set => mark = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime DayRead { get => dayRead; set => dayRead = value; }
    }
}
