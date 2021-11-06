// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
// 1.Нарушают порядок возрастания
// 2.Больше среднего арифметического элементов A
// 3.Чётные
int length = 50;
int[] arrayA = new int[length];
int indexA = 0;
while (indexA < length)                      //заполняем первый массив
{
    arrayA[indexA] = new Random().Next(10, 100);
    indexA++;
}

indexA = 0;
while (indexA < length)                      //выводим первый массив
{
    Console.WriteLine($"A{indexA + 1} = {arrayA[indexA]}");
    indexA++;
}