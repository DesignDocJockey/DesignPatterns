using System;
using BehaviorialPatterns.DomainModels;

namespace BehaviorialPatterns.Command
{
    public interface IWithdrawl
    {
        void WithDrawl(BankAccount bankAccount, decimal withdrawlAmout);
        void RollbackWithDrawl(BankAccount bankAccount, decimal withdrawlAmout);
    }
}
