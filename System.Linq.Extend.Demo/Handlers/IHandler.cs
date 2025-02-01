namespace System.Linq.Extend.Demo.Handlers
{
    public interface IHandler
    {
        LinqInterceptorResult Send(object message);
    }
}
