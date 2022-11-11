Console.Write("Введите количество элементов Вашего массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] Array1 = new string[n]; 

for (int i = 0; i < n; i++)
    {
    Console.Write("Элемент №{0}:   ", i + 1);
    Array1[i] = Console.ReadLine();
    }

string[] array2 = new string[Array1.Length];
int count = 0;

for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        array2[count] = Array1[i];
        count++;
        }
    }

void PrintArray(string[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write($"{Array1[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array2);