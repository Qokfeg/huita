using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    // Кодирование списка строк в одну строку
    public string Encode(IList<string> strs)
    {
        StringBuilder encodedString = new StringBuilder();
        encodedString.Append(strs.Count).Append('|'); // Добавляем количество элементов

        // Проходим по каждому элементу
        foreach (var str in strs)
        {
            // Добавляем префикс и длину строки
            encodedString.Append(str[0]) // Префикс
                         .Append('#') // Разделитель
                         .Append(str.Length) // Длина строки
                         .Append('#') // Разделитель
                         .Append(str); // Сама строка
        }

        return encodedString.ToString();
    }

    // Декодирование строки обратно в список строк
    public IList<string> Decode(string s)
    {
        IList<string> decodedStrings = new List<string>();
        int i = 0;

        // Получаем количество элементов в строке
        int countEnd = s.IndexOf('|', i);
        int count = int.Parse(s.Substring(i, countEnd - i));
        i = countEnd + 1; // Пропускаем |

        for (int j = 0; j < count; j++)
        {
            // Находим префикс, длину и саму строку
            char prefix = s[i];
            i += 2; // Пропускаем префикс и #
            int lengthEnd = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, lengthEnd - i));
            i = lengthEnd + 1; // Пропускаем #
            
            string str = s.Substring(i, length); // Получаем строку
            decodedStrings.Add(str);
            i += length; // Пропускаем строку
        }

        return decodedStrings;
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        IList<string> originalStrings = new List<string> { "hello", "world", "foo", "bar" };

        // Кодируем строку
        string encoded = solution.Encode(originalStrings);
        Console.WriteLine("Encoded: " + encoded);

        // Декодируем строку
        IList<string> decoded = solution.Decode(encoded);
        Console.WriteLine("Decoded: " + string.Join(", ", decoded));
    }
}
