/*
# Две суммы

Дан массив целых чисел `nums` и целое число `target`. Необходимо вернуть индексы двух чисел из массива `nums`, сумма которых равна `target`.

Вы можете предположить, что каждый входной массив имеет только одно решение, и вы не можете использовать один и тот же элемент дважды.

Вы можете вернуть ответ в любом порядке.
*/

using System;

class Program{
	static void Main(){
		string input;
		int target;
		int[] nums;
		int size;
		
		Console.Write("Введите элементы массива: ");
		input = Console.ReadLine();
		nums = Array.ConvetAll(input.Split(' '), int.Parse);
		size = nums.Lenght();

		Console.Write("Введите искомое число: ");
		target = Console.ReadLine();
		
		

		for(int i = 0; i < size, i++){
			for(int j = i + 1; j < size, j++){
				if(nums[i] + nums[j] == target)
					Console.WriteLine($"{i}, {j}");
			}

		}	

	}

}