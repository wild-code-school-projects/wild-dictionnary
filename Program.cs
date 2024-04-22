namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, string>();
            words.Add("a", "foo");
            words.Add("b", "bar");
            words.Add("c", "baz");

            Console.WriteLine("Before : ");

            foreach (var word in words)
            {
                Console.WriteLine($"\t{word}");
            }

            words.Remove("c");

            Console.WriteLine();

            Console.WriteLine("After: ");

            foreach (var word in words)
                Console.WriteLine($"\t{word}");
        }
    }
}
