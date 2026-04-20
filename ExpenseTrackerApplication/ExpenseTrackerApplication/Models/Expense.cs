using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackerApplication.Models;

public class Expense
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Category { get; set; }
}
