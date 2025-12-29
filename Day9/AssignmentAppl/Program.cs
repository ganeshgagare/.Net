namespace AssignmentAppl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n MY APPLICATION :");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Create New User");
                Console.WriteLine("3. Update Password");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option 1-4: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userService.Login();
                        break;
                    case "2":
                        userService.CreateUser();
                        break;
                    case "3":
                        userService.UpdatePassword();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}