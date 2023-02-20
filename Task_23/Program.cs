// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Input the number");
int N = Convert.ToInt32(Console.ReadLine());
int degree = 3;
Console.Write(N+" -> ");

for (int count = 0; count <= N; count++)
{
   Console.Write( $"{(long)Math.Pow(count, degree)} ");
}
