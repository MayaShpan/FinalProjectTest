using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Invoice
    {
        int invoiceNo;
        int priceInShekels;

        public Invoice(int invoiceNo, int priceInShekels)
        {
            this.InvoiceNo = invoiceNo;
            this.PriceInShekels = priceInShekels;
        }

        public int InvoiceNo { get => invoiceNo; set => invoiceNo = value; }
        public int PriceInShekels { get => priceInShekels; set => priceInShekels = value; }
    }
}