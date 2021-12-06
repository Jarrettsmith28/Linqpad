<Query Kind="Statements" />

int[] sortingArray = new int[10]
{
    10,
    9,
    8,
    7,
    6,
    5,
    4,
    3,
    2,
    1,
};


Console.WriteLine(sortingArray);
int arrayLength = sortingArray.Length;
for (int i = 0; i < arrayLength; i++)
{
for (int j = 0; j < arrayLength; j++)
{
    if (j + 1 > arrayLength-1)
    {
        break;
    }
    if (sortingArray[j] > sortingArray[j + 1])
    {
        SwapValues(sortingArray, j + 1, j);
    }
}
}
static void SwapValues(int[] array, int value1, int value2)//swaps values in an array of ints
{
    int temp = array[value2];
    array[value2] = array[value1];
    array[value1] = temp;
}

Console.WriteLine(sortingArray);