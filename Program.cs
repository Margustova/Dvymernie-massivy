// двумерные массивы
//  string[,] table = new string[2, 3]; // содержит строки и столбцы
//  int[,] matrix = new int[5, 8]; // если цифры.  первая цифра-(5) строки, вторая (8)- столбцы
// string[,] table = new string[2, 5]; //2 строки и 5 столбцов
// // String.Empty // иницилизация  пустой строки
// //table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4] 
// //table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// table[1, 2] = "слово"; // обращение к двумерному массиву
// {
//     for(int rows = 0; rows< 2; rows++) // перебираем строки
//     {
//         for(int columns = 0; columns < 5; columns++) // перебираем столбцы
//         {
//             Console.WriteLine($"-{table[rows, columns]}-"); // "-" показывает, что вывелось
//         }
//     }
// }
// void PrintArray(int[,] matr) //метод для вывода матрицы
// {

//     for (int i = 0; i < matr.GetLength(0); i++) // конструкция выдаст длину строки (0)- обозначаются строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // конструкция выдаст длину столбца (1)- обозначаются столбец
//         {
//             Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine(); //красивый вывод таблицы чисел
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);  

// void FillArray(int[,] matr) //метод для создания рандомного массива
// {

//     for (int i = 0; i < matr.GetLength(0); i++) // конструкция выдаст длину строки (0)- обозначаются строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // конструкция выдаст длину столбца (1)- обозначаются столбец
//         {
//             matr[i,j] = new Random().Next(1, 10); // новый рандомный массив от [1 до 10) 
//         }
//         Console.WriteLine(); //красивый вывод таблицы чисел
//     }
// }
// // int[,] matrix = new int[3, 4];
// PrintArray(matrix);  // инициализируем
// Console.WriteLine(); //пустая строка для разделения массивов 
// FillArray(matrix); // заполняем
// PrintArray(matrix); // показываем уже заполненный массив

// // Задача на закрашивание нет условия, поэтому будет только начало. 
// void PrintImage(int[,] image) //метод для вывода матрицы
// {

//     for (int i = 0; i < image.GetLength(0); i++) // конструкция выдаст длину строки (0)- обозначаются строки
//     {
//         for (int j = 0; j < image.GetLength(1); j++) // конструкция выдаст длину столбца (1)- обозначаются столбец
//         {
//             //Console.Write($"{image[i, j]}");
//             if(image[i,j]==0) Console.Write($" "); 
//             else Console.Write($"+");
//         }
//         Console.WriteLine(); //красивый вывод таблицы чисел
//     }
// }
// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col); // идем вверх ! метод который вызывает сам себя- рекурсия!
//         FillImage(row, col-1); // идем влево
//         FillImage(row+1, col); // идем вниз
//         FillImage(row-1, col+1); // идем вправо
//     }
// }
// PrintImage(pic);  
// FillImage(13, 13); // точка внутри нашей области
// PrintImage(pic); //выводим уже закрашенную область

// // Задача 2: Вычисление Факториала (решение рекурсией)

// double Factorial (int n) // до 17! можно int
// {
//     // 1! = 1
//     // 0! =1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for( int i = 1; i < 40; i++) //если надо найти факториал 40, если нет,то length
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); //после факториала 17 память переполнена и идут отрицательные значения, 
//     // чтобы это избежать используем double на вывод результата
// }

// Задача на числа Фибоначчи -тоже рекурсией 
// Число Фибоначчи где каждое след число задается через предыдущее
// f(1) =1
// f(2) = 1
// // f(n) = f(n-1) + f(n-2)
// double Fibonacci(int n)
// {
//     if(n==1 || n==2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i =1; i < 25; i++) //найдем фибоначчи от 10
// {
//     Console.WriteLine($"F({i}) = {Fibonacci(i)}");  // после 40 числа считается очень медленно
// }
