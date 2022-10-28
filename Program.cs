// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Inter()
{
    Console.WriteLine("Введите число обозначающее количество чисел");
    int Len = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[Len];
    for (int i = 0; i < massiv.Length; i++)
    {
        int temp = 0;
        Console.WriteLine($"Введите {i + 1} число:");
        temp = Convert.ToInt32(Console.ReadLine());
        massiv[i] = temp;
    }
    return massiv;
}

void TypeMassiv(int[] arr)
{
    Console.WriteLine("Введены числа:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void PlusNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел = {count}");
}
int[] Numbers = Inter();
TypeMassiv(Numbers);
PlusNum(Numbers); 
