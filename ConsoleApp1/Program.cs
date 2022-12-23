using ConsoleApp1.models;
using ConsoleApp1.services;

IAccountService accS = new AccountServiceImpl();
accS.AddNewAccount(1, "MAD", 15000);
accS.AddNewAccount(2, "EURO", 3400);
accS.AddNewAccount(3, "USD", -1200);
accS.AddNewAccount(4, "MAD", 100);

List<Account> listAccounts = accS.GetAllAccounts();
Console.WriteLine("--------------All Acounts--------------");
foreach (Account acc in listAccounts)
{
    Console.WriteLine(acc);
}
Console.WriteLine("------------Debited Acounts------------");
List<Account> DebitedAccounts = accS.GetDebitedAccounts();
foreach (Account acc in DebitedAccounts)
{
    Console.WriteLine(acc);
}
Console.WriteLine("------------Average Balance------------");
Console.WriteLine("Balance AVG : "+accS.GetBalanceAVG());