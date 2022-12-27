using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BookInventoryFormPresentationModel
    {
        Library _library;
        List<BookItem> _bookItems = new List<BookItem>();
        List<BookCategory> _bookCategories = new List<BookCategory>();
        public BookInventoryFormPresentationModel(Library library)
        {
            _library = library;
        }

        //初始化
        public void Initialize()
        {
            _bookItems = _library.GetBookItems();
            _bookCategories = _library.GetBookCategories();
        }

        //取得GridView資訊
        public List<List<string>> GetGridViewInformation()
        {
            List<List<string>> result = new List<List<string>>();
            for (int i = 0; i < _bookItems.Count(); i++)
            {
                List<string> temp = new List<string>();
                temp.Add(_bookItems[i].NAME);
                temp.Add(_bookCategories[i].CATEGORY);
                temp.Add(_bookItems[i].REMAIN.ToString());
                result.Add(temp);
            }
            return result;
        }

        //設置圖片
        public string GetPicture(int index)
        {
            return _bookItems[index].COVER;
        }

        //設置資訊
        public string GetInformation(int index)
        {
            return _bookItems[index].INFORMATION;
        }

        //取得bookItemCount
        public int GetBookItemCount()
        {
            return _bookItems.Count();
        }
    }
}
