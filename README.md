# Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк длина которых меньше либо равна 3 символам.  
Первоначальный массив можно ввести с клаваитуры, либо задать на старе выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительнвми массивами.Задача: 

# Блок-схема к решению 

# Решение:
*Объявляем массив с названием* **myarray**
String[] myarray = { "world", "yes", "no", "Helou", "125", "25", "4567", "123" };

*Cоздаем метод **arr** заданного массива на экран*
void arr(string[] arrString) 
{
    for (int i = 0; i < arrString.Length; i++)
    {
        Console.Write(arrString[i] + " ");
    }
}

*Bыводим объявленный массив с помощью созданного метода*
arr(myarray);
Console.WriteLine();

*Создаем новый массив, в который будем собирать каждый элемент*
var ar = new string[myarray.Length];
var arSize = 0;

foreach (var value in myarray)
{
    if (value.Length <= 3)
    {
        ar[arSize] = value;
        arSize++;
    }
}
arr(ar);
Console.WriteLine();