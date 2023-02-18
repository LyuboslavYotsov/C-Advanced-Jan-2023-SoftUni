

namespace ToupleNS
{
    public class Touple<T,U>
    {
        public T Item1 { get; set; }

        public U Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
