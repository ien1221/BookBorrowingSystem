using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingSystem
{
    public class BookBorrowingFormPresentationModel
    {
        private Library _library;
        private List<BookItem> _bookItems = null;
        private List<BookCategory> _bookCategories = null;
        private BookItem _currentSelected;
        private BorrowList _borrowList = new BorrowList();
        private BorrowList _borrowedList = null;
        private List<int> _borrowQuantity = new List<int>();
        private List<string> _categories = null;
        private int _currentPage = 0;
        private int _maxPage = 0;
        private int _buttonQuantity = 0;
        bool _borrowed = false;

        public BookBorrowingFormPresentationModel(Library library)
        {
            _library = library;
            _bookItems = _library.GetBookItems();
            _bookCategories = _library.GetBookCategories();
            _categories = _library.GetCategoryList();
        }

        //重置資訊
        public bool RefreshInformation(int quantity, string bookName)
        {
            foreach (BookItem book in _bookItems)
            {
                if (book.NAME == bookName)
                {
                    if (book.REMAIN < quantity)
                        return false;
                }
            }
            for (int i = 0; i < _borrowList.COUNT; i++)
            {
                BorrowedItem borrowedItem = _borrowList.GetBorrowedItem(i);
                if (borrowedItem.BOOK.NAME == bookName)
                {
                    borrowedItem.QUANTITY = quantity;
                }
            }
            return true;
        }

        //下一頁
        public void ClickNextPage()
        {
            _currentPage += 1;
        }

        //上一頁
        public void ClickPreviousPage()
        {
            _currentPage -= 1;
        }

        //重置頁面
        public void ResetPage(string category)
        {
            _currentPage = 0;
            _maxPage = 0;
            _buttonQuantity = 0;
            SetButtonQuantity(category);
        }
        
        //重置頁面
        public void ResetPage()
        {
            _currentPage = 0;
            _maxPage = 0;
            _buttonQuantity = 0;
            SetButtonQuantity(_categories[0]);
        }

        //取得當前頁面
        public int GetCurrentPage()
        {
            return _currentPage;
        }

        //取得按鈕編號
        public int GetButtonIndex(int index)
        {
            return index + _currentPage * Constant.THREE;
        }

        //取得按鈕數量
        public void SetButtonQuantity(string category)
        {
            foreach (BookCategory bookCategory in _bookCategories)
            {
                if (bookCategory.CATEGORY == category)
                    _buttonQuantity++;
            }
            if (_buttonQuantity % Constant.THREE == 0)
                _maxPage = _buttonQuantity / Constant.THREE;
            else
                _maxPage = _buttonQuantity / Constant.THREE + Constant.ONE;
        }

        //取得按鈕數量
        public int GetButtonCount(string category)
        {
            int result = 0;
            result = _buttonQuantity - _currentPage * Constant.THREE;
            if (result >= Constant.THREE || result == 0)
                return Constant.THREE;
            return result;
        }

        //設置資訊
        public string SetCurrentPage()
        {
            return "當前頁數：" + (_currentPage + 1).ToString() + " / " + _maxPage.ToString();
        }

        //設置當前選擇書籍
        public BookItem SetSelected(int buttonIndex, int pageIndex)
        {
            FindCurrentSelected(buttonIndex, pageIndex);
            return _currentSelected;
        }

        //更改按鈕狀態
        public bool IsPreviousEnable()
        {
            if (_currentPage == 0)
                return false;
            return true;
        }

        //更改按鈕狀態
        public bool IsNextEnable()
        {
            if (_currentPage == _maxPage - 1)
                return false;
            return true;
        }

        //取得按鈕圖片
        public string GetButtonImage(int buttonIndex, int pageIndex)
        {
            FindCurrentSelected(buttonIndex, pageIndex);
            string path = _currentSelected.COVER;
            return path;
        }

        //增加書籍至借書單
        public bool AddBorrowList()
        {
            BorrowedItem borrowedItem = new BorrowedItem();
            borrowedItem.BOOK = _currentSelected.BOOK;
            if (_borrowList.COUNT == 0)
                _borrowList.AddToBorrowedList(borrowedItem);
            else
            {
                if (!IsBorrowed(borrowedItem))
                    _borrowList.AddToBorrowedList(borrowedItem);
            }
            return _borrowed;
        }

        //移除借書
        public void RemoveBorrow(int index)
        {
            _borrowList.Remove(index);
        }

        //確認當前書籍是否已被借閱
        private bool IsBorrowed(BorrowedItem borrowedItem)
        {
            _borrowed = false;
            for (int i = 0; i < _borrowList.COUNT; i++)
                if (borrowedItem.BOOK == _borrowList.GetBorrowedItem(i).BOOK)
                    _borrowed = true;

            if (_borrowedList != null)
                for (int i = 0; i < _borrowedList.COUNT; i++)
                    if (borrowedItem.BOOK == _borrowedList.GetBorrowedItem(i).BOOK)
                        _borrowed = true;
            return _borrowed;
        }

        //更改按鈕狀態
        public bool IsCheckBackPackEnable()
        {
            return false;
        }

        //檢查借書單是否已滿
        public bool IsMoreThanFive()
        {
            if (_borrowList.BOOKS + 1 > Constant.FIVE)
            {
                return true;
            }
            else
                return false;
        }

        //檢查庫存
        public int CheckRemain(int quantity, string bookName)
        {
            foreach (BookItem bookItem in _bookItems)
                if (bookItem.NAME == bookName)
                    if (bookItem.REMAIN < quantity)
                        return 1;
                    else
                        break;
            if (quantity > Constant.TWO)
                return Constant.TWO;
            return Constant.THREE;
        }

        //取得當前借書數量
        public string GetBorrowingCount()
        {
            string result = "";
            result = Constant.BORROW + _borrowList.BOOKS.ToString();
            return result;
        }

        //判斷借書鈕可否使用
        public bool IsAddToBorrowingListEnable()
        {
            if (!_borrowed)
                return true;
            else
                return false;
        }

        //確認是否可送出借書單
        public bool IsCheckBorrowingListEnable()
        {
            if (_borrowList.COUNT <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //取得類別名稱
        public string GetTabPageName(string name)
        {
            return name;
        }

        //取得編號
        public int GetTabIndex(int index)
        {
            return index;
        }

        //取得按鈕名稱
        public string GetButtonName(int index)
        {
            return Constant.BUTTON + (index + 1).ToString();
        }

        //取得借書單
        public BorrowList GetBorrowList()
        {
            return _borrowList;
        }

        //取得當前選擇書籍
        public BookItem GetSelected()
        {
            return _currentSelected;
        }

        //取得資訊
        public List<string> GetCurrentInformation()
        {
            List<string> result = new List<string>();
            result.Add(_currentSelected.NAME);
            result.Add(_currentSelected.NUMBER);
            result.Add(_currentSelected.WRITER);
            result.Add(_currentSelected.PUBLICATION);
            return result;
        }

        //尋找當前書籍
        private void FindCurrentSelected(int buttonIndex, int pageIndex)
        {
            _currentSelected = _library.FindCurrentSelected(buttonIndex, pageIndex);
        }

        //重製borrowed參數
        public void ResetBorrowed(BookItem selected)
        {
            BorrowedItem borrowed = new BorrowedItem();
            borrowed.BOOK = selected.BOOK;
            IsBorrowed(borrowed);
        }

        //送出借書單
        public string CheckBorrowingList()
        {
            string result = "";
            BorrowedItem temp;
            _library.SetBorrowedList(_borrowList);
            for (int i = 0; i < _borrowList.COUNT; i++)
            {
                temp = _borrowList.GetBorrowedItem(i);
                result += "【" + temp.BOOK.NAME + "】" + temp.QUANTITY.ToString() + "本、";
            }
            result = result.Substring(0, result.LastIndexOf("、"));
            result += Constant.END + Constant.END + Constant.SUCCESS;
            _borrowList.Clear();
            _borrowedList = _library.GetBorrowedList();
            return result;
        }

        //更改按鈕狀態
        public bool EnableBackPackButton()
        {
            return true;
        }

        //取得資訊
        public List<string> GetBorrowListInformation(int index)
        {
            List<String> temp = new List<string>();
            temp.Add(_borrowList.GetBorrowedItem(index).BOOK.NAME);
            temp.Add(_borrowList.GetBorrowedItem(index).BOOK.NUMBER);
            temp.Add(_borrowList.GetBorrowedItem(index).BOOK.WRITER);
            temp.Add(_borrowList.GetBorrowedItem(index).BOOK.PUBLICATION);
            return temp;
        }
    }
}
