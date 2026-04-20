namespace ExpenseTracker.Models;

public class Expense
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public Category Category { get; set; }
}