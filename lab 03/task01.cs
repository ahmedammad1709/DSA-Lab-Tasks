internal class Program
{
    static void Main(string[] args)
    {
        LinkedList single = new LinkedList();

        single.head = new Node(11);
        Node second = new Node(23);
        Node third = new Node(34);
        Node forth = new Node(40);
        Node fifth = new Node(50);

        single.head.next = second;
        second.next = third;
        third.next = forth;
        forth.next = fifth;

        single.printList();
        single.deleteNode(forth);
        Console.WriteLine("\n\nNode del successfully");
        single.printList();
        single.insertNode(third, 24);
        Console.WriteLine("\n\nNew Node added");
        single.printList();
        single.addHead(2);
        Console.WriteLine("\n\nNew head added");
        single.printList();
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
internal class LinkedList
 {
     public Node head;
     public void printList()
     {
         Node n = head;
         while (n != null)
         {
             Console.Write(n.data + " ");
             n = n.next;
         }
     }
     public void deleteNode(Node node)
     {
         Node n = head;
         while(n != null)
         {
             if(n.next == node)
             {
                 n.next = node.next;
             }
             n = n.next;
         }
     }
     public void insertNode(Node pre_node, int data)
     {
         if (pre_node == null)
         {
             Console.WriteLine("The given previous node cannot be null");
             return;
         }
         Node new_Node = new Node(data);
         new_Node.next = pre_node.next;
         pre_node.next = new_Node;
     }
     public void addHead(int data)
     {
         Node newHead = new Node(data);
         newHead.next = head;
         head = newHead;
     }
 }
