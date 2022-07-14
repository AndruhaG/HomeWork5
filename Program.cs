//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void Zadacha36()
{
    Console.WriteLine();
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];
    FillArray(array, 0, 10);
    SumNegative();

    void FillArray(int [] array, int startNumber = 0, int finishNumber = 1)
    {
        finishNumber++;
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNumber, finishNumber);
        }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
    }
      
    void SumNegative()
    {
        int SumNegative = 0;
        for (int i = 1; i < array.Length; i+=2)
        {
            SumNegative = SumNegative + array[i];
        }
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = " +  SumNegative);
    }
}


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Zadacha34()
{
    Console.WriteLine();
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 999);
            Console.Write(array[i] + " ");
        }
        
    Console.WriteLine();
    EvenNumbersCount();

    void EvenNumbersCount()
    {
        int count = 0;       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]% 2 == 0)
            count = count + 1;
            

        }
        Console.WriteLine($"Количество чётных чисел в массиве = " +  count);      
    }
}


//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


void Zadacha38()
{
    Console.WriteLine();
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(random.NextDouble() * 10, 2);
        }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    DifferenceMaxMin();

    void DifferenceMaxMin()
    {
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i]) max = array[i];
            else if (min > array[i]) min = array[i];
        }
        
        Console.WriteLine($"Разница между максимальным {max} и минимальным  {min} элементами массива = " +  (max - min));
    }

}




//Zadacha34();
//Zadacha36();
Zadacha38();








