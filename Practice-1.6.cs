/*
# Пропущенное число

Дан несортированный массив `nums`, который содержит `n` различных чисел в диапазоне `[0, n]`. Необходимо найти единственное число в этом диапазоне, которое отсутствует в массиве.

Нельзя использовать сортировку.
*/

using System;

public class Program
{
    public static void Main()
    {
        string input;
        int[] nums;

        Console.Write("Введите элементы массива: ");
        input = Console.ReadLine();

        nums = Array.ConvertAll(input.Split(','), int.Parse);

        Console.WriteLine($"Пропущенное значение: {FindMissingNumber(nums)}");
    }

    public static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expSum = n * (n + 1) / 2; // Математическое свойство cуммы. 
        int actSum = 0;

        foreach (int num in nums)
        {
            actSum += num;
        }

        return expSum - actSum;
    }
}
