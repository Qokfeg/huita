using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        string input;
        int[] nums;

        Console.Write("Введите элементы массива: ");
        input = Console.ReadLine();

        //Преобразуем строковые значения в целочисленные
        nums = Array.ConvertAll(input.Split(' '), int.Parse);

        //Функция возвращает true или false
        bool Dup = CheckDuplicates(nums);
        Console.WriteLine(Dup ? "Повторяющиихся элементов нет" : "Повторяющиеся элементы присутствуют\r\n");
    }   

    static bool CheckDuplicates(int[] nums)
    {
        HashSet<int> array = new HashSet<int>();

        //Перебираем элементы словаря, используя итератор "c"
        foreach (int c in array)
        {
            if (array.Contains(c)) //Возвращает true в случае идентичного элемента
                return true; // Дубликант найден. Производим возврат из функции

            array.Add(c); //Добавляем элемент в наш HashSet
        }
        //Дубликаты не найдены
        return false;
    }

}