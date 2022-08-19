System.Console.WriteLine("Программа покажет все четные числа в диапазоне введеных чисел");
System.Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if (num2 > num1)
    for (int i=num1; i <= num2; i++)

    if (i % 2 == 0)
        System.Console.Write(i+ " ");

else if (num1 > num2);
    for (int i=num2; i <= num1; i++)

    if (i % 2 == 0)
        System.Console.Write(i+ " ");
else System.Console.WriteLine("Диапазон отсутствует");
