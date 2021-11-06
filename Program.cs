// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
// 1.Нарушают порядок возрастания
// 2.Больше среднего арифметического элементов A
// 3.Чётные
int length = 50;
int[] arrayA = new int[length];
int indexA = 0;
while (indexA < length)                      // первый массив
{
    arrayA[indexA] = new Random().Next(10, 100);
    indexA++;
}

indexA = 0;
while (indexA < length)                      //вывод первый массив
{
    Console.WriteLine($"A{indexA + 1} = {arrayA[indexA]}");
    indexA++;
}

indexA = 0;                         //среднее арифметическое массива А
int temp = 0;
while (indexA < length)
{
    temp = arrayA[indexA] + temp;
    indexA++;
}
int midA = temp / arrayA.Length;
Console.WriteLine($"среднее арифметическое А = {midA}");

indexA = 0;
int[] arrayB = new int[length];
int indexB = 0;                          //заполняем второй массив

while (indexA < length)
{
    if ((arrayA[indexA] < midA) && (arrayA[indexA] % 2 != 0))
    {
        arrayB[indexB] = arrayA[indexA];
        indexA++;
        indexB++;
    }
    else
    {
        indexA++;
    }
}

if (indexB == 0)
{
    Console.WriteLine("Нет значений для заполнения второго массива.");
}

indexB = arrayB.Length - 1;
while (arrayB[indexB] == 0)
{
    length = length - 1;
    indexB = indexB - 1;
}
indexB = 0;
int currentElement = arrayB[0];
Console.WriteLine($"B{indexB + 1} = {currentElement}");
while (indexB <= (length - 1))
{
    if(arrayB[indexB]>currentElement)
    {
        Console.WriteLine($"B{indexB + 1} = {arrayB[indexB]}");
        currentElement = arrayB[indexB];
    }
    indexB++;
}