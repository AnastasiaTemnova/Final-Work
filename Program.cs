// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
string[] arrayStart = new string[13] {"Hello", "Cat", "!", "Hi", "Dog", "Home", "12579", "English", "Tea", "Coffee", "Bat", "Book", "Bee"};
string[] arrayFinal = new string[arrayStart.Length];
void ShortArray(string[] arrayStart, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayFinal[count] = arrayStart[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ShortArray(arrayStart, arrayFinal);
PrintArray(arrayFinal);