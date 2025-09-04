using System.Collections.Generic;

public class IncomeSource
{
    public int IncomeSourceId { get; set; }
    public string? Name { get; set; }
    public List<Transaction>? Transactions { get; set; }
}