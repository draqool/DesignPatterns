﻿using System;

namespace StatePattern.AccountStates
{
    public class Closed : IAccountState
    {
        public IAccountState Deposit(Action addToBalance) => this;
        public IAccountState Withdraw(Action subtractFromBalance) => this;
        public IAccountState Freeze() => this;
        public IAccountState HolderVerified() => this;
        public IAccountState Close() => this;
    }
}