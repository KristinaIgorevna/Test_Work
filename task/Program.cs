// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

string[] array1 = new string[5] { "1234", "54", "654", "computerscience", "yes" };
string[] array2 = new string[array1.Length];

void FormMass(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) 
        {
              array2[count]=array1[i];
        count++;
        }
    }
    //Console.WriteLine(array2[count]);
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FormMass(array1, array2);
//Print(array1);
Print(array2);

