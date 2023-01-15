int mealQuantity = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> ordersQueue = new Queue<int>(orders);
Console.WriteLine(ordersQueue.Max());

foreach (var order in orders)
{
    int orderQuantity = ordersQueue.Peek();
    if (mealQuantity >= orderQuantity)
    {
        ordersQueue.Dequeue();
        mealQuantity -= orderQuantity;
    }
}

if (ordersQueue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ",ordersQueue)}");
}