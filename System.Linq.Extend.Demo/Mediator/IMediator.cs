namespace System.Linq.Extend.Demo.Mediator
{
    public interface IMediator
    {
        LinqInterceptorResult Send(object route, object source, object result = null);
    }
}
