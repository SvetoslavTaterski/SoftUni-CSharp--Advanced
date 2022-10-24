﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }


        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
                this.books.Sort(new BookComparator());
                currentIndex = -1;
            }
            public Book Current
            {
                get { return books[currentIndex]; }
            }
            object IEnumerator.Current => this.Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {

            }
        }
    }

}
