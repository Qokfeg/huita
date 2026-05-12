using System;
using System.Collections.Generic;

class Program
{
    public static int LongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Проверяем, является ли текущий элемент началом последовательности
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Ищем последовательность
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                // Обновляем максимальную длину последовательности
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    static void Main(string[] args)
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutiveSequence(nums)); // Вывод: 4
    }
}
