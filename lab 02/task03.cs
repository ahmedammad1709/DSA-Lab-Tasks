internal class Program
 {
     static void Main(string[] args)
     {
         Console.Write("Enter the number you want to see sum : ");
         int num = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Sum of the num is : " + sum(num));

         Console.ReadLine();
     }

     static int sum(int num)
     {  
         if(num == 0) return 0;

         return num%10 + sum(num/10);
     }
 }
