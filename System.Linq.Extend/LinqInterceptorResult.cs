using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq.Extend
{
    public class LinqInterceptorResult
    {
        public bool? IsSuccess { get; set; }
        public object ReturnResult { get; set; }
        public string ErrorMessage { get; set; }

        public static LinqInterceptorResult Success(object result)
        {
            return new LinqInterceptorResult
            {
                IsSuccess = true,
                ReturnResult = result
            };
        }

        public static LinqInterceptorResult Fail(string message)
        {
            return new LinqInterceptorResult
            {
                IsSuccess = false,
                ErrorMessage = message
            };
        }

        public static LinqInterceptorResult Continue()
        {
            return new LinqInterceptorResult();
        }
    }
}
