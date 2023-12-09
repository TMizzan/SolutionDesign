using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly System.Collections.Generic.List<ISpecification<T>> Specifications;

        public OrSpecification(System.Collections.Generic.List<ISpecification<T>> specifications)
        {
            Specifications = specifications;
        }

        public bool IsValid(T item)
        {
            bool valid = false;

            foreach (ISpecification<T> specification in Specifications)
            {
                valid = valid || specification.IsValid(item);

                // Or Condition Passes If Any Validation Returns True
                if (valid == true)
                {
                    break;
                }
            }

            return valid;
        }

    }
}
