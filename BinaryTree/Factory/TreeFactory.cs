namespace BinaryTree.Factory
{
    static class TreeFactory
    {
        private static Tree _instance;

        public static Tree AddNode(Node node)
        {
            GetSingleton();

            _instance.InsertNode(node);

            return _instance;
        }

        public static Tree GetSingleton()
        {
            if (_instance is null)
                _instance = new Tree();

            return _instance;
        }
    }
}
