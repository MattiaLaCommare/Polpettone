namespace Polpettone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Scrivi un numero da 1 a 7");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("giorno lavorativo");
                    break;
                case 6:
                    Console.WriteLine("sabato");
                    break;
                case 7:
                    Console.WriteLine("giorno feriale");
                    break;
                default:
                    Console.WriteLine("non è un giorno");
                    break;
            }   
        }
    }
}