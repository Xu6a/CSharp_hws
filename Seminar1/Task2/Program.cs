// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32( Console.ReadLine() );
int i = - num;

while (i < num)
{
    System.Console.Write(i + ", ");
    i = i + 1;
}
System.Console.WriteLine(i);