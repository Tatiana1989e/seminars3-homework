/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Input number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
 if (number[0]==number[4] || number[1]==number[3])
 {
 Console.WriteLine($"This is the number: {number} - palindrome.");
  }
 else Console.WriteLine($"This is the number: {number} - not palindrome.");
}

if (number!.Length == 5)
{
 CheckingNumber(number);
}
else Console.WriteLine($"Five digit number");
*/
/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance (double x1, double y1, double x2, double y2, double t1, double t2 )
{
   return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(t2-t1, 2)); 
  
}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input t1: ");
double ta = Convert.ToDouble(Console.ReadLine());
Console.Write("Input t2: ");
double tb = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistance(xa, xb, ya, yb, ta, tb);
Console.WriteLine($"Distance is {coordinate}");
*/
/*
// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowCube (int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Cube number {current} = {current * current * current}");
        current++;
    }

}
Console.Write("Input any integer: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCube(number);
*/