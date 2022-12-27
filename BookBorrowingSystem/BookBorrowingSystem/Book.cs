using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowingSystem
{
    public class Book
    {
        private string _name = "";
        private string _bookNumber = "";
        private string _writer = "" ;
        private string _publication = "";
        private string _cover = "";

        //get all infromation
        public string GetInformation()
        {
            string result = "";
            result += this.NAME + Constant.END;
            result += Constant.ORDER + this.NUMBER + Constant.END;
            result += Constant.WRITER + this.WRITER + Constant.END;
            result += this.PUBLICATION;
            return result;
        }

        public string NAME
        {
            get
            {
                return this._name;
            }
            set
            {
                _name = value;
            }
        }

        public string NUMBER
        {
            get 
            {
                return this._bookNumber;
            }
            set 
            { 
                _bookNumber = value;
            }
        }

        public string WRITER
        {
            get
            {
                return this._writer;
            }
            set
            {
                _writer = value;
            }
        }

        public string PUBLICATION
        {
            get
            {
                return this._publication;
            }
            set
            {
                _publication = value;
            }
        }

        public string COVER
        {
            get
            {
                return this._cover;
            }

            set
            {
                _cover = Constant.IMAGE + value + Constant.EXTENSION;
            }
        }
    }
}
