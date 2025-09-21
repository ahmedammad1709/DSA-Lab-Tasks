internal class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'A', 'B', 'C', 'D' };

        unsafe
        {
            fixed (char* ptr = letters)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    Console.WriteLine($"Address in RAM/Virtual Memory of letters[{i}] = {(ulong)(ptr + i)}");
                    Console.WriteLine($"Value at letters[{i}] = {*(ptr + i)}");
                }
            }
        }
        Console.readLine();
    }
}  
