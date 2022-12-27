using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BookCategory
    {
        private Book _book = new Book();
        private string _category;

        public string CATEGORY
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public string NAME
        {
            set
            {
                _book.NAME = value;
            }
        }

        public string NUMBER
        {
            set
            {
                _book.NUMBER = value;
            }
        }

        public string WRITER
        {
            set
            {
                _book.WRITER = value;
            }
        }

        public string PUBLICATION
        {
            set
            {
                _book.PUBLICATION = value;
            }
        }

        public string COVER
        {

            set
            {
                _book.COVER = value;
            }
        }
    }
}
