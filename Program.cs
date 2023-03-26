// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

// метод печатает одномерный массив
void Print1DArr(string[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[arr.Length - 1]);
  Console.WriteLine("]");
}

// метод нахождения в массиве строк, длина которых меньше либо равна 3 символа
string[] ThreeSimbArray(string[] arr, int count)
{
  string[] result = new string[0];
  for (int index = 0; index < arr.Length; index++)
  {
    if (arr[index].Length <= count)
    {
      result = result.Concat(new string[] { arr[index] }).ToArray();
    }
  }
  return result;
}

string[] testArr = { "30", "ups", "154987", "-1", "name" };
Console.WriteLine("Исходный массив:");
Print1DArr(testArr);
string[] newArr = ThreeSimbArray(testArr, 3);
Console.WriteLine("Строки массива, длина которых меньше либо равна 3 символа:");
if (newArr.Length != 0)
{
  Print1DArr(newArr);
}
else
{
  Console.WriteLine("строки отсутствуют.");
}
