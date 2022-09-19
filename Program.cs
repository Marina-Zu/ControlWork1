// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символам.


void PrintArray(string[] array)                // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}


string[] CreateArray()          // заполнение исходного массива 
{
    string[] array;
    int count;
    string s = "";
    string[] tempArray;
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

PrintArray(CreateArray());