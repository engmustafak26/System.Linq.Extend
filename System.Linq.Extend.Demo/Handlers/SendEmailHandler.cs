using System.Diagnostics;

namespace System.Linq.Extend.Demo.Handlers
{
    public class SendEmailHandler : IHandler
    {
        public LinqInterceptorResult Send(object message)
        {
            Console.WriteLine(" ===> Email Has been sent");
            return LinqInterceptorResult.Continue();
        }
    }
}
