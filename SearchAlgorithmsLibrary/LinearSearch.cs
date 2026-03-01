namespace SearchAlgorithmsLibrary
{
    public class LinearSearch
    {
        public int search(int key, int[] elemArray)
        {
            for (int i = 0; i < elemArray.Length; i++)
            {
                if (elemArray[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}