using ConsoleApp1.models;

namespace ConsoleApp1.services;

public class AccountServiceImpl : IAccountService
{
    IDictionary<int, Account> accounts = new Dictionary<int, Account>();

    public void AddNewAccount(int id, string curency, double balance)
    {
        accounts.Add(id, new Account(id, curency, balance));
    }

    public List<Account> GetAllAccounts()
    {
        return accounts.Values.ToList();
    }

    public Account GetAccountById(int id)
    {
        return accounts[id];
    }

    public List<Account> GetDebitedAccounts()
    {
        return accounts.Values.Where(acc => acc.Balance < 0).ToList();
    }

    public double GetBalanceAVG()
    {
        return accounts.Values.Average(acc => acc.Balance);
    }
}