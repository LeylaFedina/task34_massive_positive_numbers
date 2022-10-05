/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int [] getRandomArray (int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i ++)
    {
        resultArray [i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray (int [] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray [i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine ("]");
}
int getQuantityOfEvenNumbersInArray (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] % 2 ==0)
        {
            result = result + 1;
        }
    }
    return result;
}

int [] currentArray = getRandomArray(10, 100, 999);
printArray (currentArray);
int QuantityOfEvenNumber = getQuantityOfEvenNumbersInArray (currentArray);
Console.WriteLine($"количество четных чисел {QuantityOfEvenNumber}");
