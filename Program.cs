// Написать программу, которая из имеющегося массивастрок формирует массив из строк длина которых меньше либо равна 3 символам .
// Первоначальный массив можно ввести с клаваитуры, либо задать на старе выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительнвми массивами.

String[] myarray = { "world", "yes", "no", "Helou", "125", "4567", "123" };

void arr(string[] arrString)  // метод вывода заданного массива на экран
{
    for (int i = 0; i < arrString.Length; i++)
    {
        Console.Write(arrString[i] + " ");
    }
}

void SelectLenght(string[] array) // метод определения длины строки <= 3
{
    for(int i = 0; i < array.Length; i++ )
    {
        Console.Write(i +" ");
    }
}   

arr(myarray);
Console.WriteLine();
SelectLenght(myarray);
Console.WriteLine();

// var result = new string[myarray.Length];
// var realSize = 0;

// foreach (var value in myarray)
// {
//     if (value.Length <= 3)
//     {
//         result[realSize] = value;
//         realSize++;
//     }
// }
// Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));


// string result = string.Empty;
// int text.Length = 0;


// for (int i = 0; i < myarray.Length; i++)
// {
//     int[] array = new int[myarray.Length];
//         for (int j = 1; j < array.Length; j++)
//         {
//             if (array[j] <= 3)
            
//         }
//         Console.WriteLine(myarray[i]);
// }


