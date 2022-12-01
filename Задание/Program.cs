/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] Array = new string[10] {"Love", "In", "Des", "Chanel", "LoL", "invite", "kek", "Good", "cool", "lim",}; // задаем исхродный массив
string[] newarray = new string[Array.Length]; // задаем новый пустой массив
void array(string[] array, string[] newarray ) // объявляем метод где при помощи цикла перебираем элементы в которых длинна строки меньше 3
{ 
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarray[count] = array[i];
        count++;
        }
    }
}
void Printarray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
array(Array, newarray);
Printarray(newarray);