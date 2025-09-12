internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number you want to print odd series : ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nSquare of " + num + " is " + oddSeries(1, 1, num));

        Console.ReadLine();
    }

    static int oddSeries(int series, int count, int input)
    {   
        if(count > input)
        {
            return 0;
        }
        Console.Write(series + " , ");
        count++;
        return series + oddSeries(series + 2,count, input);
            
    }
}
