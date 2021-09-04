using System;
using System.Collections.Generic;

namespace InvoiceTemplates
{
    class Program
    {
        static void Main()
        {
            var invoiceTemplator = new InvoiceTemplator();

            var invoiceA = new Invoice("Franco", 100, InvoiceType.A, DateTime.Now);
            var invoiceB = new Invoice("Lucas", 500, InvoiceType.B, DateTime.Now);
            var invoiceC = new Invoice("Fernando", 2500, InvoiceType.C, DateTime.Now);
            
            invoiceTemplator.AddTemplates(new Dictionary<string, Invoice> { { "Invoice A", invoiceA }, { "Invoice B", invoiceB }, { "Invoice C", invoiceC } });
            
            var copyInvoiceA = invoiceTemplator.GetTemplate("Invoice A");
            copyInvoiceA.DueDate = new DateTime(2025, 1, 1);

            var copyInvoiceB = invoiceTemplator.GetTemplate("Invoice B");

            var copyInvoiceC = invoiceTemplator.GetTemplate("Invoice C");
            copyInvoiceC.DueDate = new DateTime(2021, 12, 31);

            invoiceA.PrintInformation();
            copyInvoiceA.PrintInformation();

            invoiceB.PrintInformation();
            copyInvoiceB.PrintInformation();

            invoiceC.PrintInformation();
            copyInvoiceC.PrintInformation();
        }
    }
}