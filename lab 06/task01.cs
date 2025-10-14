internal class Queue
{

    int front;
    int rear;
    int[] que = new int[4];
    public Queue()
    {
        Console.WriteLine("---------SINGLE QUEUE-----------");
        front = -1;
        rear = -1;
    }

    public Boolean isEmpty()
    {
        if (front == -1 && rear == -1)
        {
            return true;
        }
        return false;
    }
    public Boolean isFull()
    {
        if (rear == que.Length - 1)
        {
            return true;
        }
        return false;
    }
    public void enqueue(int data)
    {
        if (isFull())
        {
            return;
        }
        else if (isEmpty())
        {
            front = 0;
            rear = 0;
            que[rear] = data;
        }
        else
        {
            rear++;
            que[rear] = data;
        }
    }
    public void dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue UnderFlow");
        }
        else if (front == rear)
        {
            Console.WriteLine("\nDeQueued : " + que[front]);
            front = rear = -1;
        }       
 else
        {
            Console.WriteLine("\nDeQueued : " + que[front]);
            front++;
        }
    }

    public void printQueue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is Empty, Nothing to print");
            return;
        }
        Console.WriteLine("\nPrinting Queue");

        for (int i = front; i <= rear; i++)
        {
            Console.Write(que[i] + " ");
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
     queue.enqueue(40);
     queue.printQueue();
     queue.dequeue();
     queue.printQueue();
     queue.enqueue(2222);
     queue.printQueue();
     queue.dequeue();
     queue.printQueue();
     queue.dequeue();
     queue.printQueue();
     queue.dequeue();
     queue.printQueue();

     Console.ReadLine();
}
