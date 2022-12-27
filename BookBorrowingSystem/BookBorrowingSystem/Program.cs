using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrowingSystem
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Library library = new Library(Constant.FILE);
            MenuForm menuForm = new MenuForm(library);
            BookBorrowingForm bookBorrowingForm = new BookBorrowingForm(library, menuForm);
            Application.Run(menuForm);
        }
    }
}
