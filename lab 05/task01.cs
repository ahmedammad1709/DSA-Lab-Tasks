internal class Stack
{
    static readonly int MAX = 10;
    int top;
    int[] stack = new int[MAX];

    public Stack()
    {
        top = -1;
    }

    public void isEmpty()
    {
        if(top < 0)
        {
            Console.WriteLine("\nStack is Empty");
        }
        else
        {
            Console.WriteLine("\nStack is not Empty");
        }
    }

    public void isFull()
    {
        if(top >= MAX)
        {
            Console.WriteLine("\nStack Overflow");
        }
        else
        {
            Console.WriteLine("\nStack is not full");
        }
    }

    public void push(int data)
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

    public void peek()
    {
        if(top < 0)
        {
            Console.WriteLine("Stack UnderFlow");
        }
        else
        {
            Console.WriteLine("\nThe top of the stack is : " + stack[top]);
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

    public void count()
    {
        Console.WriteLine("\nTotal Items in stack : " + (top + 1));
    }
  internal class Program
  {
      static void Main(string[] args)
      {
         Stack stack = new Stack();

          stack.push(10);
          stack.push(20);
          stack.push(30);
          stack.isFull();
          stack.print();

          stack.pop();
          stack.peek();
          stack.print();
          stack.isEmpty();
          stack.count();
            

          Console.ReadLine();
      }
  }
