using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public class TestBTNode
    {
        public void TestBTNode_CreateAdd() 
        {
            var node1 = new BTNode<int>() { Data = 12 };
            var node2 = new BTNode<int>() { Data = 13 };
            var node3 = new BTNode<int>() { Data = 34 };

            node1.Left = node2;
            node1.Right = node3;
        }
    }
}
