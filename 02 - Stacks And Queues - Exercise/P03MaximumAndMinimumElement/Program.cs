int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();


for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    int commandType = input[0];

    if (commandType == 1)
    {
        int number = input[1];
        stack.Push(number);
    }
    else if (commandType == 2)
    {
        stack.Pop();
    }
    else if (commandType == 3)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (commandType == 4)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack.ToArray()));