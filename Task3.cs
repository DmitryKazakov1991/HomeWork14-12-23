//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы

class Task3
{
	public static void Main(string[] args) {
		
		int[] array = {1,2,3,4,5,6,7,8,9};
		int i = array.Length - 1;
	    printNumbers(array, i);
	

	    void printNumbers(int[] array, int i) {
	    
	    	if (i == 0) {
	          Console.Write(array[i] + " ");
	           return;
	        }
	        Console.Write(array[i] + " ");
	        printNumbers(array, i-1); 
	    } 
    }
}