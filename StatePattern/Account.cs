using StatePattern.AccountStates;
using System;

namespace StatePattern
{
    public class Account
    {
        private IAccountState _state;
        public decimal Balance { get; private set; }
       
        public Account(Action onUnfreeze)
        {
            _state = new NotVerified(onUnfreeze);
        }

        public void Deposit(decimal amount)
        {
            _state = this._state.Deposit(() => { this.Balance += amount; });
        }

        public void Withdraw(decimal amount)
        {
            _state = _state.Withdraw(() => { this.Balance -= amount; });
        }

        public void HolderVerified() => _state = _state.HolderVerified();
        public void Close() => _state = _state.Close();    
        public void Freeze() => _state = _state.Freeze();
    }
}