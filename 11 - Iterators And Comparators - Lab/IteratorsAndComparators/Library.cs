using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = new List<Book>(books.ToList());
        }
        private List<Book> books;

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }


        public IEnumerator<Book> GetEnumerator()
        {
            
            return new LibraryIterator(this.books);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex = -1;
            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }

            public object Current => books[currentIndex];

            Book IEnumerator<Book>.Current => books[currentIndex];

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
