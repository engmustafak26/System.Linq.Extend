using Microsoft.Extensions.Caching.Memory;

namespace System.Linq.Extend.Demo.Handlers
{
    public class CacheHandler : IHandler
    {
        private readonly IMemoryCache _cache;

        public CacheHandler(IMemoryCache cache)
        {
            _cache = cache;
        }

        public LinqInterceptorResult Send(object message)
        {
            string keyFromSource = message.ToString(); //get unique key, even you can call .ToQueryString() and hash it, use as key
            var data = _cache.Get(keyFromSource);

            if (data is not null)
            {
                Console.WriteLine(" ===> cache hit && data fetch occurs");
                return LinqInterceptorResult.Success(data);
            }

            return LinqInterceptorResult.Continue();
        }
    }
}
