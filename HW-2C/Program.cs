int choice;

do {
    Console.WriteLine("\n**************");
    Console.WriteLine("1 - New Game");
    Console.WriteLine("2 - Load Game");
    Console.WriteLine("3 - Options");
    Console.WriteLine("4 - Quit");
    Console.WriteLine("**************\n");

    if (!int.TryParse(Console.ReadLine(), out choice)) choice = -1;
    Console.WriteLine($"You selected {choice}.");

    switch (choice) {
        case 1:
        Console.WriteLine("Starting New Game...");
        break;

        case 2:
        Console.WriteLine("Loading Current File...");
        break;

        case 3:
        Console.WriteLine("Options Menu");
        break;

        case 4:
        Console.WriteLine("Terminating Program...");
        break;

        default:
        Console.WriteLine("Invalid Entry. Try re-entering?");
        break;
    }
    
} while (choice != 4);