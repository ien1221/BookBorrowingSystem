using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingSystem
{
    public class BackPackFormPresentationModel
    {
        private Library _library;
        private BorrowList _borrowList;

        public BackPackFormPresentationModel(Library library)
        {
            _library = library;
        }
        //更新借書單
        public void UpdateBorrowList()
        {
            _borrowList = _library.GetBorrowedList();
        }

        //取得借書單
        public BorrowList GetBorrowList()
        {
            return _borrowList;
        }

        //取得書籍詳細資訊
        public List<string> GetBorrowListInformation(int index)
        {
            List<string> result = new List<string>();
            BorrowedItem currentItem = _borrowList.GetBorrowedItem(index);
            result.Add(currentItem.BOOK.NAME);
            result.Add(currentItem.QUANTITY.ToString());
            result.Add(currentItem.BORROW.ToString(Constant.DATE));
            result.Add(currentItem.RETURN.ToString(Constant.DATE));
            result.Add(currentItem.BOOK.NUMBER);
            result.Add(currentItem.BOOK.WRITER);
            result.Add(currentItem.BOOK.PUBLICATION);
            return result;
        }

        //移除借書
        public bool RemoveBorrow(int index, int returnCount)
        {
            string number = _borrowList.GetBorrowedItem(index).BOOK.NUMBER;
            _library.Return(number, returnCount);
            if (_borrowList.GetBorrowedItem(index).QUANTITY - returnCount == 0)
            {
                _borrowList.Remove(index);
                return true;
            }
            else
            {
                _borrowList.GetBorrowedItem(index).QUANTITY -= returnCount;
                return false;
            }
        }

        //是否能夠歸還
        public int IsReturnLegal(int index, int returnCount)
        {
            if (returnCount <= 0)
                return 2;
            else if (_borrowList.GetBorrowedItem(index).QUANTITY < returnCount)
                return 1;
            else
                return 3;
         }

        //顯示歸還成功資訊
        public string ReturnSuccess(int index, int quantity)
        {
            string result;
            result = $"【{_borrowList.GetBorrowedItem(index).BOOK.NAME}】 已成功歸還{quantity}本";
            return result;
        }

        //重製借書數量
        public string ResetBorrowCount(int index)
        {
            string result = _borrowList.GetBorrowedItem(index).QUANTITY.ToString();
            return result;
        }
    }
}
