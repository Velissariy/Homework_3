// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Input a five-digit number :");
string m = (Console.ReadLine());           
char[] arr = m.ToCharArray(); //Converting a number to an array of digits
int i = arr.Length;    

if ( i < 5 || i > 5) // checking the entered number for compliance with the five-digit
    Console.WriteLine("a non-five-digit number has been entered");
else
      if (arr [0] == arr[4] && arr [1] == arr[3]) 
     { foreach (char ch in arr)
      {
          Console.Write(ch);
      }
      Console.Write(" ->"+ " да");}
    else
    { foreach (char ch in arr)
      {
          Console.Write(ch);
      }
      Console.Write(" ->"+ " нет");}
