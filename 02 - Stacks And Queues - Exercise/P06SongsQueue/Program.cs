using System;
using System.Collections.Generic;
using System.Linq;


string[] songs = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
Queue<string> songsQueue = new Queue<string>(songs);

while (songsQueue.Any())
{
    string[] commArgs = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commArgs[0];

    if (command == "Play")
    {
        songsQueue.Dequeue();
    }
    else if (command == "Add")
    {
        string songName = string.Join(" ", commArgs.Skip(1));
        if (!songsQueue.Contains(songName))
        {
            songsQueue.Enqueue(songName);
        }
        else
        {
            Console.WriteLine($"{songName} is already contained!");
        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ",songsQueue));
    }
}
Console.WriteLine("No more songs!");