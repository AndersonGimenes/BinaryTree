using System;

namespace BinaryTree.Extensions
{
    static class NodeExtensions
    {
        public static void ShowOrderByAsc(this Node node)
        {
            if (node != null)
            {
                ShowOrderByAsc(node.LeftNode);

                Console.WriteLine(node.Data);

                ShowOrderByAsc(node.RightNode);
            }
        }
    }
}
