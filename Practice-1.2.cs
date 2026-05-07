using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    static void Main()
    {
        string input; // ...
        int[] nums;

		//? Преобразуем строковые значения в целочисленные
		int[] nums = Array.ConvertAll(input.Slice(' '), int.Parse);

        //Преобразуем строковые значения в целочисленные
        nums = Array.ConvertAll(input.Split(' '), int.Parse);

        //Функция возвращает true или false
        bool Dup = CheckDuplicates(nums);
        Console.WriteLine(Dup ? "Повторяющиеся элементов нет" : "Повторяющиеся элементы присутствуют");
    }

    static bool CheckDuplicates(int[] nums)
    {
        HashSet<int> array = new HashSet<int>();

        //Перебираем элементы словаря, используя итератор "c"
        foreach (int c in array)
        {
            if (!array.Add(c))
            {
                return true;
            }
        }
        //Дубликаты не найдены
        return false;
    }

}
