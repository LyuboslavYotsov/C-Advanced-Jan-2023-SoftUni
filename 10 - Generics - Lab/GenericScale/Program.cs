using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> scale = new(3,3);
            Console.WriteLine(scale.AreEqual());

            EqualityScale<string> scale2 = new("2", "2");

            Console.WriteLine(scale2.AreEqual());
        }
    }
}