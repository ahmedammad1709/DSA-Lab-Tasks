internal class Program
{
    static void Main(string[] args)
    {

        String[] words = { "Ammad", "Ahmed", "tomBoy" };

        unsafe
        {
            fixed (String* word = words)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine($"Address of Ram memory of number[{i}] = {(ulong)(word + i)}");
                    Console.WriteLine($"Value at Number[{i}] = {*(word + i)}");
                }
            }
        }

        Console.ReadLine();

    }
}
