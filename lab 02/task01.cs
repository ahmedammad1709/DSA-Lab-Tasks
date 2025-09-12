internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number you want to print series : ");
        int num = Convert.ToInt32(Console.ReadLine());
        printSeries(2, num);

        Console.ReadLine();
    }

    static void printSeries(int start, int num)
    {
        if(start > num)
        {
            return;
        }
        Console.Write(start + ", ");

        printSeries(start*2, num);
    }
}
