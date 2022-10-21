//Пользователь вводит с клавиатуры M чисел. Посчитайте,
//сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 4: ");
int d = Convert.ToInt32(Console.ReadLine());
int count =0;
{
while(a>0) count++;
while(b>0) count++;
while(c>0) count++;
while(d>0) count++;
}
Console.WriteLine($"Кол-во элементов больше 0: {count}");
