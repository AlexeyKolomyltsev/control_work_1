// See https://aka.ms/new-console-template for more information
void PrintArr(string[] arrayforprint)
{
    int len = arrayforprint.Length;
    for (int i = 0; i < len; i++) Console.Write($"{arrayforprint[i]} ");
    Console.WriteLine();
}
string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer scince" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };
PrintArr(a);
PrintArr(b);
PrintArr(c);

