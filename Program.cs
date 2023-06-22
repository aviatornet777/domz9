
// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 
 
 // Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int startNum=1;

// Console.WriteLine(PrintNumbers(startNum,num));

// string PrintNumbers(int num1, int num2) //создаем метод. string чтобы результат не суммировался, а каждое число добавлялось как следующее
// {
//     if(num1==num2)
//     {
//         return num1.ToString();;
//     }
//     return (num2+ " " +PrintNumbers(num1,num2-1));//если  int, то сложение, string-присоединение
// }





// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.


// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNum(num, number));

// int PrintNum(int num1, int num2)
// {
//     if (num1>num2)
//     {
//         Console.WriteLine("не корректные числа");
//         return 0;
//     }
//     if(num1==num2)
//      {
//          return num1;
//      }
//      return (num1 + PrintNum(num1+1,num2));
// }








// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.WriteLine(Akkerman(m, n)); 
// }


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }