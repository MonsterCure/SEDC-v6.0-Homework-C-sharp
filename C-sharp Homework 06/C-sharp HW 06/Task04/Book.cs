using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Book
    {
        public int Id { get; private set; }
        private static int _count = 1;
        public static List<Book> books = new List<Book>();

        public string bookTitle;
        public string bookAuthor;
        public int pageCount;
        public string ISBN;
        public bool isCheckedOut;
        public DateTime checkedOut;
        public DateTime CheckedOut
        {
            get { return checkedOut; }
            set { checkedOut = value; }
        }
        public bool isOverdue;
        

        public Book(string title, string author, int pages, string isbn, bool isChecked, DateTime checkedOutDate = default(DateTime))
        {
            this.bookTitle = title;
            this.bookAuthor = author;
            this.pageCount = pages;
            this.ISBN = isbn;
            this.isCheckedOut = isChecked;
            if (isCheckedOut)
            {
                this.checkedOut = checkedOutDate;
            }
            else
            {
                this.checkedOut = default(DateTime);
            }
            this.Id = _count++;
            books.Add(this);
        }

        public void ChangeStatus()
        {
            if (isCheckedOut)
            {
                isCheckedOut = false;
            }
            else
            {
                isCheckedOut = true;
            }
        }

        public int CalculateFees()
        {
            int fee = 0, totalFee = 0;
            DateTime today = DateTime.Today;
            if(checkedOut != default(DateTime))
            {
                int period = (int)(today - checkedOut).TotalDays;
                if (isCheckedOut == true && period > 14)
                {
                    this.isOverdue = true;
                    fee = 100;
                    totalFee = fee * period;
                    //Console.WriteLine($"{this.bookTitle} by {this.bookAuthor}\nThe fees due are {totalFee}");
                }
            }
            return totalFee;
        }
    }
}
