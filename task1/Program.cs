// Создать из массива строк массив строк с элементами длиной меньше 4

void PrintArr(string[] arrayforprint) ///метод печати массива
{
    int len = arrayforprint.Length;
    for (int i = 0; i < len; i++) Console.Write($"{arrayforprint[i]} ");
    Console.WriteLine();
}

int CountElementsLessFour(string[] arrayforcount) /// метод подсчета количества элементов с длиной меньше 4
{
    int count = 0;
    foreach (string element in arrayforcount) if (element.Length < 4) count++;
    return count;
}

string[] ModifyArray(string[] arrayformodify) /// метод, формирующий новый массив с длиной элементов меньше 4
{
    int len = CountElementsLessFour(arrayformodify);  //длина нового массива равна количеству 
    string[] newArray = new string[len];              //элементов исходного массива с длиной меньше 4
    if (len == 0) return newArray;
    else
    {
        int index = 0;
        foreach (string element in arrayformodify) if (element.Length < 4)
            {
                newArray[index] = element;
                index++;
            }
        return newArray;
    }
}

string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer scince" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };

PrintArr(a);
PrintArr(b);
PrintArr(c);

PrintArr(ModifyArray(a));
PrintArr(ModifyArray(b));
PrintArr(ModifyArray(c));
