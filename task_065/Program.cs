// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void NumberPlus(int num, int count)
{
    if (count <= num)
    {
        System.Console.Write(count + " ");
        count++;
        NumberPlus(num, count);
    }

}
int number = AddNumber("Введите число");
int count = AddNumber("Введите второе число");
NumberPlus(number, count);