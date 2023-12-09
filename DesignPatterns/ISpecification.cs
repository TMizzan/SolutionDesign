using System;

namespace DesignPatterns
{

    public interface ISpecification<T>
    {
        bool IsValid(T item);
    }
}
