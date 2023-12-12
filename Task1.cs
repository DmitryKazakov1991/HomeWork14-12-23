//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

//Сделаем допущение, что M и N > 0 &&  M != N
class Task1
{
    private static void Main(string[] args)
    {
        void printNumbers(int m, int n)
        {
            if (m == n)
            {
                Console.Write(m + " ");
                return;
            }
            Console.Write(m + " ");
            printNumbers(m + 1, n);
        }


        int m = 5;
        int n = 10;
        Console.WriteLine("Result:");
        printNumbers(m, n);
    }
}

