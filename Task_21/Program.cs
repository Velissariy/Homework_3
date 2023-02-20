// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double [] a = new double [6]; 
Console.WriteLine("Input x1");
double x1 = Convert.ToInt32(Console.ReadLine());
a [0] = x1;
Console.WriteLine("Input y1");
double y1 = Convert.ToInt32(Console.ReadLine());
a [1] = y1;
Console.WriteLine("Input z1");
double z1 = Convert.ToInt32(Console.ReadLine());
a [2] = z1;
Console.WriteLine("Input x2");
double x2 = Convert.ToInt32(Console.ReadLine());
a [3] = x2;
Console.WriteLine("Input y2");
double y2 = Convert.ToInt32(Console.ReadLine());
a [4] = y2;
Console.WriteLine("Input z2");
double z2 = Convert.ToInt32(Console.ReadLine());
a [5] = z2;


double result = Math.Sqrt((a[0]-a[3])*(a[0]-a[3])+(a[1]-a[4])*(a[1]-a[4])+(a[2]-a[5])*(a[2]-a[5]));
Console.Write( "A ({0}, {1}, {2}); B ({3}, {4}, {5})"+" -> "+ result, a[0], a[1], a[2], a[3], a[4], a[5]);