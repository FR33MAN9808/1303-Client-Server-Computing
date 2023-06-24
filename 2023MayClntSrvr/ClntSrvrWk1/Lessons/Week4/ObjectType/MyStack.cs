namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack
    {
        public MyStack()
        {
        }

        private const int Size = 5;
        private int position;

        private object[] items = new object[Size];

        public void Push(object obj)
        {
            items[position++] = obj;

        }

        public object Pop()
        {
            return items[--position];
        }
    }
}