

namespace ThreeupleNS
{
    public class Threeuple<T, U, S>
    {
        public T item1 { get; set; }

        public U item2 { get; set; }

        public S item3 { get; set; }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
