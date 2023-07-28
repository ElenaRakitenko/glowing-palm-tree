
 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 25");
 Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

// запрашиваем ввод значений


Console.WriteLine("Введите целое число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число В");
int numberB = Convert.ToInt32(Console.ReadLine());


int GetDegreeNumber()
{
    int result = 1;

    for (int i = 1; i <= numberB; i++)

    {
        result= result * numberA;
    }

    return result;

}

int result=GetDegreeNumber();
Console.WriteLine(result);





Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 27");
 Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");

// запрашиваем ввод значений

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

 while(num > 0)
 {
  int num1 = num % 10;
  num = num /10;
  sum = sum + num1;

 }
 Console.WriteLine($"Сумма цифр в числе равна {sum}");



Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Задача 27");
 Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран");

// запрашиваем ввод значений


int[] array= new int[8];

 GetRandomArray();

void GetRandomArray()
{
    for (int i = 0; i <array.Length; i++)

    {
        array[i] = new Random().Next(0,9);
        Console.Write(array[i]+"");
    }

};

Console.WriteLine("Программа HomeWork #4 завершена.");
return 0;