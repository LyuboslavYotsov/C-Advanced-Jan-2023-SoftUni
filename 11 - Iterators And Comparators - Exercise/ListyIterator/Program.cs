using System;
using System.Linq;
using ListyIteratorNS;
ListyIterator<string> listy = new ListyIterator<string>();
string input = string.Empty;
while ((input = Console.ReadLine()) != "END")
{
    string[] commandArgs = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandArgs[0];
    if (command == "Create")
    {
        listy = new ListyIterator<string>(commandArgs[1..]);
    }
    if (command == "Move")
    {
        Console.WriteLine(listy.Move());
    }
    else if (command == "Print")
    {
        try
        {
            listy.Print();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
    else if (command == "HasNext")
    {
        Console.WriteLine(listy.HasNext());
    }
    else if (command == "PrintAll")
    {
        try
        {
            listy.PrintAll();
        }
        catch (Exception exceotion)
        {
            Console.WriteLine(exceotion.Message);
        }
    }
}