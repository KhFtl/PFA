using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Currency
{
    public int CurrencyId { get; set; }
    public string? Name { get; set; } 
    public string? Symbol { get; set; } 
    public ICollection<Wallet>? Wallets { get; set; }
}