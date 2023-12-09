using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly System.Collections.Generic.List<ISpecification<T>> Specifications;

        public AndSpecification(System.Collections.Generic.List<ISpecification<T>> specifications)
        {
            Specifications = specifications;
        }

        public bool IsValid(T item)
        {
            bool valid = true;

            foreach (ISpecification<T> specification in Specifications)
            {
                valid = specification.IsValid(item);

                // And Condition Does Not Pass If Any Validation Returns False
                if (valid == false)
                {
                    break;
                }
            }

            return valid;
        }
    }
}
