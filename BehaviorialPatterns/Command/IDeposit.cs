using System;
using BehaviorialPatterns.DomainModels;

namespace BehaviorialPatterns.Command
{
    public interface IDeposit
    {
        void Deposit(BankAccount bankAccount, decimal depositAmout);
        void RollbackDeposit(BankAccount bankAccount, decimal depositAmout);
    }
}
