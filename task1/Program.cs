// Создать из массива строк массив строк с элементами длиной меньше либо равной 3
void PrintArr(string[] arrayforprint) ///метод печати массива
{
    int len = arrayforprint.Length;
    for (int i = 0; i < len; i++) Console.Write($"{arrayforprint[i]} ");
    Console.WriteLine();
}
int CountArray(string[] arrayforcount) /// метод подсчета количества элементов меньше или равное 3
{
    int count = 0;
    foreach (string element in arrayforcount) if (element.Length <= 3) count++;
    return count;
}

string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer scince" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };
PrintArr(a);
PrintArr(b);
PrintArr(c);
Console.WriteLine(CountArray(a));
Console.WriteLine(CountArray(b));
Console.WriteLine(CountArray(c));
