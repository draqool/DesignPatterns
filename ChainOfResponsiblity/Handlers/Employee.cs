using ChainOfResponsiblity.Process;
using System;

namespace ChainOfResponsiblity.Handlers
{
    class Employee : Handler
    {
        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile))
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, mobile);
            }
            else if (successor != null)
            {
                successor.HandleRequest(mobile);
            }
        }

        public bool CanHandle(Mobile mobile)
        {
            return (mobile.Type == Process.Type.Basic);
        }
    }
}