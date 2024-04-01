// See https://aka.ms/new-console-template for more information

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Введите номер задачи (от 1 до 12)");
int k = Int32.Parse(Console.ReadLine());
switch (k)
{
    case 1: Forth1(); break;
    case 2: Forth2(); break;
    case 3: Forth3(); break;
    case 4: Forth4(); break;
    case 5: Forth5(); break;
    case 6: Forth6(); break;
    case 7: Forth7(); break;
    case 8: Forth8(); break;
    case 9: Forth9(); break;
    case 10: Forth10(); break;
    case 11: Forth11(); break;
    case 12: Forth12(); break;
}

static void Forth1()
{
    //1. Создайте массив целых чисел. Напишете программу, которая выводит сообщение
    //о том, входит ли заданное число в массив или нет.Пусть число для поиска
    //задается с консоли.

    Console.WriteLine("задайте длину одномерного массива");
    int length = Int32.Parse(Console.ReadLine());
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("Введите число для поиска среди элементов массива");
    int number = int.Parse(Console.ReadLine());

    for (int i = 0; i < length; i++)
    {
        if (array[i] == number) { Console.WriteLine("Заданное число входит в массив"); }
        else { Console.WriteLine("Заданное число не входит в массив"); }
    }
}
static void Forth2()
{
    //2.Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
    //Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
    //В результате должен быть новый массив без указанного числа.

    Console.WriteLine("задайте длину одномерного массива");
    int length = Int32.Parse(Console.ReadLine());
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("Введите число для поиска среди элементов массива");
    int number = int.Parse(Console.ReadLine());
    int numberCount = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] != number) { numberCount++; }
        else
        {
            for (int j = i; j< length-1; j++)
            {
                array[j] = array[j+1];
            }
            length--;
            i--;
        }
         
    }
    if (numberCount != 0) { Console.WriteLine("Заданное число не входит в массив"); }
    else
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
static void Forth3()
{
    // 3.Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
    //Для генерации случайного числа используйте метод Random().Пусть будетвозможность создавать массив произвольного размера.
    //Пусть размер массива вводится с консоли.

    Console.WriteLine("задайте длину одномерного массива");
    int length = Int32.Parse(Console.ReadLine());
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    int maxArrayNumber = 0;
    int minArrayNumber = 0;
    int avgArrayNumber = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] > maxArrayNumber) { maxArrayNumber = array[i];}
        if (array[i] < minArrayNumber) { minArrayNumber = array[i];}
        avgArrayNumber = avgArrayNumber + array[i];
        
    }
    avgArrayNumber = avgArrayNumber / length;
    Console.WriteLine();
    Console.WriteLine("Среднее значение элементов массива " +  avgArrayNumber);
    Console.WriteLine("Максимальное значение элементов массива " + maxArrayNumber);
    Console.WriteLine("Минимальное значение элементов массива " + minArrayNumber);

}
static void Forth4()
{
    // 4.Создайте 2 массива из 5 чисел.Выведите массивы на консоль в двух отдельных строках.
    //Посчитайте среднее арифметическое элементов каждого массива и сообщите,
    //для какого из массивов это значение оказалось больше(либо сообщите, что их средние арифметические равны).

    int length = 5;
    int maxNumber = 20;

    int[] array1 = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array1[i] = rnd.Next(maxNumber);
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
    int[] array2 = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        array2[i] = rnd.Next(maxNumber);
        Console.Write(array2[i] + " ");
    }
    Console.WriteLine();
    int avgArray1 = 0;
    int avgArray2 = 0;
    for (int i = 0;i < length; i++)
    {
        avgArray1 += array1[i];
        avgArray2 += array2[i];
    }
    avgArray1 = avgArray1 / length;
    avgArray2 = avgArray2 / length;

    if (avgArray1 == avgArray2) { Console.WriteLine("средние арифметические равны"); }
    else if (avgArray1 > avgArray2) { Console.WriteLine("среднее арифметическое первого массива больше"); }
    else { Console.WriteLine("среднее арифметическое второго массива больше"); }
}

