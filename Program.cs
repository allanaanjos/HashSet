

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {

            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n1 ;i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(id);
            }

            Console.Write("How many students for course B? ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n2; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(id);
            }

            Console.Write("How many students for course C? ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n3; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(id);
            }

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
