using System;

namespace SingleNumber
{
    public static class Utils
    {
        public static int GetSingleNumber(int[] array)
        {
            if (array.Length % 2 == 0 || array == null) return -1;

            Array.Sort(array);

            for(int i=0;i<array.Length; i = i + 2)
            {
                if (array[i] != array[i + 1])
                    return array[i];

                if (i == array.Length - 1) return array[i + 1];
            }

            return -1;
        }
    }
}
