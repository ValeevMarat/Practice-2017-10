namespace Practice_2017_10
{
    class BinTree
    {
        private int Data;     // Информационное поле
        public BinTree Left;  // Ссылка на левую ветку
        public BinTree Right; // Ссылка на правую ветку

        public BinTree(int d)
        {
            Data = d;
            Left = null;
            Right = null;
        }

        ~BinTree()
        {
            Destruct(this);
        }

        private void Destruct(BinTree tree)
        {
            if (tree.Left == null & tree.Right == null)
            {
                tree = null;
                return;
            }
            if (tree.Left != null) Destruct(tree.Left);
            if (tree.Right != null) Destruct(tree.Right);
        } // Обходит дерево в глубину и присваивает листьям null
    } // Класс бинарного дерева
}
