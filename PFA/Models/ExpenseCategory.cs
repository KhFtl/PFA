using System.Collections.Generic;

public class ExpenseCategory
{
    public int ExpenseCategoryId { get; set; }
    public string? Name { get; set; }
    public List<Transaction>? Transactions { get; set; }
}