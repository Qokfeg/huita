using System;
using System.Collections.Generic;

class Program
{

    static void main()
    {
        string input;
        int[] nums;

        Console.Write("Введите элементы массива: ");
        input = Console.ReadLine();

        //Преобразуем строковые значения в целочисленные
        Array.ConvertAll(input.Splite(' '), int.Parse);

        //Функция возвращает true или false
        bool Dup = CheckDuplicates(nums);
        Console.WriteLine(Dup ? "Повторяющиеся элементы присутствуют" : "Повторяющиихся элементов нет");
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