/*
# Проверка на палиндром

Дана строка `s`. Напишите функцию, которая проверяет, является ли строка `s` палиндромом. 

Строка `s` является палиндромом, если она читается одинаково как справа налево, так и слева направо. Перед проверкой на полиндром нужно удалить из строки все неалфавитно-цифровые символы.

Нельзя использовать метод `Reverse`.
*/

using System;

class Program
{

    static void Main()
    {
        string str;
        string str2 = "";
        int i, j; // Объявление обеих переменных типа int, разделенных запятой

        Console.Write("Введите строку: ");
        str = Console.ReadLine();

        str = string.Concat(str.Where(char.IsLetterOrDigit)).ToLower(); //До: "Hello, world! 123", После: "helloworld123"

        for (i = str.Length - 1; i > -1; i--)
        {
            str2 += str[i];
        }

        if (str2 == str)
            Console.WriteLine("Палиндром");
        else
            Console.WriteLine("Не палиндром");
        
    }
}

