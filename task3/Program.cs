using System;
class Program
{
    static void Main()
    {
        int [] array = CreateArray(10,10,0);
        Console.WriteLine($"Рандомный массив:" );
        PrintArray(array);
        Console.WriteLine(" ");
        Console.WriteLine($"Перевернутый массив:");
        PrintArray(ArraySwap(array,array.Length-1));
        
        // функция создания массива
        static int [] CreateArray (int size, int max, int min)
        {
            int [] array  = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                array [i] = rand.Next(min,max+1);
            }
            return array;
        }
    }
        // Функция вывода массива
        static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + ",");
        }
        }
        // Функция переворачивания массива
        static int [] ArraySwap(int [] array,int index)
        {

            if (index <= 0)
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - index-1];
            array[array.Length - index-1] = temp;
            return ArraySwap(array,index -= 2);
        }
    }
