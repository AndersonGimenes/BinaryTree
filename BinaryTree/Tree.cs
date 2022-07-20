namespace BinaryTree
{
    class Tree
    {
        public Node Root { get; set; }

        public void InsertNode(Node node)
        {
            if (Root is null)
            {
                Root = node;
                return;
            }

            Root.AddNode(node);
        }
    }
}
