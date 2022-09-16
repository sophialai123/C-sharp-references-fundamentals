using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            //The variable is a reference to the object’s location in memory.
            Book bookLocation = new Book();

            ///Both variables refer to the same location in memory.
            Book sameBookLocation = bookLocation;

            //The variable holds the actual value.
            bool falseValue = false;

            //The false value was copied to a new location in memory for anotherFalseValue to use
            bool anotherFalseValue = falseValue;
        }
    }
}
