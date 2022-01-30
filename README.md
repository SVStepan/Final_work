# Объявляем массив
String[] myarray = { "world", "yes", "no", "Helou", "125", "25", "4567", "123" };

# создаем метод заданного массива на экран
void arr(string[] arrString) 
{
    for (int i = 0; i < arrString.Length; i++)
    {
        Console.Write(arrString[i] + " ");
    }
}

# выводим объявленный массив с помощью созданного метода
arr(myarray);
Console.WriteLine();


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