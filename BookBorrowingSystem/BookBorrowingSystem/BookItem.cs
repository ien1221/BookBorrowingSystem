using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BookItem
    {
        private Book _book = new Book();
        private int _remain;
        private int _index;

        public Book BOOK
        {
            get
            {
                return _book;
            }
        }

        public int REMAIN
        {
            get
            {
                return _remain;
            }
            set
            {
                _remain = value;
            }
        }

        public string INFORMATION
        {
            get
            {
                return _book.GetInformation();
            }
        }

        public int INDEX
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        public string NAME
        {
            get
            {
                return _book.NAME;
            }
            set
            {
                _book.NAME = value;
            }
        }

        public string NUMBER
        {
            get
            {
                return _book.NUMBER;
            }
            set
            {
                _book.NUMBER = value;
            }
        }

        public string WRITER
        {
            get
            {
                return _book.WRITER;
            }
            set
            {
                _book.WRITER = value;
            }
        }

        public string PUBLICATION
        {
            get
            {
                return _book.PUBLICATION;
            }
            set
            {
                _book.PUBLICATION = value;
            }
        }

        public string COVER
        {
            get
            {
                return _book.COVER;
            }

            set
            {
                _book.COVER = value;
            }
        }
    }
}
