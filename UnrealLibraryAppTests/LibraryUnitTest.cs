using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnrealLibraryApp.Lib;

namespace UnrealLibraryAppTests
{
    // А как же проверка сохранения и загрузки файла...
    [TestClass]
    public class LibraryUnitTest
    {
        [TestMethod]
        public void GetBookCountByMarkTest()
        {
            Library lib = new Library();
            Book b1 = new Book("book1")
            {
                Mark = 1
            };
            Book b2 = new Book("book2")
            {
                Mark = 3
            };
            int expected1 = 1;
            int expected3 = 3;
            int expected0 = 0;

            lib.Push(b1);
            lib.Push(b2);
            lib.Push(b2);
            lib.Push(b2);

            Assert.AreEqual(expected1, lib.GetBookCountByMark(1));
            Assert.AreEqual(expected3, lib.GetBookCountByMark(3));
            Assert.AreEqual(expected0, lib.GetBookCountByMark(0));
            Assert.ThrowsException<System.FormatException>(() => lib.GetBookCountByMark(-1));
        }
        
        [TestMethod]
        public void GetBookCountByReadTest()
        {
            Library lib = new Library();
            Book b1 = new Book("book1")
            {
                Readen = true
            };
            int expectedRead = 2;
            int expectedUnread = 0;

            lib.Push(b1);
            lib.Push(b1);

            Assert.AreEqual(expectedRead, lib.GetBookCountByRead(true));
            Assert.AreEqual(expectedUnread, lib.GetBookCountByRead(false));
        }

        [TestMethod]
        public void GetBookCountByCommentTest()
        {
            Library lib = new Library();
            Book b1 = new Book("book1")
            {
                Comment = "some comment"
            };
            Book b2 = new Book("book2");
            int expectedCommented = 3;
            int expectedUncommented = 2;

            lib.Push(b1);
            lib.Push(b1);
            lib.Push(b1);
            lib.Push(b2);
            lib.Push(b2);

            Assert.AreEqual(expectedCommented, lib.GetBookCountByComment(true));
            Assert.AreEqual(expectedUncommented, lib.GetBookCountByComment(false));
        }
    }
}
