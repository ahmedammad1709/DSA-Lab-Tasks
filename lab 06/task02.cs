internal class Queue
{
    public Node head;
    public void enqueue(int data)
    {
        Node current = head;
        Node new_node = new Node(data);

        if (head == null)
        {
            head = new_node;
            head.next = null;
            Console.WriteLine("Enqueued : " + data);
            return;
        }
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = new_node;
        new_node.next = null;
        Console.WriteLine("Enqueued : " + data);
    }

    public void dequeue()
    {
        Node current = head;
        if (head == null)
        {
            Console.WriteLine("Noting in Queue");
            return;
        }

        Console.WriteLine("\nDequeued : " + head.data + "\n");
        head = head.next;
            
    }
    public void printQueue()
    {
        Node current = head;
        if (current == null)
        {
            Console.WriteLine("Nothing to print, Queue is empty");
            return;
        }
        Console.WriteLine("Printing Queue");

        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}
static void Main(string[] args)
{
    Queue queue = new Queue();
    queue.enqueue(10);
    queue.enqueue(20);
    queue.enqueue(30);
    Console.WriteLine();
    queue.printQueue();
    queue.dequeue();
    queue.printQueue();
    Console.ReadLine();
}
public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
    }
}
