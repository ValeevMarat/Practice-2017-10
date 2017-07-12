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
            Left = null;
            Right = null;
        }
    } // Класс бинарного дерева
}
