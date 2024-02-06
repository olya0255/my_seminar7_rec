// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

 int [] array = CreateArray(1, 2, 5, 0, 10, 34);

 int rows = array.GetLength(0);
 int cols = array.GetLength(1);
 string output = "";
 for (int i = 0; i < rows; i++)
 {
    for (int j = 0; j < cols; j++)
    {
       output += array[array i, j] + " ";
    }
    System.Console.WriteLine($"[ {output}]");
    output = "";
 }
