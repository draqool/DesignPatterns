using ChainOfResponsiblity.Process;
using System;

namespace ChainOfResponsiblity.Handlers
{
    class Manager : Handler
    {
        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile))
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, mobile);
            }
            else if (successor != null)
            {
                successor.HandleRequest(mobile);
            }
        }

        public bool CanHandle(Mobile mobile)
        {
            return ((mobile.Type == Process.Type.Budget && mobile.Cost >= 200)
                || (mobile.Type == Process.Type.Premium && mobile.Cost < 500));
        }
    }
}