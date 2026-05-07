using System;
using System.Collections.Generic;

public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        //? Если длины строк разные, они не могут быть анаграммами
        //? (потому что нужно использовать все буквы ровно один раз)
        if (s.Length != t.Length) 
        {
            return false;
        }

        //? Создаём словарь (таблицу), где ключ - символ, значение - счётчик
        //? Dictionary<char, int> - означает: ключ типа char, значение типа int
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        //? ПЕРВЫЙ ПРОХОД: считаем частоту символов в строке s
        //? foreach - перебирает каждый символ в строке
        foreach (char c in s) 
        {
            //? Если символ уже есть в словаре, увеличиваем его счётчик на 1
            if (charCount.ContainsKey(c)) 
            {
                charCount[c] = charCount[c] + 1;
            }
            //? Если символа ещё нет, добавляем его со счётчиком 1
            else 
            {
                charCount[c] = 1;
            }
        }

        //? ВТОРОЙ ПРОХОД: вычитаем частоту символов из строки t
        foreach (char c in t) 
        {
            //? Если встретили символ, которого не было в s, это не анаграмма
            if (!charCount.ContainsKey(c)) 
            {
                return false;
            }
            
            //? Уменьшаем счётчик для этого символа
            charCount[c] = charCount[c] - 1;
            
            //? Если счётчик стал меньше 0, значит в t больше таких букв, чем в s
            if (charCount[c] < 0) 
            {
                return false;
            }
        }

        //? Если все проверки пройдены, это анаграмма
        return true;
    }
}

//? Пример использования:
class Program 
{
    static void Main() 
    {
        Solution solution = new Solution();
        
        Console.WriteLine(solution.IsAnagram("listen", "silent")); // True
        Console.WriteLine(solution.IsAnagram("hello", "world"));   // False
        Console.WriteLine(solution.IsAnagram("rat", "car"));       // False
        Console.WriteLine(solution.IsAnagram("a", "a"));           // True
        Console.WriteLine(solution.IsAnagram("ab", "a"));          // False (разная длина)
    }
}