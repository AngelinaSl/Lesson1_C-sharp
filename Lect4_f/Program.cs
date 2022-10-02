/*
Первая группа методов — не принимает никаких аргументов и ничего не возвращают
*/

// void Metod1()
// {
// Console.WriteLine("Автор …");
// }
// Method1();


/*
Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.
*/

// void Metod2(string msg)
// {
// Console.WriteLine(msg);
// }
// Metod2("Текст сообщения");  //Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//        Console.WriteLine(msg); 
//       i++;
//     }

// }
// Metod21("Текст сообщения", 4); // Metod21(count:4, msg: "Текст сообщения");

/*
Третья группа методов — может что-то возвращать, но не принимает никаких аргументов. Например, может служить для генерации случайных данных.
*/

// int Metod3()
// {
// return DateTime.Now.Year;
// }
// int year = Metod3();
// Console.WriteLine(year);


/*
Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
возвращает для дальнейшей работы.
*/

// string Metod4(int count, string text)
// {
// int i = 0;
// string result = String.Empty; // пустая строка
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// string res = Metod4(10, "Hello ");
// Console.WriteLine(res);


/*
Цикл for:
*/

// string Metod4(int count, string text)
// {
// string result = String.Empty;
// for (int i = 0; i<count; i++) 
// {
//      result = result + text;
// }
// return result;
// }
// string res = Metod4(10, "Hello ");
// Console.WriteLine(res);

/*
Цикл в цикле:
*/

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



/*
Задача.
Дан текст. В тексте нужно все пробелы заменить чёрточками,
маленькие буквы “к” заменить большими “К”,
а большие “В” маленькими “в”.
*/

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";




// string Replace(string text, char oldValue, char newValue) // метод замены одного символа в строке/тексте на другой
// {
//     string result = String.Empty; // пустая строка, чтоб не забыть присвоить

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";

//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ' , '|'); // для типа данных char нужны одинарные ковычки
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к' , 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'В' , 'в');
// Console.WriteLine(newText);

/*
Упорядочить массив: 
Было: 1 8 3 2 6 4 5 7
Стало: 1 2 3 4 5 6 7 8
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // вывод массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


