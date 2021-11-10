using System.Collections.Generic;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. 
             * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, 
             * а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; 
             * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, 
             * каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); 
             * в конце прохода стек должен быть пуст.*/

            Stack<char> skStack = new Stack<char>(); // Объявляем Коллекцию стэк
            System.Console.WriteLine("Программа проверки расстановки скобок");
            System.Console.Write("Введите комбинацию скобок для проверки: ");
            string skobStr = System.Console.ReadLine(); // Строка со скобками 
            
            foreach(char c in skobStr) //посимвольная проверка
            {
                if (c == '[') {skStack.Push(']'); }
                if (c == '(') { skStack.Push(')'); }
                if (c == '{') { skStack.Push('}'); }
                if (c == '}'&&c==skStack.Peek()) { skStack.Pop(); }
                if (c == ']' && c == skStack.Peek()) { skStack.Pop(); }
                if (c == ')' && c == skStack.Peek()) { skStack.Pop(); }
            }
            if (skStack.Count==0) //результат
            {
                System.Console.WriteLine("Скобки расставлены корректно!");
            }
            else
            {
                System.Console.WriteLine("Скобки расставлены некорректно!");
            }
            System.Console.ReadKey();

        }
    }
}
