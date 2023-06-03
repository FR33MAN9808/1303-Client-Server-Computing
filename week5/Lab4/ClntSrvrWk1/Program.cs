using ClntSrvrWk1.Lessons.Week4.ObjectType;
using System.ComponentModel.DataAnnotations;

namespace ClntSrvrWk1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var stackTest = new TestStack();
            stackTest.Test1();

            var enumTest = new TestEnum();
            enumTest.Test1();
        }
    }
}
