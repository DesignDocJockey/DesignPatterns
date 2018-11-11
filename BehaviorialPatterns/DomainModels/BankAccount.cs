using System;
namespace BehaviorialPatterns.DomainModels
{
    public class BankAccount
    {
        public string AccountId { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountId, decimal balance )
        {
            AccountId = accountId ?? throw new ArgumentNullException(nameof(accountId), $"cannot have null value for ${nameof(accountId)}");
            Balance = (balance < 0) ? throw new ArgumentNullException(nameof(balance), $"cannot have negative value for ${nameof(balance)}") : 0.00M;
        }
    }
}