static void Forth5()
{
    // 4.Создайте массив из n случайных целых чисел и выведите его на экран. Размер массива пусть задается с консоли и размер массива может быть больше 5
    //и меньше или равно 10. Если n не удовлетворяет условию - выведите сообщение об этом.Если пользователь ввёл не подходящее число, то программа должна просить
    // пользователя повторить ввод. Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.

    Console.WriteLine("задайте длину одномерного массива больше 5 и /и меньше или равно 10");
    int length = Int32.Parse(Console.ReadLine());
    
    while (length <= 5 || length > 10) 
    { Console.WriteLine("Вы ввели число не из нужного диапазона, повторите ввод");
        length = Int32.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    int[] array2 = new int[length];
    int j = 0;

    for (int i = 1; i < length; i+=2)
    {        
        array2[j] = array[i] ;
        Console.Write(array2[j] + " ");
        j++;
    }

}
static void Forth6()
{
    //5. Создайте массив и заполните массив. Выведите массив на экран в строку.
    //Замените каждый элемент с нечётным индексом на ноль. Снова выведете массив на экран на отдельной строке
    
    Console.WriteLine("задайте длину одномерного массива");
    int length = Int32.Parse(Console.ReadLine());
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine() ;
    for (int i = 1; i < length; i+=2)
    {
        array[i] = 0;        
    }
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
static void Forth7()
{
    //6. Создайте массив строк. Заполните его произвольными именами людей.
    //Отсортируйте массив.Результат выведите на консоль.
    string[] arrayName = { "Иван", "Алексей", "Яков", "Денис", "Ирина", "Света" };
   Array.Sort(arrayName);
    for (int i = 0; i < arrayName.Length; i++)
    {
        
        Console.Write(arrayName[i] + " ");
    }
    Console.WriteLine();

}
static void Forth8()
{
    //7.Реализуйте алгоритм сортировки пузырьком.

    Console.WriteLine("задайте длину одномерного массива");
    int length = Int32.Parse(Console.ReadLine());
    Console.WriteLine("задайте максимальное число диапазона значений массива");
    int maxNumber = Int32.Parse(Console.ReadLine());

    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(maxNumber);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    int temp = array[0];
    
    Console.WriteLine();
    for (int i = 0; i < length; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            if (array[i] >= array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    Console.WriteLine("отсортированный по возрастанию массив");
    for (int i = 0; i < length; i++)
    {        
        Console.Write(array[i] + " ");
    }

}
static void Forth9()
{
    //8. Умножение двух матриц
    //Создайте два массива целых чисел размером 3х3(две матрицы).
    //Напишите программу для умножения двух матриц.
    //Первый массив: { { 1,0,0,0},{ 0,1,0,0},{ 0,0,0,0} }
    //Второй массив: { { 1,2,3},{ 1,1,1},{ 0,0,0},{ 2,1,0} }
    //Ожидаемый результат: 1 2 3 1 1 1 0 0 0
    int lengthRow = 3;
    int lengthCol = 3;
    int[,] array1 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
    int[,] array2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 } };
    int[,] arrayRes = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }; 
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {            
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {            
            Console.Write(array2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int k = 0; k < array1.GetLength(0); k++)
    {
        for (int i = 0; i < array2.GetLength(1); i++)
        {
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                arrayRes[k, j] = arrayRes[k, j] + (array1[k, j] * array2[j, i]);                
            }            
        }
    }

    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Console.Write(arrayRes[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void Forth10()
{
    //9. Создайте двумерный массив целых чисел. Выведите на консоль сумму всех     элементов массива.
    int lengthRow = 3; 
    int lengthCol = 3;
    int num = 20;
    int[,] array = new int[lengthRow, lengthCol];
    Random rnd = new Random();
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = rnd.Next(num);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    int Sum = 0;
    
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Sum += array[i, j]; 
        }        
    }

    Console.WriteLine(Sum);

}
static void Forth11()
{
    //10 Создайте двумерный массив. Выведите на консоль диагонали массива.
    int lengthRow = 5;
    int lengthCol = 5;
    int num = 20;
    int[,] array = new int[lengthRow, lengthCol];
    Random rnd = new Random();
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = rnd.Next(num);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("from left to right");

    for (int i = 0; i < lengthCol; i++)
    {        
            Console.Write(array[i, i] + " ");       
    }
    Console.WriteLine();
    Console.WriteLine("from right to left");
    int k = 0;
    for (int i = lengthCol-1; i >= 0; i--)
    {
        Console.Write(array[i, k] + " ");
        k++;
    }
}
static void Forth12()
{
    //11. Создайте двумерный массив целых чисел. Отсортируйте элементы в строках
    //двумерного массива по возрастанию.
    int lengthRow = 5;
    int lengthCol = 5;
    int num = 20;
    int[,] array = new int[lengthRow, lengthCol];
    Random rnd = new Random();
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = rnd.Next(num);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    int temp = array[0,0];
    int k = lengthCol - 1;

    Console.WriteLine();
   
    for (int i = 0; i < lengthRow; i++)
    {
       // Console.WriteLine("row " + i);
        int j = 0;
        while (j < lengthCol - 1)              
        {
            if (array[i, j] > array[i, j + 1])
            {
               // Console.WriteLine(array[i, j] + "  " + array[i, j + 1]);
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
                j=0;
            } else { j++; }
        }
    }

    Console.WriteLine("Строки массива отсортированные по возрастанию");
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}
