using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BookAddFormPresentationModel
    {
        private Library _library;
        private BookItem _bookItem;
        private BookCategory _bookCategory;

        public BookAddFormPresentationModel(Library library, int index)
        {
            _library = library;
            _bookItem = _library.GetBookItems()[index];
            _bookCategory = _library.GetBookCategories()[index];
        }

        //取得書籍資訊
        public string GetInformation()
        {
            string result = "";
            result += "書籍名稱：" + _bookItem.NAME + Constant.END + Constant.END;
            result += "書籍類別：" + _bookCategory.CATEGORY + Constant.END;
            result += "庫存數量：" + _bookItem.REMAIN.ToString();
            return result;
        }
        
        //還書
        public bool AddRemain(string quantity)
        {
            if (quantity.All(char.IsDigit))
            {
                int temp = int.Parse(quantity);
                _bookItem.REMAIN += int.Parse(quantity);
                return true;
            }
            else
                return false;      
        }
    }
}
