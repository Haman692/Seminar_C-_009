// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


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
int count = 1;
int number = AddNumber("Введите число");
NumberPlus(number, count);