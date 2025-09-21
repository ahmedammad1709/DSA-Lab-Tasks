internal class Program
 {
     static int moveCount = 0; 
     static void Main(string[] args)
     {
         int n = 4; // Number of disks
         towerOfHanoi(n, 'A', 'C', 'B');

         Console.WriteLine("\nTotal number of moves: " + moveCount);
         Console.ReadLine();
     }
     static void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
     {
         if (n == 1)
         {
             moveCount++;
             Console.WriteLine("Move disk 1 from rod " +
             from_rod + " to rod " + to_rod);
             return;
         }
         towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
         moveCount++;
         Console.WriteLine("Move disk " + n + " from rod " +
         from_rod + " to rod " + to_rod);
         towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
     }
 }
