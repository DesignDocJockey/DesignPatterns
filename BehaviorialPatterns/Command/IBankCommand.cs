using System;
namespace BehaviorialPatterns.Command
{
    public interface IBankCommand
    {
        void Call();
        void Undo();
    }

    public class BankCommandArguments 
    {
        public decimal WithdrawlAmount { get; set; }
        public decimal DepositAmount { get; set; }
    }
}
