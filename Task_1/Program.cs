int start = 100;
int stop = 1000;
int number = new Random().Next(start, stop);

int result = (number % 100) / 10;

Console.Write(number + " -> " + result);
