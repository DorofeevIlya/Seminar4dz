// 48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N;
Console.Write("Введите размер массива [a] : ");
N=Convert.ToInt32(Console.ReadLine());
int[] a;
a=new int[N];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);
for (int i=0;i<a.Length;i++)
System.Console.Write($" {a[i]} ");
Console.WriteLine();
Console.WriteLine("Массив произведений пар чисел:");
for (int i = 0; i<a.Length/2; i++)
Console.Write($" {a[i]*a[a.Length-1-i]} ");
