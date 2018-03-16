using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW_06
{
    public class Invoice
    {
        public int Id { get; private set; }
        private static int _count = 1;
        public static List<Invoice> invoices = new List<Invoice>();

        public string ItemNumber;
        public string ItemDescription;
        public int ItemQuantity;
        public double ItemPrice;

        public Invoice()
        {
            this.Id = _count++;
            invoices.Add(this);
        }

        public Invoice(string itemNumber, string itemDescription, int itemQuantity, double itemPrice)
        {
            this.ItemNumber = itemNumber;
            this.ItemDescription = itemDescription;
            this.ItemQuantity = itemQuantity;
            this.ItemPrice = itemPrice;
            this.Id = _count++;
            invoices.Add(this);
        }

        public void SetItemNumber(string itemNumber)
        {
            ItemNumber = itemNumber;
        }

        public string GetItemNumber()
        {
            Console.WriteLine($"The item's number for the invoice No. {this.Id} is: {ItemNumber}");
            return ItemNumber;
        }

        public void SetItemDescription(string itemDescription)
        {
            ItemDescription = itemDescription;
        }

        public string GetItemDescription()
        {
            Console.WriteLine($"The item's description for the invoice No. {this.Id} is: {ItemDescription}");
            return ItemDescription;
        }

        public void SetItemQuantity(int itemQuantity)
        {
            if(itemQuantity <= 0)
            {
                itemQuantity = 0;
            }
            ItemQuantity = itemQuantity;
        }

        public int GetItemQuantity()
        {
            Console.WriteLine($"The item quantity for the invoice No. {this.Id} is: {ItemQuantity}");
            return ItemQuantity;
        }

        public void SetItemPrice(double itemPrice)
        {
            if(itemPrice <= 0)
            {
                itemPrice = 0.0;
            }
            ItemPrice = itemPrice;
        }

        public double GetItemPrice()
        {
            Console.WriteLine($"The item's price for the invoice No. {this.Id} is: {ItemPrice}");
            return ItemPrice;
        }

        public double GetInvoiceAmount()
        {
            double result = this.ItemQuantity * this.ItemPrice;
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine($"Invoice No. {this.Id}:\nThe item price is {this.ItemPrice}.\nThe item quantity is {this.ItemQuantity}\nThe amount of the invoice is: {result}");
            return result;
        }
        
    }
}
