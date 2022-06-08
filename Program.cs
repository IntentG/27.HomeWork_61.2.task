/*Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника.
*/

///Метод вывода треугольника Паскаля методом зубчатого массива:

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int numberRows = int.Parse(Console.ReadLine());

///Метод заполнения зубчатого массива алгоритмом Паскаля:
int [][] FillPascalArray (int numberRows)
{
    int [][] array = new int [numberRows][];
    array[0] = new int [] { 1 };
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new int [i + 1];
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    array[i][j] = 1;
                else
                    array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
            }
    }
    return array;
}

///Метод печати зубчатого массива в виде равнобедренного треугольника:
void PrintPascalArray(int[][] array, int count)
{
    for (int i = 0; i < array.Length; i++)
        {
            for (int k = array.Length; k > i; k--)
            {
                Console.Write("    ");
            }
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write("{0,8}", array[i][j]);
            }
        Console.WriteLine();
    }
}

int [][] array = FillPascalArray(numberRows);
PrintPascalArray(array, numberRows);




