using Microsoft.Extensions.Caching.Memory;

namespace System.Linq.Extend.Demo.Handlers
{
    public class StoreInCacheHandler : IHandler
    {
        private readonly IMemoryCache _cache;
        private readonly object _source;

        public StoreInCacheHandler(IMemoryCache cache, object source)
        {
            _cache = cache;
            _source = source;
        }

        public LinqInterceptorResult Send(object message)
        {
            string keyFromSource = _source.ToString(); //get unique key, even you can call .ToQueryString() and hash it, use as key
            var data = _cache.Set(keyFromSource, message);

            Console.WriteLine(" ===> Save Data to cache occurs");


            return LinqInterceptorResult.Continue();
        }
    }
}
