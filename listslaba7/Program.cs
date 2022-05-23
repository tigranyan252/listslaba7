namespace Listslaba7
// Лаба 7 
// вариант 17 средний уровень
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> symb = new() { 1, 4, 31, 41, 20, 25, 15, 10, 16 };
            Console.Write(symb + "\t");

            Console.WriteLine();

            for (int i = 0; i < symb.Count; i++)
                if (10 < symb[i] && symb[i] < 20) symb.Remove(symb[i - 1]);

            for (int i = 0; i < symb.Count; i++)
                Console.Write(symb[i] + "\t");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}