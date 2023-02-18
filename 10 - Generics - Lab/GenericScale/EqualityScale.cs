

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public T Right
        {
            get { return right; }
            set { right = value; }
        }


        public T Left
        {
            get { return left; }
            set { left = value; }
        }


        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public bool AreEqual()
        {
            if (this.left.Equals(this.right))
            {
                return true;
            }
            return false;
        }
    }
}
