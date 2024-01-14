//Console.WriteLine("Valentina");

int[] array = { 2, -4, -7, -3, 9, 3, 5, 0, -7, -66, -55 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}