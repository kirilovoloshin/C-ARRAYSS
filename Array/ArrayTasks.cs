using System;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        
        public static void ChangeElementsInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length/2; i++)
            {
                if (nums[i] % 2 == 0 && nums[nums.Length - 1 - i] % 2 == 0)
                {
                    (nums[i], nums[nums.Length - 1 - i]) = (nums[nums.Length - 1 - i], nums[i]);
                }
            }
        }

        
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int maxValueIndex=0;
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[maxValueIndex])
                {
                    maxValueIndex = i;
                    result = 0;
                }
                if (nums[i] == nums[maxValueIndex])
                {
                    result = i - maxValueIndex;
                }
            }
            return result;
        }

        
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (i < j)
                        matrix[i, j] = 1;
                    if (i > j)
                        matrix[i, j] = 0;
                }
            }
        }
    }
}
