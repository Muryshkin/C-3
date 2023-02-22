// Программа, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N. 

//  Пример:  5 -> 1, 8, 27, 64, 125 

 int Pront(string message) 
 { 
   System.Console.Write(message); 
   int result = Convert.ToInt32(System.Console.ReadLine()); 
   return result; 
 } 

 int number = Pront("Введите число: "); 
 for (int N = 1; N <= number; N++) 
 { 
   System.Console.Write($"{Math.Pow(N,3)} "); 
 } 