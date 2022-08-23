int start = 1;
int stop = 65537;
int number = new Random().Next(start, stop);

Console.Write(number + " -> ");

if(number < 100)
{
    Console.Write("третьей цифры нет");
}

string strnumber = Convert.ToString(number);

Console.Write(strnumber[2]);
