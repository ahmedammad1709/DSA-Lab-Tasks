internal class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();

        list.add(10);
        list.add(22);
        list.add(30);
        list.add(55);
        list.print();
        Node temp = list.getNode(55);
        list.insertNode(temp, 35);
        list.print();
        list.removeNode(22);
        list.print();
        Console.ReadLine();
    }
}
public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}
internal class CircularLinkedList
 {
     public Node head;

     public void add(int data)
     {
         Node current = head;
         Node new_node = new Node(data);
         if (head == null)
         {
             head = new_node;
             head.next = head;
             return;
         }
         while (current.next != head)
         {
             current = current.next;
         }
         current.next = new_node;
         new_node.next = head;
     }
     public void insertNode(Node pre_node, int data)
     {
         Node current = head;
         if(head == null)
         {
             return;
         }
         Node new_node = new Node(data);
         do
         {
             if(current == pre_node)
             {
                 new_node.next = current.next;
                 current.next = new_node;
                 break;
             }
             current = current.next;
         }
         while(current != null);
     }
     public void removeNode(int data)
     {
         Node current = head;
         do
         {
             if(current.next.data  == data)
             {
                 current.next = current.next.next;
                 return;
             }
             current = current.next;
         }
         while(current != head);
     }
     public Node getNode(int data)
     {
         Node current = head;
         do
         {
             if (current.data == data)
             {
                 return current;
             }
             current = current.next;
         }
         while (current != head);
         return current;
     }
     public void print()
     {
         if (head == null)
         {
             Console.WriteLine("List is empty");
             return;
         }
         Node current = head;
         Console.WriteLine("\n\nPrinting list :");
         do
         {
             Console.Write(current.data + " ");
             current = current.next;
         } while (current != head);
     }
 }
