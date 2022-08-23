int start = 1;
int stop = 1000001;
int number = new Random().Next(start, stop);

int a = number % 7;
int b = number % 23;

if(a == 0 && b ==0)
{
    Console.Write(number + " кратно 7 и 23");
}

else
{
    Console.Write(number + " не кратно 7 и 23");
}
