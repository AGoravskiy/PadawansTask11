using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            if (accuracy >= 1 || accuracy <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (int index = 1; index < array.Length; index++)
            {
                double sumLeft = 0, sumRight = 0;
                for (int i = 0; i < index; i++)
                {
                    sumLeft += array[i];
                }
                for (int i = index + 1; i < array.Length; i++)
                {
                    sumRight += array[i];
                }
                if (Math.Abs(sumLeft - sumRight) <= accuracy)
                {
                    return index;
                }
            }
            return null;
        }
    }
}
