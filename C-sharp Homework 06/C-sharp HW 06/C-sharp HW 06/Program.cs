using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceTest();
        }

        public static void InvoiceTest()
        {
            Invoice invoice01 = new Invoice("123", "book", 2, 4.57);
            Invoice invoice02 = new Invoice("45", "pen", 3, 0.97);
            Invoice invoice03 = new Invoice("56", "pencil", 2, 1.13);
            Invoice invoice04 = new Invoice("3", "A4 paper", 500, 0.02);
            Invoice invoice05 = new Invoice("17", "envelope", 30, 0.15);
            Invoice invoice06 = new Invoice("98", "bookmark", 30, 5.25);

            Invoice invoice07 = new Invoice();
            invoice07.SetItemNumber("23");
            invoice07.SetItemDescription("notebook");
            invoice07.SetItemQuantity(3);
            invoice07.SetItemPrice(2.30);

            invoice01.GetItemDescription();
            invoice02.GetItemNumber();
            invoice03.GetItemQuantity();
            invoice04.GetItemPrice();

            foreach (var item in Invoice.invoices)
            {
                item.GetInvoiceAmount();
            }
        }
    }
}
