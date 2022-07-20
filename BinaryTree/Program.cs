using BinaryTree.Extensions;
using BinaryTree.Factory;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeFactory.AddNode(new Node { Data = 10 });
            TreeFactory.AddNode(new Node { Data = 5 });
            TreeFactory.AddNode(new Node { Data = 13 });
            TreeFactory.AddNode(new Node { Data = 3 });
            TreeFactory.AddNode(new Node { Data = 4 });
            TreeFactory.AddNode(new Node { Data = 8 });
            TreeFactory.AddNode(new Node { Data = 1 });
            TreeFactory.AddNode(new Node { Data = 20 });
            TreeFactory.AddNode(new Node { Data = 12 });
            TreeFactory.AddNode(new Node { Data = 2 });
            TreeFactory.AddNode(new Node { Data = 7 });
            TreeFactory.AddNode(new Node { Data = 6 });

            TreeFactory.GetSingleton().Root.ShowOrderByAsc();
        }
    }
}
