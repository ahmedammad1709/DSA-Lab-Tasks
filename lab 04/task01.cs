internal class Program
 {
     static void Main(string[] args)
     {
         DoubleLinkedList list = new DoubleLinkedList();
         list.add(10);
         list.add(20);
         list.add(30);
         list.print();
         list.printReverse();

         list.insertHead(2);
         Console.WriteLine("\n\nInserted new Head :");
         list.print();
         list.printReverse();

         Node temp = list.getode(20);
         list.insertNode(temp, 25);
         Console.WriteLine("\n\n--Insering Node after 20--");
         list.print();
         list.printReverse();
         list.removeNode(30);
         Console.WriteLine("\n\nNode removed ");
         list.print();
         list.printReverse();
         Console.ReadLine();
     }
 }
 public class Node
 {
     public int data;
     public Node next;
     public Node prev;

     public Node(int data)
     {
         this.data = data;
         next = null;
         prev = null;
     }
 }
internal class DoubleLinkedList
 {
     public Node head;
     public void insertHead(int data)
     {
         Node new_node = new Node(data);
         if(head != null)
         {
             new_node.next = head;
             head.prev = new_node;
             head = new_node;
         }
     }
     public Node getode(int data)
     {
         Node current = head;
         while(current != null)
         {
             if(current.data == data)
             {
                 return current;
             }
             current = current.next;
         }
         return current;
     }
     public void add(int data)
     {
         Node current = head;
         Node new_node = new Node(data);

         if(head == null)
         {
             head = new_node;
             return;
         }
         while(current.next != null)
         {
             current = current.next;
         }
         current.next = new_node;
         new_node.prev = current;
     }
     public void insertNode(Node pre_node, int data)
     {
         Node current = head;
         if (head == null) return;
         while(current != null)
         {
             if(current == pre_node)
             {
                 Node new_node = new Node(data);
                 new_node.next = current.next;
                 new_node.prev = current;
                 current.next.prev = new_node;
                 current.next = new_node;
             }
             current = current.next;
         }
     }
     public void removeNode(int data)
     {
         Node current = head;

         if(head.data == data)
         {
             head = head.next;
             head.prev = null;
             return;
         }
         while(current != null)
         {
             if(current.data == data)
             {
                 if(current.next != null)
                 {
                     current.next.prev = current.prev;
                     current.prev.next = current.next;
                 }
                 else
                 {
                     current.prev.next = null;
                 }
             }
             current = current.next;
         }
     }
     public void print()
     {
         Node current = head;
         Console.WriteLine("\nPrinting Linked list :");

         while(current != null)
         {
             Console.Write(current.data + " ");
             current = current.next;
         }
     }
     public void printReverse()
     {
         Node current = head;
         Console.WriteLine("\nPrinting Linked List in Reverse :");
         while(current.next != null)
         {
             current = current.next;
         }
         while(current != null)
         {
             Console.Write(current.data + " ");
             current = current.prev;
         }
     }
}
