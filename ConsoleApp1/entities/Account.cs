namespace ConsoleApp1.models;

public class Account
{
    public int Id;
    public string Currency;
    public double Balance;

    public Account(int id, string currency, double balance)
    {
        this.Id = id;
        this.Currency = currency;
        this.Balance = balance;
    }

    public override string ToString()
    {
        return "id : " + Id.ToString() + "      balance : " + Currency.ToString() + " " + Balance.ToString();
    }
}