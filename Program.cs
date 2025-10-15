using System;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Collections.Generic;
namespace CS_First
{
    public class Program
    {

        static void InitializeBoard(int[,] board)
        {
            int value = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 3 && j == 3)
                    {
                        board[i, j] = 0; // Пустое место
                    }
                    else
                    {
                        board[i, j] = value;
                        value++;
                    }
                }
            }
        }

        static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{board[i, j],2} ");
                }
                Console.WriteLine();
            }
        }
        static void ShuffleBoard(int[,] board, int moves)
        {
            Random rand = new Random();
            int emptyRow = 3, emptyCol = 3;

            for (int i = 0; i < moves; i++)
            {
                // Список возможных направлений для перемещения пустого места
                var directions = new (int, int)[]
                {
                (-1, 0), // вверх
                (1, 0),  // вниз
                (0, -1), // влево
                (0, 1)   // вправо
                };

                // Выбираем случайное направление
                var direction = directions[rand.Next(directions.Length)];
                int newRow = emptyRow + direction.Item1;
                int newCol = emptyCol + direction.Item2;

                // Проверяем, что новое положение пустого места находится в пределах доски
                if (newRow >= 0 && newRow < 4 && newCol >= 0 && newCol < 4)
                {
                    // Меняем местами пустое место и соседний элемент
                    board[emptyRow, emptyCol] = board[newRow, newCol];
                    board[newRow, newCol] = 0;

                    // Обновляем положение пустого места
                    emptyRow = newRow;
                    emptyCol = newCol;
                }
            }
        }

        static void Main(string[] args)
        {

            /*Пользователь вводит размеры прямоугольного массива, 
             * программа заполняет его случайными числами в 
             * указанном диапазоне,
            после чего копирует в одномерный массив 
            те числа из двумерного, которые не повторяются.*/
            //Console.WriteLine("Введите высоту массива: ");
            //int a = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите ширину массива: ");
            //int b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите минимальное значение диапазона: ");
            //int min = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите максимальное значение диапазона: ");
            //int max = Int32.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Random rand = new Random();
            //int[,] array = new int[a, b];
            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //// Заполнение массива случайными числами и подсчет частоты каждого числа
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        array[i, j] = rand.Next(min, max + 1);
            //        Console.Write($"{array[i, j]} ");
            //        if (frequency.ContainsKey(array[i, j]))
            //        {
            //            frequency[array[i, j]]++;
            //        }
            //        else
            //        {
            //            frequency[array[i, j]] = 1;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //// Копирование уникальных чисел в список
            //List<int> uniqueNumbers = new List<int>();
            //foreach (var item in frequency)
            //{
            //    if (item.Value == 1)
            //    {
            //        uniqueNumbers.Add(item.Key);
            //    }
            //}
            //int[] arr = new int[uniqueNumbers.Count];
            //// Вывод одномерного массива уникальных чисел
            //Console.WriteLine("\nУникальные числа:");
            //for (int i = 0;i < arr.Length;i++)
            //{
            //    arr[i] = uniqueNumbers[i];
            //    Console.Write($"{arr[i]} ");
            //}


            /*Пользователь вводит высоту пирамиды, программа выводит на экран пирамиду такого вида:
              5 4 3 2 1
                4 3 2 1
                  3 2 1
	                    2 1
	                      1*/

            //Console.WriteLine("Введите высоту пирамиды: ");
            //int height = Int32.Parse(Console.ReadLine());
            //// Создаем зубчатый массив
            //int[][] pyramid = new int[height][];
            //for (int i = 0; i < height; i++)
            //{
            //    pyramid[i] = new int[height - i];
            //}

            //// Заполняем зубчатый массив и выводим пирамиду
            //for (int i = 0; i < height; i++)
            //{
            //    // Заполняем текущую строку
            //    for (int j = 0; j < pyramid[i].Length; j++)
            //    {
            //        pyramid[i][j] = height - i - j;
            //    }

            //    // Выводим пробелы перед числами
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("  ");
            //        //if ((height - i - k) < 2 && (height - i - k) > 0)
            //        //{
            //        //    Console.Write("    ");
            //        //}
            //    }

            //    // Выводим текущую строку
            //    for (int j = 0; j < pyramid[i].Length; j++)
            //    {
            //        Console.Write($"{pyramid[i][j]} ");
            //    }

            //    Console.WriteLine();
            //}




            /*В игре "Пятнашки" нужно сгенерировать начальное игровое поле
             * и вывести его на экран.*/

            Random rand = new Random();
            int easy = rand.Next(20, 100);
            int middle = rand.Next(150, 1000);
            int hard = rand.Next(1200, 100000);
            int[,] board = new int[4, 4];
            InitializeBoard(board);
            ShuffleBoard(board, hard);
            PrintBoard(board);

        }
    }

}


