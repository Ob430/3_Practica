using System;

namespace _3_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Массив. Введите длинну массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                a[i] = r.Next(-25, 25);
                Console.Write(a[i].ToString() + "  ");
            }
            int min = Math.Abs(a[0]);
            for (int i = 0; i < n; i++)
            {
                if(Math.Abs(a[i])<=Math.Abs(min))
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Минимальный: " + min.ToString());

            Console.WriteLine("Задание 2");
            int[] arr = new int[] { 2, 5, 3, 8, 0, 5, 2, 0, 8, 6, 6, 6, 6 };
            Console.WriteLine("2  5  3  8  0  5  2  0  8  6  6  6  6");
            int count, O;
            for (O = 0; O < arr.Length; O++)
            {
                count = 0;
                for (int j = O; j < arr.Length; j++)
                    if (arr[O] == arr[j])
                        count++;
                if (count == 1) break;
            }
            Console.WriteLine("Уникальный элемент: " + arr[O]);


            Console.WriteLine("Задание 3. Введите длинну массива");
            int n1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            Random r1 = new Random();
            for (int P = 0; P < n; P++)
            {
                a1[P] = r1.Next(-25, 25);
                Console.Write(a1[P].ToString() + "  ");
            }
            Console.WriteLine("Без отрицательных");
            for (int P = 0; P < n; P++)
            {
                a1[P] = r1.Next(25);
                Console.Write(a1[P].ToString() + "  ");
            }
        }
    }
}
