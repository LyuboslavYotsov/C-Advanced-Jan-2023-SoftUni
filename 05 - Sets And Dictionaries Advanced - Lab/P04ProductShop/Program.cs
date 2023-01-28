using System;
using System.Collections.Generic;
using System.Linq;

string input;
Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
while ((input = Console.ReadLine()) != "Revision")
{
    string[] tokens = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string shopName = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);

    if (!shops.ContainsKey(shopName))
    {
        shops[shopName] = new Dictionary<string, double>();
    }
    if (!shops[shopName].ContainsKey(product))
    {
        shops[shopName][product] = 0;
    }
    shops[shopName][product] = price;
}

shops = shops
    .OrderBy(x => x.Key)
    .ToDictionary(x => x.Key, x => x.Value);

foreach (var shop in shops)
{
    Console.WriteLine(shop.Key + "->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}

