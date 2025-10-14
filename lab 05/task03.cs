internal class Stack
{
    public Node top;
    private int count;
      
   public Stack()
    {
        top = null;
        count = 0;
    }
    public void push(int data)
    {
        Node new_node = new Node(data);
           
        new_node.next = top;
        top = new_node;
        count++;
        Console.WriteLine("Pushed : " + data);
    }
    public void pop()
    {
        if (isEmpty())
        {
            Console.WriteLine("Stack is Empty !");
            return;
        }

        int value = top.data;
        top = top.next;
        count--;
        Console.WriteLine("Popped : " + value);
    }
    public void peek()
    {
        if(isEmpty())
        {
            Console.WriteLine("Stack UnderFlow");
            return;
        }
        Console.WriteLine("Stack Top : " + top.data);
    }
    public bool isEmpty()
    {
        return top == null;
    }
    public void printStack()
    {
        Node current = top;
        if (isEmpty())
        {
            Console.WriteLine("Stack UnderFlow");
            return;
        }
        Console.WriteLine("\nPrinting Stack :");
        while(current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
    public int totalItems()
    {
        return count;
    }
}
