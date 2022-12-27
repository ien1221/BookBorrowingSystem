using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BorrowedItem
    {
        private Book _book = new Book();
        private DateTime _borrowDate;
        private DateTime _returnDate;
        private int _quantity = 1;

        public BorrowedItem()
        {
            _borrowDate = DateTime.Now;
            _returnDate = _borrowDate.AddDays(Constant.THIRTY);
        }

        public int QUANTITY
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public DateTime BORROW
        {
            get
            {
                return _borrowDate;
            }
        }

        public DateTime RETURN
        {
            get
            {
                return _returnDate;
            }
        }

        public Book BOOK
        {
            get
            {
                return _book;
            }
            set
            {
                _book = value;
            }
        }
    }
}
