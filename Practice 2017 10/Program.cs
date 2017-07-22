using System;

// Задание №10 практики 2017г. 
// Задание 10.4, стр. 10: 4. Написать метод уничтожения дерева.
// Задания по учебной практике

namespace Practice_2017_10
{
    class Program
    {
        public static Random Rnd=new Random();

        public static int ReadIntegerWithBounds(int lowerBound, int upperBound, string error = "Ошибка, введите значение в допустимых границах!")
        {
            do
            {
                bool ok;       // маркер выхода из цикла
                int input = 0; // переменная для хранения полученного числа

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    ok = input >= lowerBound & input <= upperBound;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    ok = false;
                }
                if (ok) return input;
                Console.Clear();
                Console.WriteLine(error);
            } while (true);
        } // Считывание целых чисел по заданным границам (включая их), error - стандартное сообщение для ошибки


        static BinTree GenerateTree(int size)
        {                         // Размер дерева от текущего узла
            if (size == 0) return null;                          // Если размер равен 0, то проход по этому узлу закончен

            int data = Rnd.Next(-100, 101),                      // Случайное значение в поле
                leftNodesAmount = Rnd.Next(size);                // Количество узлов левой ветки

            BinTree tree = new BinTree(data);
            tree.Left = GenerateTree(leftNodesAmount);           // Переходим к левой ветке
            tree.Right = GenerateTree(size - leftNodesAmount-1); // Переходим к правой ветке -1, т.к. создали текущий узел
            return tree;
        }                                                                                                     // Генерирует дерево с заданным кол-вом узлов

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в дереве (от 1 до 10000 (включая границы))");
            BinTree tree= GenerateTree(ReadIntegerWithBounds(1, 10000, "Ошибка, введите значение от 1 до 10000 (включая границы)"));
            Console.WriteLine("Дерево создано и по окончанию" +
                              " программы будет удалено");
            tree = null; // Ставим в очередь на уничтожение
            Console.ReadKey();
        }                                                                                                           // Создание и удаления дерева
    }
}
