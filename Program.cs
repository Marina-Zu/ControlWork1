// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символам.


void PrintArray(string[] array)                // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.WriteLine(array[i] + "\t");
    }
    System.Console.WriteLine();
}


string[] CreateArray()          // заполнение исходного массива 
{
    string[] array;
    int count;
    string s = "";
    string[] tempArray;
    System.Console.WriteLine("Исходный массив > (для окончания ввода нажмите Enter)");
    Console.WriteLine("Введите элементы массива:");
    count = 0;
    array = new string[count];
    do
    {
        s = Console.ReadLine();
        if (s != "")
        {
            count++;
            tempArray = new string[count];
            for (int i = 0; i < tempArray.Length - 1; i++)
                tempArray[i] = array[i];
            tempArray[count - 1] = s;
            array = tempArray;
        }
    } while (s != "");
    return array;

}

string[] ThreeSymbols(string[] array)
{
    int count = 0;
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[number] = array[j];
            number++;
        }
    }
    return newArray;
}


string[] array = CreateArray();
System.Console.WriteLine("Итоговый массив > ");
PrintArray(ThreeSymbols(array));