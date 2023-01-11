// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Kol(int num1) // Метод вычисляет количество цифр в введенном числе
{
    int i = 0;
    while (num1 > 0)
    {
        num1 = num1 / 10;
        i++;
    }
    return i;
}

void Sum()
{
    int[] array = new int[Kol(num)];
    int sum = 0;
    int num2 = num;
    for (int i = 0; i < Kol(num); i++)
    {
        array[i] = num2 % 10;
        num2 = num2 / 10;
        sum = sum + array[i];
    }
    Console.Write($"Сумма цифр в числе: {sum}");
}
Sum();