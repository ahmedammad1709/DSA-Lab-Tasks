internal class Stack
 {
     static readonly int MAX = 25;
     int top;
     char[] stack = new char[MAX];
     public Stack()
     {
         top = -1;
     }
     public void push(char data)
     {
         if(top >= MAX)
         {
             Console.WriteLine("Stack Overflow");
             return;
         }
         else
         {
             stack[++top] = data;
             Console.WriteLine("Data Added : " + data);
         }
     }
     public void pop()
     {
         if(top < 0)
         {
             Console.WriteLine("Stack UnderFlow");
         }
         else
         {
             Console.WriteLine("\nItem Popped : " + stack[top]);
             int value = stack[top--];
         }
     }
     public void print()
     {
         if(top < 0)
         {
             Console.WriteLine("Stack UnderFlow");
             return;
         }
         Console.WriteLine("\nPrinting Stack :");

         for(int i = top; i >= 0; i--)
         {
             Console.WriteLine(stack[i] + " ");
         }
     }
}
internal class Program
 {
     static void Main(string[] args)
     {
         Stack stack = new Stack();
         String name = "Software";
         char[] chars = name.ToCharArray();

         foreach(char c in chars)
         {
             stack.push(c);
         }

         stack.print();  
         Console.ReadLine();
     }
 }
