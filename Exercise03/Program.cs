/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string LineNum(int numN, int p)
{
    string outline = "1";
    for (int i = 2; i <= numN; i++)
    {
        outline = outline + "\t" + Math.Pow(i, p);
    }
    return outline;
}

int numN = ReadData("Введите число N: ");
string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 3);

PrintData("", lineTop);
PrintData("", lineDown);