using System;

// Задание №10 практики 2017г. 
// Задание 10.4, стр. 10: 4. Написать метод уничтожения дерева.
// Задания по учебной практике

namespace Practice_2017_10
{
    class Program
    {
        public static Random Rnd=new Random();

        static BinTree GenerateTree(int size)
        {                         // Размер дерева от текущего узла
            if (size == 0) return null;                          // Если размер равен 0, то проход по этому узлу закончен

            int data = Rnd.Next(-100, 101),                      // Случайное значение в поле
                leftNodesAmount = Rnd.Next(size);                // Количество узлов левой ветки

            BinTree tree = new BinTree(data);
            tree.Left = GenerateTree(leftNodesAmount);           // Переходим к левой ветке
            tree.Right = GenerateTree(size - leftNodesAmount-1); // Переходим к правой ветке -1, т.к. создали текущий узел
            return tree;
        } // Генерирует дерево с заданным кол-вом узлов

        static void Main(string[] args)
        {
            BinTree tree= GenerateTree(10000);
            tree = null;
        }
    }
}
