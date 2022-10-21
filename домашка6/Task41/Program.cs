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
int positivNumber = 0;
int currentValue = a;
int limit = d;

{
if(a>0)
{
   positivNumber++; 
}
if(b>0)
{
   positivNumber++;  
}
if(c>0)
{
    positivNumber++; 
}
if(d>0)
{
    positivNumber++; 
}
}

Console.WriteLine("Количество чисел больше 0: " + positivNumber);