int[] keyNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int elementsCount = keyNumbers[0];
int dequeueCount = keyNumbers[1];
int target = keyNumbers[2];

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>();
bool targetFound = false;
for (int i = 0; i < elementsCount; i++)
{
    queue.Enqueue(numbers[i]);
}

for (int i = 0; i < dequeueCount; i++)
{
    queue.Dequeue();
}
if (queue.Contains(target))
{
    targetFound = true;
}
if (queue.Count > 0)
{
    if (targetFound)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}
else
{
    Console.WriteLine(0);
}

