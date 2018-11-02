using System;
namespace BehaviorialPatterns.Command
{
    public interface IBankCommand
    {
        bool Success { get; set; }
        void Call();
        void Undo();
    }

    public class BankCommandArguments 
    {
        public decimal WithdrawlAmount { get; set; }
        public decimal DepositAmount { get; set; }
    }
}
