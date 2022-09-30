string[] array = { "hello", "-2", "there", "hi", "hey", "hola", "good morning", "!" };
string[] newArray = new string[array.Length];

string[] FillNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}

Console.WriteLine(String.Join(", ", FillNewArray(array, newArray)));
