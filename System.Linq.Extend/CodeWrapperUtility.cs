using System.Collections.Generic;

namespace System.Linq.Extend
{
    internal static class CodeWrapperUtility
    {
        internal static T WrapLinq<T>(Event eventParam, Func<T> code, object source, ExtendLinqOptions options)
        {
            if (options?.SkipInterceptor == true)
            {
                return code();
            }

            foreach (var subscriber in EventSubscriber.BeforeExecution.GetValueOrDefault(eventParam, new List<Func<IServiceProvider, object, object, LinqInterceptorResult>>()))
            {
                var result = subscriber(DependecyInjector.ServiceProvider, source, options?.Metadata);
                if (result.IsSuccess == true)
                {
                    return (T)result.ReturnResult;
                }
                if (result.IsSuccess == false)
                {
                    throw new ExtendLinqException(result.ErrorMessage);
                }
            }

            var codeResult = code();

            foreach (var subscriber in EventSubscriber.AfterExecution.GetValueOrDefault(eventParam, new List<Func<IServiceProvider, object, object, object, LinqInterceptorResult>>()))
            {
                var result = subscriber(DependecyInjector.ServiceProvider, source, codeResult, options?.Metadata);
                if (result.IsSuccess == true)
                {
                    return (T)result.ReturnResult;
                }
                if (result.IsSuccess == false)
                {
                    throw new ExtendLinqException(result.ErrorMessage);
                }
            }

            return codeResult;
        }
    }

}
