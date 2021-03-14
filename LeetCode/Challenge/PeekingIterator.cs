using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{

    // C# IEnumerator interface reference:
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8


    class PeekingIterator
    {
        IEnumerator<int> iter;
        bool hasNext;
        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            // initialize any member here.
            iter = iterator;
            hasNext = true;
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return iter.Current;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            int res = iter.Current;
            hasNext = iter.MoveNext();
            return res;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return hasNext;
        }
    }
}