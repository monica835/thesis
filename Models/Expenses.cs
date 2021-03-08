using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icarus.Models
{
    public class Expenses
    {
        public int IDExpense { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ORNumber { get; set; }
        public int IDVendor { get; set; }
        public string Particulars { get; set; }
        public char WithReceipt { get; set; }
        public int IDAccount { get; set; }
        public string EncodedBy { get; set; }
        public char IsVerified { get; set; }
        public char ChargeToCodep { get; set; }
        public double VATSales { get; set; }
        public double VATAmount { get; set; }
        public double VATExempt { get; set; }
        public double Amount { get; set; }
        public DateTime PostedDate { get; set; }
        public double ChargedToCodep { get; set; }
        public string TIN { get; set; }
    }
}