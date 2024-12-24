class Program
{
    static void Main(String[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("What you wished");
        Console.WriteLine("Open file (1)");
        Console.WriteLine("Create file (2)");
        Console.WriteLine("Quit Program (0)");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
                System.Environment.Exit(0);
                break;
            case 1:
                openFile();
                break;
            case 2:
                editFile();
                break;
            default:
                Menu();
                break;
        }

        static void openFile() { 
            Console.Clear();
        }
        static void editFile() { 
            Console.Clear();
        }

    }
}