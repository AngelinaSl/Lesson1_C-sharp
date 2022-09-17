/*
Имеется одномерный массив array из n элементов,
требуется найти элемент массива, равный find.
*/

/*
//              0   1   2   3   4   5   6   7   
int[] array = { 1, 23, 34, 4, 423, 53, 123, 53 };
int n = array.Length;              // длина массива 
int find = 53;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // эта команда останавливает цикл. Если в массиве два числа подходят по условию, а нужно найти одно число, то после нахождения первого цикл прервется.
    }
    index++;
}
*/

void FillArray(int[] collection)        // функция (метод), позволяющий заполнить ячейки массива рандомными числами.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)              // метод позволяет вывести ("напечатать") массив на экран.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод поиска индекса числа, которое равно find. 
    {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создает массив, но по умолчанию все значения равны нулю.

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);


