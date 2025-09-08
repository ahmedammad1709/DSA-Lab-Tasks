static void Main(string[] args)
{
    int[] a = new int[10];
    int total = 0;
    int avg = 0;

    Random random = new Random();

    for(int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(1, 51);
    }

    Console.WriteLine("--- Printing Array ---");
    for (int j =0; j < a.Length; j++)
    {
        Console.Write(a[j] + ", ");
        total += a[j];
    }

    Console.WriteLine("\n");
            
    //Even and odd

    for(int i = 0;i < a.Length; i++)
    {
        if(a[i]%2 == 0)
        {   
            Console.WriteLine("Even Number found : " + a[i]);
        }
        else
        {
            Console.WriteLine("Odd Number found : " + a[i]);
        }
    }

    //Sum 25

    Console.WriteLine("\nPairs having sum 25 :");

    Boolean found = false;
    for(int i = 0; i < a.Length; i++)
    {
        for(int j = i+1; j < a.Length; j++)
        {
            if (a[i] + a[j] == 25)
            {
                Console.Write("{ " +  a[i] + ", " + a[j] + " }" + " , ");
                found = true;
            }
        }
    }
    if (!found)
    {
        Console.WriteLine("No such pairs found having sum 25 !");
    }

    //Calculating Average
    avg = total / 10;
    Console.WriteLine("\n\nAverage : " + avg);

    Console.ReadLine();
}	

