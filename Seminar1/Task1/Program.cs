// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли второе число квадратом первого.
// a = 5, b = 25 => да
// a = 10, b = 2 => нет
// a = -3, b = 9 => да
// a = 9, b = -3 => нет

System.Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32( Console.ReadLine() );
System.Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32( Console.ReadLine() );
if (num1 * num1 == num2)
{
    System.Console.WriteLine("да");
}
else
    System.Console.WriteLine("нет");