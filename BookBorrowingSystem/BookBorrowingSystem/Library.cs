using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BookBorrowingSystem
{
    public class Library
    {
        private BookItem _bookItem = new BookItem();
        private BookCategory _bookCategory = new BookCategory();
        private List<BookItem> _bookItems = new List<BookItem>();
        private List<BookCategory> _bookCategories = new List<BookCategory>();
        private List<string> _categoryList = new List<string>();
        private BorrowList _borrowedList = new BorrowList();
        private BookItem _selected = new BookItem();
        private int _index = 0;

        public Library(string fileName)
        {
            ReadFile(fileName);
            SetCategoryList();
        }
        //尋找共有幾種類別
        private void SetCategoryList()
        {
            bool exist = false;
            string current;
            _categoryList.Add(_bookCategories[0].CATEGORY);
            for (int i = 0; i < _bookCategories.Count(); i++)
            {
                current = _bookCategories[i].CATEGORY;
                IsExist(current, ref exist);
                if (!exist)
                {
                    _categoryList.Add(current);
                }
                else
                {
                    exist = false;
                }
            }
        }

        //尋找類別
        private void IsExist(string current, ref bool exist)
        {
            for (int i = 0; i < _categoryList.Count; i++)
            {
                if (current == _categoryList[i])
                    exist = true;
            }

        }

        //input txt file
        public void ReadFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                if (line == Constant.BOOK)
                {
                    _bookItem.REMAIN = int.Parse(file.ReadLine());
                    _bookCategory.CATEGORY = file.ReadLine();
                    _bookItem.NAME = file.ReadLine();
                    _bookItem.NUMBER = file.ReadLine();
                    _bookItem.WRITER = file.ReadLine();
                    _bookItem.PUBLICATION = file.ReadLine();
                    _bookItem.INDEX = _index;
                    _bookItem.COVER = (_index + 1).ToString();
                    ResetBookItem();
                }
            }
        }

        //取得按鈕數量
        public int GetButtonCount(string pageName)
        {
            int count = 0;
            for (int i = 0; i < _bookItems.Count(); i++)
            {
                if (_bookCategories[i].CATEGORY == pageName)
                {
                    count++;
                }
            }
            return count;
        }

        //reset _bookItem
        private void ResetBookItem()
        {
            _bookCategory.NAME = _bookItem.NAME;
            _bookCategory.NUMBER = _bookItem.NUMBER;
            _bookCategory.PUBLICATION = _bookItem.PUBLICATION;
            _bookCategory.WRITER = _bookItem.WRITER;
            _bookCategory.COVER = _bookItem.COVER;
            _bookItems.Add(_bookItem);
            _bookCategories.Add(_bookCategory);
            _bookItem = new BookItem();
            _bookCategory = new BookCategory();
            _index++;
        }

        //尋找當前書籍
        public BookItem FindCurrentSelected(int buttonIndex, int pageIndex)
        {
            string category = GetCurrentCategory(pageIndex);
            int index = 0;
            for (int i = 0; i < _bookCategories.Count(); i++)
            {
                if (index == buttonIndex)
                {
                    _selected = _bookItems[i];
                }
                if (category == _bookCategories[i].CATEGORY)
                {
                    index++;
                }
            }
            return _selected;
        }

        //還書
        public void Return(string number, int returnCount)
        {
            for (int i = 0; i < _bookItems.Count(); i++)
            {
                if (_bookItems[i].NUMBER == number)
                {
                    _bookItems[i].REMAIN += returnCount;
                }
            }
        }

        //取得書籍
        public List<BookItem> GetBookItems()
        {
            return _bookItems;
        }

        //取得借書單
        public BorrowList GetBorrowedList()
        {
            return _borrowedList;
        }

        //取得個書籍分類
        public List<BookCategory> GetBookCategories()
        {
            return _bookCategories;
        }

        //取得類別清單
        public List<string> GetCategoryList()
        {
            return _categoryList;
        }

        //取得當前書籍類別
        public string GetCurrentCategory(int index)
        {
            return _categoryList[index];
        }

        //設置當前書包書籍
        public void SetBorrowedList(BorrowList borrowList)
        {
            for (int i = 0; i < borrowList.COUNT; i++)
            {
                AddToBorrowedList(borrowList.GetBorrowedItem(i));
                for (int j = 0; j < _bookItems.Count(); j++)
                {
                    if (_bookItems[j].BOOK == borrowList.GetBorrowedItem(i).BOOK)
                    {
                        _bookItems[j].REMAIN -= _borrowedList.GetBorrowedItem(i).QUANTITY;
                        break;
                    }
                }
            }
        }

        //將書籍加入書包
        private void AddToBorrowedList(BorrowedItem borrowedItem)
        {
            _borrowedList.AddToBorrowedList(borrowedItem);
        }
    }
}
