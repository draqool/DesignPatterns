namespace ChainOfResponsiblity.Spec
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);
    }
}