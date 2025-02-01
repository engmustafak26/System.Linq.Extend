using Microsoft.Extensions.Caching.Memory;
using System.Linq.Extend.Demo.Handlers;

namespace System.Linq.Extend.Demo.Mediator
{
    public class MediatorManager : IMediator
    {
        private readonly IMemoryCache _memoryCache;

        public MediatorManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public LinqInterceptorResult Send(object route, object source, object result = null)
        {
            if (route?.ToString() == "sendEmailAboutAccessSensitiveData" && result != null)
            {
                return new SendEmailHandler().Send(result);
            }

            if (route?.ToString() == "audit")
            {
                if (result == null)
                    return new AuditHandler().Send(source);
                else
                    return new AuditHandler().Send(result);
            }

            if (route?.ToString() == "cache")
            {
                if (result == null)
                    return new CacheHandler(_memoryCache).Send(source);
                else
                    return new StoreInCacheHandler(_memoryCache, source).Send(result);
            }

            return LinqInterceptorResult.Continue();
        }

    }
}
