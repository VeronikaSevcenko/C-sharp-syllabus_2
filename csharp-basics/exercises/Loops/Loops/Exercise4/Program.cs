namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < vowels.Length; i++)
            {
                System.Console.WriteLine(vowels[i]);
                System.Console.WriteLine();
            }

            foreach (var element in vowels)
            {
                System.Console.WriteLine($"{element}");
                System.Console.WriteLine();
            }
        }
    }
}
