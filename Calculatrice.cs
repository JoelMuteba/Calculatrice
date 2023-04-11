namespace Calculatrice
{
    internal class Calculatrice
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int resultatAddition = Addition(a, b);
            Console.WriteLine("L'addition de {0} et {1} donne {2}", a, b, resultatAddition);
        }

        public static int Soustraction(int a, int b)
        {
            return a - b;
        }

        public static int Addition(int a, int b) 
        {
            return a + b;
        }
    }
}