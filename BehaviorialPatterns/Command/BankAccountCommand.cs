using System;
using BehaviorialPatterns.DomainModels;

namespace BehaviorialPatterns.Command
{
    public class BankAccountCommand: IBankCommand
    {
        private readonly BankAccount _bankAcount;
        private readonly DomainModels.Action _action;
        private readonly BankCommandArguments _bankCommandArgs;
        private readonly IDeposit _depositService;
        private readonly IWithdrawl _withdrawlService;

        public BankAccountCommand(BankAccount account, DomainModels.Action action, BankCommandArguments bankCmdArgs,
                                    IDeposit depositService, IWithdrawl withdrawlService)
        {
            _bankAcount = account ?? throw new ArgumentNullException(nameof(account), $"cannot have null value for ${nameof(account)}");
            _action = action;
            _bankCommandArgs = bankCmdArgs ?? throw new ArgumentNullException(nameof(bankCmdArgs), $"cannot have null value for ${nameof(bankCmdArgs)}");
            _depositService = depositService ?? throw new ArgumentNullException(nameof(depositService), $"cannot have null value for ${nameof(depositService)}");
            _withdrawlService = withdrawlService ?? throw new ArgumentNullException(nameof(withdrawlService), $"cannot have null value for ${nameof(withdrawlService)}");
        }

        public void Call()
        {
            switch (_action) 
            {
                case DomainModels.Action.Deposit:
                    _depositService.Deposit(_bankAcount, _bankCommandArgs.DepositAmount);
                    break;
                case DomainModels.Action.WithDraw:
                    _withdrawlService.WithDrawl(_bankAcount, _bankCommandArgs.WithdrawlAmount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
