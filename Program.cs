// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.




// void Palindrom()
//         {
//             uint a = uint.Parse(Console.ReadLine());
//             uint b = a;
//             var col = new List<uint>();
//             while (b > 0)
//             {
//                 col.Add(b % 10);
//                 b = b / 10;
//             }
//             b = 0;
//             col.Reverse();
//             for(int mcol = 0; mcol < col.Count; mcol++)
//                 b = b + col[mcol] * (uint)Math.Pow(10, mcol);
//             if (a == b)
//                 Console.WriteLine("да");
//             else
//                 Console.WriteLine("нет");
//             Console.ReadLine();
//         }





// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string Name1, string Name2)
// {
//     Console.Write($"Введите координату {Name1} точки {Name2}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segment =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segment}");


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



// void Program (int number)
// {

//     for (int number1 = 1;number1 <= number; number1++)
//     {
//         System.Console.Write(number1*number1*number1 + " ");
//     }
// }
// System.Console.WriteLine("Please, write number");
// int num = Convert.ToInt32(Console.ReadLine());
// Program(num);
