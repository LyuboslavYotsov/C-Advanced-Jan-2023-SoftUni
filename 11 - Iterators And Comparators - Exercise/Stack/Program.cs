using Stack;
using System;


CustomStack<string> myStack = new CustomStack<string>();

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] commArgs = input
        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

    string command = commArgs[0];

    if (command == "Push")
    {
        string[] itemsToPush = commArgs[1..];
        foreach (var item in itemsToPush)
        {
            myStack.Push(item);
        }
    }
    else if (command == "Pop")
    {
        try
        {
            myStack.Pop();
        }
        catch (Exception exception)
        {

            Console.WriteLine(exception.Message);
        }
    }
}

foreach (var item in myStack)
{
    Console.WriteLine(item);
}
foreach (var item in myStack)
{
    Console.WriteLine(item);
}