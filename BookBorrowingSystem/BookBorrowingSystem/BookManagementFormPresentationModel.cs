using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BookManagementFormPresentationModel
    {
        Library _library;
        List<BookItem> _bookItems = new List<BookItem>();
        List<BookCategory> _bookCategories = new List<BookCategory>();
        List<string> _bookInformation = new List<string>();
        BookItem _selected;
        BookCategory _selectedCategory;

        public BookManagementFormPresentationModel(Library library)
        {
            _library = library;
            _bookItems = _library.GetBookItems();
            _bookCategories = _library.GetBookCategories();
        }

        //取得所有書名
        public List<String> GetBookNameList()
        {
            List<string> result = new List<string>();
            foreach (BookItem bookItem in _bookItems)
                result.Add(bookItem.NAME);
            return result;
        }

        //getSelected
        public BookItem GetSelected()
        {
            return _selected;
        }
        
        //尋找目前選中的書籍
        public void FineCurrentSelectedBook(int index)
        {
            _selected = _bookItems[index];
            _selectedCategory = _bookCategories[index];
            if (_bookInformation.Count != 0)
                _bookInformation.Clear();
            _bookInformation.Add(_selected.NAME);
            _bookInformation.Add(_selected.NUMBER);
            _bookInformation.Add(_selected.WRITER);
            _bookInformation.Add(_selectedCategory.CATEGORY);
            _bookInformation.Add(_selected.PUBLICATION);
            string cover = _selected.COVER.Split(Constant.SLASH).Last();
            _bookInformation.Add(cover);
        }

        //取得書本資訊
        public List<string> GetBookInformation()
        {
            return _bookInformation;
        }

        //確認書籍資訊是否變更
        public bool IsInformationChanged(List<string> information)
        {
            //if (information[0] == _bookInformation[0] || information[0] == "")
            //    return false;
            //if (information[1] == _bookInformation[1] || information[1] == "")
            //    return false;
            //if (information[Constant.TWO] == _bookInformation[Constant.TWO] || information[Constant.TWO] == "")
            //    return false;
            //if (information[Constant.THREE] == _bookInformation[Constant.THREE] || information[Constant.THREE] == "")
            //    return false;
            //if (information[Constant.FOUR] == _bookInformation[Constant.FOUR] || information[Constant.FOUR] == "")
            //    return false;
            //if (information[Constant.FIVE] == "../../../image/" + _bookInformation[Constant.FIVE] || information[Constant.FIVE] == "")
            //    return false;
            return true;
        }

        //儲存訊息
        public void StoreInformation(List<string> information)
        {
            _selected.NAME = information[0];
            _selected.NUMBER = information[Constant.ONE];
            _selected.WRITER = information[Constant.TWO];
            _selectedCategory.CATEGORY = information[Constant.THREE];
            _selected.PUBLICATION = information[Constant.FOUR];
            _selected.COVER = information[Constant.FIVE].Split(Constant.DOT)[0];
        }

        //擷取路徑
        public string SetCoverText(string cover)
        {
            return cover.Split(Constant.BACK).Last();
        }

        //enable
        public bool Enable()
        {
            return true;
        }

        //disable
        public bool Disable()
        {
            return false;
        }
    }
}
