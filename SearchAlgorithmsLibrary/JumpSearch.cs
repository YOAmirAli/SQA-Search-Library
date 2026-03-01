using System;

namespace SearchAlgorithmsLibrary
{
    public class JumpSearch
    {
        public int search(int key, int[] elemArray)
        {
            int n = elemArray.Length;

            if (n == 0)
                return -1;

            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (prev < n && elemArray[Math.Min(step, n) - 1] < key)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n)
                    return -1;
            }

            while (prev < n && elemArray[prev] < key)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (prev < n && elemArray[prev] == key)
                return prev;

            return -1;
        }
    }
}