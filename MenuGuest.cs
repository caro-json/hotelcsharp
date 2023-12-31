namespace hotelcsharp
{
    public static class Menu
    {
        public static void ShowGuestMenu()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("=========================");
                Console.WriteLine("[1] Visa tillgängliga rum.");
                Console.WriteLine("[2] Boka ett rum.");
                Console.WriteLine("[3] Avboka en bokning.");
                Console.WriteLine("[4] Klar med bokning.");
                Console.WriteLine("Ange ditt val: ");

                string choice = Console.ReadLine()+"";

                switch (choice)
                {
                    case "1":
                        ShowAvailableRooms();
                        break;
                    case "2":
                        BookRoom.MakeBooking();
                        break;
                    case "3":
                        ManageBooking.CancelBooking();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("===========================");
                        Console.WriteLine("Hoppas vi syns snart igen!");
                        Console.WriteLine("===========================");
                        isRunning = false;
                        Console.ResetColor();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public static void ShowAvailableRooms()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tillgängliga rum:");
            Console.ResetColor();
            
            RoomList.ListAvailableRooms();
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
            Console.ReadKey();
            Console.Clear();     
        }
    }
}
