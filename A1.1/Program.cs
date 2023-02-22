﻿// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. 
//  12821 -> да 
//  14212 -> нет


 Console.Write("Введите число: "); 
 string namber = Console.ReadLine(); //ввод числа 
 int n = namber.Length; // указание длины строки 

 int[] bufer = new int[n]; 
 bool polindrom = true; 

 for (int i = 0; i < n; i++) // перевод из строковой переменой в числовой массив 
 { 
   bufer[i] = namber[i]; 
 } 

 for(int i = 0; i < n; i++) // проверка на полиндром 
 { 
   if(bufer[i] != bufer[n-i-1])// если числа будут не равны, то цикл закончится. 
   { 
     Console.Write("не является полиндромом"); 
     polindrom = false;  
     break; 
   } 
 } 

 if (polindrom) // в случае окончании цикла, polindom = true. 
 { 
     Console.Write(" является полиндромом"); 
 } 
