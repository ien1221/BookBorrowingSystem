using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BookBorrowingSystem
{
    public class MenuFormPresentationModel
    {
        bool _borrowEnable;
        bool _inventoryEnable;
        bool _manageEnable;

        public MenuFormPresentationModel()
        {
            _borrowEnable = true;
            _inventoryEnable = true;
            _manageEnable = true;
        }

        //取得BorrowEnable
        public bool IsBorrowEnable()
        {
            return _borrowEnable;
        }

        //取得InventoryEnable
        public bool IsInventoryEnable()
        {
            return _inventoryEnable;
        }

        //取得ManageEnable
        public bool IsManageEnable()
        {
            return _manageEnable;
        }

        //更改按鈕狀態
        public bool ChangeButtonStatus(int index)
        {
            switch (index)
            {
                case Constant.ONE:
                    _borrowEnable = !_borrowEnable;
                    return _borrowEnable;
                case Constant.TWO:
                    _inventoryEnable = !_inventoryEnable;
                    return _inventoryEnable;
                default:
                    _manageEnable = !_manageEnable;
                    return _manageEnable;
            }
        }
    }
}
