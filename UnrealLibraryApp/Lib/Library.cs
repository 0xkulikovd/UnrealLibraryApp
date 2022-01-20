using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealLibraryApp.Lib
{
    public class Library /*: IEnumerable*/
    {
        private List<Book> shelf;

        public IEnumerator<Book> GetEnumerator()
        {
            return shelf.GetEnumerator();
        }
        public Library()
        {
            this.shelf = new List<Book>();
        }

        public int Count
        {
            get
            {
                return shelf.Count;
            }
        }

        public List<Book> Books
        {
            get
            {
                return shelf;
            }
        }

        // Катастрофичкски мало запросов

        public int GetBookCountByRead(bool b)
        {
                return this.Books.Where(t => t.Readen.Equals(b)).Count();
        }

        public int GetBookCountByMark(int m)
        {
            if (m > 5 | m < 0)
            {
                throw new FormatException();
            }
            else
            {
                //this.Books.Count(t => t.Mark.Equals(m));
                return this.Books.Where(t => t.Mark.Equals(m)).Count();
            }
        }

        public int GetBookCountByComment(bool b)
        {
            // А если просто b поставить?
            // var readedBooks = this.Books.Count(t => t.Comment.Equals(""))
            // return b
            //  ? this.Count - readedBooks
            //  : readedBooks 
            if (b == true)
            {
                return this.Count - this.Books.Where(t => t.Comment.Equals("")).Count();
            }
            else
            {
                return this.Books.Where(t => t.Comment.Equals("")).Count();
            }
        }

        public void Push(Book inputBook)
        {
            shelf.Add(inputBook);
        }

        public Book Pull(int number)
        {
            return shelf[number];
        }

        public void Delete(int number)
        {
            shelf.RemoveAt(number);
        }
    }
}
