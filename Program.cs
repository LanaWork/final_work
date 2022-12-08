/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */
string[] num1 = new string[4] {"hello", "2", "world", ":)"};
string[] num2 = new string[num1.Length];
void SecondArrayWithIF(string[] num1, string[] num2)
{
    int count = 0;
    for (int i = 0; i < num1.Length; i++)
    {
    if(num1[i].Length <= 3)
        {
        num2[count] = num1[i];
        count++;
        }
    }
}
void PrintArray(string[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(num1, num2);
PrintArray(num2);