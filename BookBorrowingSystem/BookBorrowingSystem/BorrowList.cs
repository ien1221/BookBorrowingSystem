using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class BorrowList
    {
        private List<BorrowedItem> _borrowedList = new List<BorrowedItem>();

        public int BOOKS
        {
            get
            {
                int result = 0;
                foreach (BorrowedItem borrowedItem in _borrowedList)
                {
                    result += borrowedItem.QUANTITY;
                }
                return result;
            }
            
        }
        public int COUNT
        {
            get
            {
                return _borrowedList.Count();
            }
        }

        //取得書籍
        public BorrowedItem GetBorrowedItem(int index)
        {
            return _borrowedList[index];
        }

        //於list中新增書籍
        public void AddToBorrowedList(BorrowedItem borrowedItem)
        {
            _borrowedList.Add(borrowedItem);
        }

        //從借書單移除書籍
        public void Remove(int index)
        {
            _borrowedList.RemoveAt(index);
        }

        //清除書單
        public void Clear()
        {
            _borrowedList.Clear();
        }
    }
}
