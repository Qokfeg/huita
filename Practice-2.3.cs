using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> TopKFrequent(int[] nums, int k)
    {
        // Шаг 1: Подсчитываем частоту каждого элемента
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        // Шаг 2: Используем хеш-таблицу, чтобы сгруппировать элементы по частоте
        // максимальное количество уникальных элементов может быть n
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in frequencyMap)
        {
            int freq = pair.Value; // Частота
            if (buckets[freq] == null)
            {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(pair.Key); // Добавляем элемент к соответствующему бакету
        }

        // Шаг 3: Собираем результат
        IList<int> result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        // Возвращаем только первые k элементов
        return result.Take(k).ToList();
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums1 = { 1, 1, 1, 2, 2, 3 };
        int k1 = 2;
        IList<int> result1 = solution.TopKFrequent(nums1, k1);
        Console.WriteLine($"Result 1: [{string.Join(", ", result1)}]"); // Вывод: [1, 2]

        int[] nums2 = { 1 };
        int k2 = 1;
        IList<int> result2 = solution.TopKFrequent(nums2, k2);
        Console.WriteLine($"Result 2: [{string.Join(", ", result2)}]"); // Вывод: [1]
    }
}