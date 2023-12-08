using System;
using PersonalNotebook;

class NotebookApp
{
    //constructor practice + "Notebook" class is temporarily undefined
    //Make a new class file that handles Notebook and its relevant functionality

    private Notebook notebook;

    public NotebookApp()
    {
        notebook = new Notebook();
    }

    //----------------------------------------------------------------------------
    public static void Run()
    {
        //cluttered, extract
        while (true)
        {
            MenuOptions();
            MenuChoiceRun();
        }
    }

    public static void MenuChoiceRun()
    {
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                ViewDay();
                break;

            case "2":
                AddNote();
                break;

            case "3":
                ExitApp();
                break;

            default:
                Console.WriteLine("This is an invalid option, please choose again.");
                break;
        }
    }

    public static void MenuOptions()
    {
        Console.WriteLine("Welcome to the menu.");
        Console.WriteLine("1. View a day");
        Console.WriteLine("2. Add note to a day");
        Console.WriteLine("3. Exit app");

        Console.WriteLine("Please pick an option (1-3: ");
    }

    //--------------------------------------------------------------------------------------------------------------------------------

    public static void ViewDay()
    {
        Console.WriteLine("ViewDay PLACEHOLDER");
        //View day functionality
    }

    public static void AddNote()
    {
        Console.WriteLine("AddNote() PLACEHOLDER");
        //Add note functionality (for a specific day)
    }
    public static void ExitApp()
    {
        Console.WriteLine("Exiting notebook, have a nice day! PLACEHOLDER");
        //How the f do you exit?????????
    }

}
