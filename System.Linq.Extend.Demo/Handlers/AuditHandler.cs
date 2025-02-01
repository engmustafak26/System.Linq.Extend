using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace System.Linq.Extend.Demo.Handlers
{
    public class AuditHandler : IHandler
    {
        public LinqInterceptorResult Send(object message)
        {
            Console.WriteLine(" ===> Operation Audited");
            return LinqInterceptorResult.Continue();
        }
    }
}
