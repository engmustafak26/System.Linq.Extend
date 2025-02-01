using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq.Extend
{
    public static class DependecyInjector
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static void Inject(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
