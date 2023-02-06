// 45. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a;
a=new int[10];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);
for (int i=0;i<a.Length;i++)
System.Console.Write($" {a[i]} ");
int sum=0;
for (int i=0;i<a.Length;i++)
    if (a[i]%2==0) sum++;
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных четных чисел = {sum}");
System.Console.WriteLine($"Сумма положительных нечетных чисел = {a.Length-sum}");
