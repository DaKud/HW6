﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Введите элементы(через пробел): "); // ввод с клавиатуры
// string p = Console.ReadLine(); // задаем название строке
// string[] ppp = p.Split(" "); // строчный массив, сплит и пробел в кавычках дает пробел между, вводимых с клавы, символов
// int[] arr = new int[ppp.Length]; // размер числового массива аrr = размеру строчного ppp

// for (int i = 0; i < arr.Length; i++)// перебираем числа
// {
//     arr[i] = int.Parse(ppp[i]);// преобразуем в числа
// }
// Console.WriteLine();

// int count = 0;// счётчик

// int AAAA ( int[] arr, int count) // новая функция
// {
//     for (int i = 0; i < arr.Length; i++)
// {
//         if (arr[i] > 0)
//            count++;
        
// }
// return count;
// }

// int RRRR = AAAA(arr, count); //функции АААА присваиваем имя int RRRR, чтобы в дальнейшем вывести
// Console.WriteLine("В ряду " + RRRR + " чисел > 0");// выводим