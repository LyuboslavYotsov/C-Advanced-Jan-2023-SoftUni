﻿using CustomDoublyLinkedList;
using System;

DoublyLinkedList<int> list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);

foreach (var item in list)
{
    Console.WriteLine(item);
}

DoublyLinkedList<string> listString = new();

listString.AddLast("some");
listString.AddLast("random");
listString.AddLast("string");

foreach (var item in listString)
{
    Console.WriteLine(item);
}