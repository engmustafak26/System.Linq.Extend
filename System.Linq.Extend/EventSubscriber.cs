using System.Collections.Generic;

namespace System.Linq.Extend
{
    public static class EventSubscriber
    {
        internal static Dictionary<Event, List<Func<IServiceProvider, object, object, LinqInterceptorResult>>> BeforeExecution = new Dictionary<Event, List<Func<IServiceProvider, object, object, LinqInterceptorResult>>>();
        internal static Dictionary<Event, List<Func<IServiceProvider, object, object, object, LinqInterceptorResult>>> AfterExecution = new Dictionary<Event, List<Func<IServiceProvider, object, object, object, LinqInterceptorResult>>>();

        public static void RegisterBeforeExecutionEventSubscriber(Event eventParam, Func<IServiceProvider, object, object, LinqInterceptorResult> beforeExecutionSubscriber)
        {
            if (beforeExecutionSubscriber is null)
                return;

            bool hasKey = BeforeExecution.TryGetValue(eventParam, out var value);
            if (hasKey)
            {
                value.Add(beforeExecutionSubscriber);
            }
            else
            {
                BeforeExecution.Add(eventParam, new List<Func<IServiceProvider, object, object, LinqInterceptorResult>> { beforeExecutionSubscriber });
            }
        }
        public static void RegisterAfterExecutionEventSubscriber(Event eventParam, Func<IServiceProvider, object, object, object, LinqInterceptorResult> afterExecutionSubscriber)
        {
            if (afterExecutionSubscriber is null)
                return;

            bool hasKey = AfterExecution.TryGetValue(eventParam, out var value);
            if (hasKey)
            {
                value.Add(afterExecutionSubscriber);
            }
            else
            {
                AfterExecution.Add(eventParam, new List<Func<IServiceProvider, object, object, object, LinqInterceptorResult>> { afterExecutionSubscriber });
            }
        }


        public static void RegisterEventSubscriber(Event eventParam,
                        Func<IServiceProvider, object, object, LinqInterceptorResult> beforeExecution = null,
                        Func<IServiceProvider, object, object, object, LinqInterceptorResult> afterExecution = null)
        {
            RegisterBeforeExecutionEventSubscriber(eventParam, beforeExecution);
            RegisterAfterExecutionEventSubscriber(eventParam, afterExecution);
        }


        public static void ClearBeforeExecutionEventSubscribers() => BeforeExecution.Clear();
        public static void ClearAfterExecutionEventSubscribers() => AfterExecution.Clear();

        public static void ClearBeforeExecutionEventSubscribers(Event eventParam) => BeforeExecution.Remove(eventParam);
        public static void ClearAfterExecutionEventSubscribers(Event eventParam) => AfterExecution.Remove(eventParam);
        public static void ClearAllSubscribers()
        {
            ClearBeforeExecutionEventSubscribers();
            ClearAfterExecutionEventSubscribers();
        }
    }

}
