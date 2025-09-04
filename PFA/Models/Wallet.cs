using System.Collections.Generic;

public class Wallet
{
    public int WalletId { get; set; }
    public string? Name { get; set; }
    public decimal Balance { get; set; }
    public int CurrencyId { get; set; }
    public Currency? Currency { get; set; }
    public List<Transaction>? Transactions { get; set; }
}