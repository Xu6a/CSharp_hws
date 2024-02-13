/* Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная. */

Console.Clear();
void questNum () {
    while(true) {
        Console.WriteLine("Ввведите целое число: ");
        string str = Console.ReadLine()!;
        int number;
        int num = 0;

        if(str == "q") break;
        
        if(int.TryParse(str, out number)){
            for(int i = 0; i < str.Length; i++){
                num += str[i] - '0';
                Console.WriteLine(num);
            }
            if(num % 2 == 0) break;
        }
    }
}
questNum();



/* Задача 2: Задайте массив заполненный случайными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. */

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
    return array;
}

void countEvenNumbers (int[] array) {
    int count = 0;
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    foreach (int element in array){
        if (element % 2 == 0)
            count++;
    }
    Console.WriteLine(count);
}

countEvenNumbers(inputArray(array));



/* Задача 3: Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.) */

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 301); // [100, 999]
    return array;
}

void expandArr (int[] array) {
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    int tmp;
    for (int i = 0; i < array.Length / 2; i++){
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
}

expandArr(inputArray(array));