internal class CircularQueue
{
    int front;
    int rear;
    int[] que = new int[3];
    int n = 3;
    public CircularQueue()
    {
        Console.WriteLine("------CIRCULAR QUEUE-----------");
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
        if ((rear +1)%que.Length == front)
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
            rear = (rear+1) % que.Length;
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
            front = (front+1) % que.Length;
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

        int i = front;

        while (true)
        {
            Console.Write(que[i] + " ");
            if (i == rear) break;

            i = (i+1) % que.Length;
        }
        Console.WriteLine();
    }
