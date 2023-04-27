namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramIsRunning = true;
            AdressBook ab = StartProgram();

            Console.WriteLine("--------- AdressBook 1.0 ---------");

            while (ProgramIsRunning)
            {
                // Print user options
                PrintUserOptions();
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ab.CreateUser();
                        break;
                    case "2":
                        ab.UpdateUserInformation();
                        break;
                    case "3":
                        ab.RemovePersonFromList();
                        break;
                    case "4":
                        ab.ShowAllPersonsInList();
                        break;
                    case "5":   
                        ab.SearchPersonFromList();
                        break;
                    case "6":
                        ab.export();
                        break;
                    case "7":
                        ab.Group();
                        break;
                    case "8":
                        ab.ShowAllPersonsInFavGroup();  
                        break;
                    case "9":
                            ab.ShowAllPersonsInGenGroup();
                            break;
                      
                    case "x":
                        ProgramIsRunning = false;
                        break;
                }
            }
        }

        private static void PrintUserOptions()
        {
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("#1 Create new user");
            Console.WriteLine("#2 Edit user information");
            Console.WriteLine("#3 Delete existing user");
            Console.WriteLine("#4 Show all users in adressBook");
            Console.WriteLine("#5 Search users in adressBook");
            Console.WriteLine("#6 Export users in adressBook");
            Console.WriteLine("#7 Group Function of users in adressBook");
            Console.WriteLine("#8 Show Fav Group in adressBook");
            Console.WriteLine("#9 Show Gen Group in adressBook");
        }

        private static AdressBook StartProgram()
        {
            AdressBook ab = new AdressBook();


            return ab;
        }
    }
}