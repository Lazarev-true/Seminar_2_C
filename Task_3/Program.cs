Console.WriteLine("Введите цифру дня недели");
string weeknumber = Console.ReadLine();
int number = Convert.ToInt32(weeknumber);

if(number <= 7 && number > 0)
{
    if(number > 5)
    {
        Console.Write(number + " -> да");
    }

    else
    {
        Console.Write(number + " -> нет");
    }
}

else
{
    Console.Write(number + " -> День недели от 1 до 7");
}
