/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string PolyTest(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
    {
        return "Число является палиндромом";
    }
    else
    {
        return "Число не является палиндромом";
    }
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int num = ReadData("Введите пятизначное число: ");

string answer = PolyTest(num);

if (num> 9999 && num <100000)
{
    PrintData(answer,"");;
}
else
{
    PrintData("Число не является пятизначным", "");
}

