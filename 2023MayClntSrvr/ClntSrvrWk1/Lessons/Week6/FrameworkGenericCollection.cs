using ClntSrvrWk1.Lessons.Week3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public class FrameworkGenericCollection
    {
        private List<MallardDuck> mallardDucks;
        private Dictionary<int, MallardDuck> indexedDucks;
        private int size;
        
        /// <summary>
        /// Dictionary is a key / value pair collection
        /// collection of objects: { duck1, duck2, duck25 }
        /// [key / value] object that is indexed on the key
        /// you can retrieve the value using the key 
        /// and it is a O(1) operation
        /// </summary>
        public MallardDuck TestFind_Dictionary(int id)
        {
            return indexedDucks[id];
        }

        public void TestAdd_Dictionary(MallardDuck duck) 
        { 
            this.indexedDucks.Add(duck.GetId(), duck);
        }

        /// <summary>
        /// O(n) where n is the size of the list (number of items in the list)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MallardDuck TestFind_List(int id)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.mallardDucks.ElementAt(i).GetId() == id)
                {
                    Console.WriteLine($"Found {id}: {i}");
                    return this.mallardDucks.ElementAt(i);
                }
            }

            return null;
        }
    }
}
