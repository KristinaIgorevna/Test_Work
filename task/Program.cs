// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
string[] array1 = new string[5] { "1234", "54", "654", "computerscience", "yes" };
string[] array2 = new string[array1.Length];
void FormMass(string[] array1, string[] array2);
{
    count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) 
        {
            array2[count] = array1[i];
        count++;
        }
    }
    Console.WriteLine(array2[count]);
}
void Print(int[] array)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
FormMass(array1, array2);
//Print(array1);
Print(array2);


// int[] MassNums()
// {
//     int[] arr = new int[];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(from, to);
//     }
//     return arr;
// }

// int[] Formatmass(int[] arr)
// {

//     int[] new_arr = new int[];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         count = 0;
//         if (array[i] <= 3)
//         {
//             arr[i] = new_arr[count];
//             count++;
//             //new_arr[i]= arr [i];
//         }
//         return Formatmass;
//     }
// }

