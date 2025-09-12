internal class Program
 {
     static void Main(string[] args)
     {
         Console.WriteLine("---Find HCF---");
         Console.Write("Enter the first Number : ");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter the second Number : ");
         int num2 = Convert.ToInt32(Console.ReadLine());
         if(num1 > num2)
         {
             Console.WriteLine("\nHCF : " + hcf(num1, num2));
         }
         else
         {
             Console.WriteLine("\nHCF : " + hcf(num2, num1));
         }
         Console.ReadLine();
     }

     static int hcf(int num1, int num2)
     {
         if(num1%num2 == 0)
         {
             return num2;
         }
         return hcf(num2, num1%num2);
     }
 }
