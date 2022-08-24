int start = 1;
int stop = 65537;
int number = new Random().Next(start, stop);

if(number < 100)
{
    Console.Write(number + " -> третьей цифры нет");
}
if(number >= 100 && number < 1000)
{
    int digit = number % 10;
    Console.Write(number + " -> " + digit);
}
if(number >= 1000 && number < 10000)
{
    int digit = number / 10 % 10;
    Console.Write(number + " -> " + digit);
}
if(number >= 10000 && number < stop)
{
    int digit = number / 100 % 10;
    Console.Write(number + " -> " + digit);
}