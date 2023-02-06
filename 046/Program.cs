// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] a;
a=new int[123];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(0,300);
for (int i=0;i<a.Length;i++)
System.Console.Write($" {a[i]} ");
int с=0;
for (int i=0;i<a.Length;i++)
    if (a[i]>9 && a[i]<100) с++;
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел в отрезке от 10 до 99 = {с}");

