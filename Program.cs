List<string> bandList = new List<string>();

void PrintLogo()
{
  Console.WriteLine( @"
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
    case 1: RegisterBand();
      break;
    case 2: ViewAllBands();
      break;
    case 3: RateBand();
      break;
    case 4: ShowAverage();
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
  Console.WriteLine("Add a new band!");
  Console.WriteLine("Please enter the name of the band: ");
  string bandName = Console.ReadLine()!;
  bandList.Add(bandName);
  Console.WriteLine($"You registered the band {bandName}!");
  Thread.Sleep(2000);
  Console.Clear();
  PrintMenuOptions();
}

void ViewAllBands()
{
  Console.WriteLine("In this version, there are no bands registered yet.");
  Thread.Sleep(2000);
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

PrintMenuOptions();