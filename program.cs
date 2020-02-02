using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			//for (int a = 0; a < 10000000; a++) //многократная проверка программы
			{
				Random rnd = new Random(); //создание объекта рандома
				int[] arr = new int[1000]; //объявление массива
				for (int i = 0; i < 1000; i++) //цикл заполнения массива случайными числами от 0 до 10000
				{
					arr[i] = rnd.Next(0, 10000);
				}

				int R = arr[0];

				for (int i = 0; i < arr.Length; i++) //поиск максимума массива и присвоение его R
				{
					if (arr[i] > R) { R = arr[i]; }
				}

			   /* проверка на условие (R кратно 14 и является произведением двух случайных чисел массива), 
				* если подходит, выводится R, если нет, выводится -1 */
				if ((R % 14 == 0) && (R == ((arr[new Random().Next(0, arr.Length)]) * (arr[new Random().Next(0, arr.Length)]))))
				{
					Console.WriteLine(R);
				}
				else { Console.WriteLine("-1"); }
			}
		}
    }
}
