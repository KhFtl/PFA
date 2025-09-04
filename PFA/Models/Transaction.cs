using System;

public class Transaction
{
    public int TransactionId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public decimal Amount { get; set; }
    public int WalletId { get; set; }
    public Wallet? Wallet { get; set; }
    public TransactionType Type { get; set; } // Income or Expense

    // For Income
    public int? IncomeSourceId { get; set; }
    public IncomeSource? IncomeSource { get; set; }

    // For Expense
    public int? ExpenseCategoryId { get; set; }
    public ExpenseCategory? ExpenseCategory { get; set; }
}

public enum TransactionType
{
    Income,
    Expense
}