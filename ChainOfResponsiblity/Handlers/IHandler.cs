using ChainOfResponsiblity.Spec;

namespace ChainOfResponsiblity.Handlers
{
    public interface IHandler<T>
    {
        void SetSuccessor(IHandler<T> handler);
        void HandleRequest(T o);
        void SetSpecification(ISpecification<T> specification);
    }
}