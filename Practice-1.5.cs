/*
# Проверка правильности скобочной последовательности

Дана строка `s`, состоящая из символов `'('`, `')'`, `'{'`, `'}'`, `'['` и `']'`. Необходимо определить, является ли входная строка правильной скобочной последовательностью.

Скобочная последовательность считается правильной, если:

- Каждая открывающая скобка закрывается соответствующей ей закрывающей скобкой того же типа.
- Открывающие скобки должны быть закрыты в правильном порядке.
- Каждая закрывающая скобка имеет соответствующую ей открывающую скобку того же типа.

*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите строку скобочную последовательность: ");
        string s = Console.ReadLine();
        bool isValid = IsValid(s);
        Console.WriteLine(isValid ? "Правильная последовательность" : "Неправильная последовательность");
    }

    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> brackets = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s)
        {
            
            if (brackets.ContainsKey(c))
            {
                stack.Push(c);
            }
          
            else if (brackets.ContainsValue(c))
            {
                
                if (stack.Count == 0 || brackets[stack.Pop()] != c)
                {
                    return false;
                }
            }
        }

       
        return stack.Count == 0;
    }
}