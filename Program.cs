List<string> bandList = new List<string> { "Lambda & The Expressions", "C-Sharp Minors", "Garbage Collector", "LINQin Park", "The Async/Awaiters", "Property Getters", "The Extension Methods" };

void PrintLogo()
{
  Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void PrintMenuOptions()
{
  PrintLogo();
  Console.WriteLine("\nPlease select an option:");
  Console.WriteLine("1. Add a new band");
  Console.WriteLine("2. View all bands");
  Console.WriteLine("3. Rate a band");
  Console.WriteLine("4. Show the average of a band");
  Console.WriteLine("5. Exit");

  Console.Write("\nType the number of the option you want to select: ");
  string choiceOption = Console.ReadLine()!;
  int choiceOptionInt = int.Parse(choiceOption);

  switch (choiceOptionInt)
  {
    case 1:
      RegisterBand();
      break;
    case 2:
      ViewAllBands();
      break;
    case 3:
      RateBand();
      break;
    case 4:
      ShowAverage();
      break;
    case 5:
      Console.WriteLine("Bye!");
      break;
    default:
      Console.WriteLine("Invalid option. Please select a valid option.");
      PrintMenuOptions();
      break;
  }
}

void RegisterBand()
{
  Console.Clear();
  PrintOptionTitle("Register a new band");
  Console.WriteLine("Please enter the name of the band: ");
  string bandName = Console.ReadLine()!;
  bandList.Add(bandName);
  Console.WriteLine($"\nYou registered the band {bandName}!");
  Thread.Sleep(2000);
  Console.Clear();
  PrintMenuOptions();
}

void ViewAllBands()
{
  PrintOptionTitle("All bands registered");
  int i = 1;
  foreach (var band in bandList)
  {
    Console.WriteLine($"{i} - {band}");
    i++;
  }
  Console.WriteLine("\nPress any key to return to the menu.");
  Console.ReadKey();
  Console.Clear();
  PrintMenuOptions();
}

void RateBand()
{
  Console.WriteLine("In this version, you can't rate a band yet.");
  Thread.Sleep(2000);
  Console.Clear();
  PrintMenuOptions();
}

void ShowAverage()
{
  Console.WriteLine("In this version, you can't see the average of a band yet.");
  Thread.Sleep(2000);
  Console.Clear();
  PrintMenuOptions();
}

void PrintOptionTitle(string title)
{
  Console.Clear();
  int amountOfLetters = title.Length;
  string asterisks = string.Empty.PadLeft(amountOfLetters, '*');
  Console.WriteLine(asterisks);
  Console.WriteLine(title);
  Console.WriteLine(asterisks + "\n");
}

PrintMenuOptions();