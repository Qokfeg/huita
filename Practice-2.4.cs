using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var strs1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result1 = GroupAnagrams(strs1);
        PrintResult(result1);

        var strs2 = new string[] { "" };
        var result2 = GroupAnagrams(strs2);
        PrintResult(result2);

        var strs3 = new string[] { "a" };
        var result3 = GroupAnagrams(strs3);
        PrintResult(result3);
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            // Сортируем строку, чтобы использовать как ключ
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string key = new string(charArray);

            // Добавляем в словарь
            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(str);
        }

        return new List<IList<string>>(anagrams.Values);
    }

    private static void PrintResult(IList<IList<string>> result)
    {
        foreach (var group in result)
        {
            Console.WriteLine("[{0}]", string.Join(", ", group));
        }
    }
}
