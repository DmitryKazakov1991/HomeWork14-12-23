//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Спасибо псевдокоду на википедии ибо я так ничего и не понял
class Task2
{
    private static void Main(string[] args)
    {
        static int ackermann(int n, int m) 
        {
            if (n == 0)
			    return m + 1;
		    else
			    if ((n != 0) && (m == 0))
			        return ackermann(n - 1, 1);
			    else
			        return ackermann(n - 1, ackermann(n, m - 1));
        }

        int n = 3;
	    int m = 5;
        Console.WriteLine("Result: " + ackermann(n, m));
    }

}