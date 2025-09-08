static void Main(string[] args){
            List<String> inventory = new List<String>();
            Boolean exit = false;

            while (!exit)
            {
                Console.Write("\nPress 1 to add Item\nPress 2 for Remove Item\nPress 3 to search Item" +
                    "\nPress 4 to display Inventory\nPress 5 to Exit : ");
                int input =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        Console.Write("Enter the Item to Add : ");
                        String item = Console.ReadLine();
                        inventory.Add(item.ToLower());
                        break;

                    case 2:
                        Console.Write("Enter the Item to Remove : ");
                        String remove = Console.ReadLine();
                        if (inventory.Contains(remove.ToLower())) {
                            inventory.Remove(remove.ToLower());
                            Console.WriteLine(remove + " is removed successfully!");
                        }
                        else
                        {
                            Console.Write("Item not found in inventory !");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the Item to Search in Inventory : "
                            
                            );
                        String search = Console.ReadLine();
                        if (inventory.Contains(search.ToLower())){
                            Console.Write(search + " is present in the Inventory !");
                        }
                        else
                        {
                            Console.WriteLine("The Item is not present in the Inventory !");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nPrinting Inventory Items :");
                        if(inventory == null)
                        {
                            Console.WriteLine("No Items added in the Inventory !");
                        }
                        foreach(String c in inventory)
                        {
                            Console.Write(c + " , ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Good Bye !");
                        exit = true;
                        break;
                }
            }
            Console.ReadLine();
  
        }
