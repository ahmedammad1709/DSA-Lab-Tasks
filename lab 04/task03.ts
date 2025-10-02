internal class Program
 {
     static void Main(string[] args)
     {
         DoubleLinkedList list = new DoubleLinkedList();
         list.addSongs("Song A");
         list.addSongs("Song B");
         list.addSongs("Song D");
         list.printForward();
         list.printBackward();
         list.removeSong("song a");
         list.printForward();
         list.printBackward();
         Console.ReadLine();
         list.removeSong("Song Z");
         Console.ReadLine();
     }
 }
 public class Node
 {
     public String name;
     public Node next;
     public Node prev;
     public Node(String name)
     {
         this.name = name.ToLower();
         next = null;
         prev = null;
     }
 }
internal class DoubleLinkedList
 {
     public Node head;

     public void addSongs(String name)
     {
         Node current = head;
         Node new_node = new Node(name);

         if (head == null)
         {
             head = new_node;
             Console.WriteLine("Song Added : " + head.name);
             return;
         }

         while(current.next != null)
         {
             current = current.next;
         }
            
         current.next = new_node;
         new_node.prev = current;
         Console.WriteLine("Song Added : " + name);
     }

     public void removeSong(String name)
     {
         name = name.ToLower();

         if(head == null)
         {
             Console.WriteLine("PlayList is Empty, Nothing to delete");
             return;
         }

         Node current = head;

         if (current.name == name)
         {
             if(current.next == null)
             {
                 head = null;
             }
             else
             {
                 head = current.next;
                 head.prev = null;
             }
             Console.WriteLine("\nSong deleted : " + name);
             return;
         }

         while(current != null)
         {
             if(current.name == name)
             {
                 if( current.next != null)
                 {
                     current.prev.next = current.next;
                     current.next.prev = current.prev;
                 }
                 else
                 {
                     current.prev.next = null;
                 }
                 Console.WriteLine("\nSong deleted : " + name);
                 return;
             }

             current = current.next;
         }
           
         Console.WriteLine("Song not found : " + name);
      
     }

     public void printForward()
     {
         Node current = head;

         if (head == null) return;
         Console.WriteLine("\nPlaying Songs forward : ");
         while (current != null)
         {
             Console.WriteLine("Playing : " + current.name);
             current = current.next;
         }
     }
     public void printBackward()
     {
         Node current = head;
         if (head == null) return;
         Console.WriteLine("\nPlaying Songs backward : ");
         while (current.next != null)
         {
             current = current.next;
         }
         while(current != null)
         {
             Console.WriteLine("Playing : " + current.name);
             current = current.prev;
         }
     }
}
