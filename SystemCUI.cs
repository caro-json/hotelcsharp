namespace hotelcsharp
{
    class Menu
    {
        public void ShowGuestMenu()
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

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAvailableRooms();
                        break;
                    case "2":
                        BookRoom bookRoom = new BookRoom();
                        bookRoom.MakeBooking();
                        break;
                    case "3":
                        ManageBooking managebooking = new ManageBooking();
                        managebooking.CancelBooking();
                        break;
                    case "4":
                        Console.WriteLine("\nHoppas vi syns snart!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }

        public void ShowAvailableRooms()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tillgängliga rum:");
            Console.ResetColor();
            
            RoomList.ListAvailableRooms();
            Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
            Console.ReadKey();
        }
    }
}
