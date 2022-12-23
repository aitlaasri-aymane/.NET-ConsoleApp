using ConsoleApp1.models;

namespace ConsoleApp1.services;

public interface IAccountService
{
    public void AddNewAccount(int id, string curency, double balance);
    public List<Account> GetAllAccounts();
    public Account GetAccountById(int id);
    public List<Account> GetDebitedAccounts();
    public double GetBalanceAVG();
}