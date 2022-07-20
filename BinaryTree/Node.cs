namespace BinaryTree
{
    class Node
    {
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public void AddNode(Node node)
        {
            if (node.Data < this.Data)
            {
                if (this.LeftNode is null)
                    this.LeftNode = node;
                else
                    this.LeftNode.AddNode(node);

            }
            else
            {
                if (this.RightNode is null)
                    this.RightNode = node;
                else
                    this.RightNode.AddNode(node);
            }
        }
    }
}
