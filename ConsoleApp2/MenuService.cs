//semikolon på namespace tar bort curlybrackets
namespace ConsoleApp2;

internal static class MenuService
{   //underline = det här är ingen variabel som ligger i metoden. Den ligger i klassen (fält).
    private static List<string> _name_list = [];
    private static string _option = "";
    public static void MainMenu()
    {
        //Om man sätter listan inuti do..while-loopen så kommer en ny lista skapas varje gång. Listan förbli tom och de värden man skriver clearas.

        do
        {
            DisplayMenuOptions();

            /*if-satser inte bra prestandamässigt i den här situationen. Testar alla alternativ tills den hittar en lösning. Inte effektivt.
            if(option == "1")
            {

            }
            else if(option == "2")
            {

            }
            else if(option == "0")
            {

            } */

            Console.Clear();

            //Raka jämförelser, alltså = jämförelser. Kan ej göra mellan 1 och 3 gör såhär, större än 50 gör såhär. Om ex. storleksjämförelser = if-sats
            //Kommer att gå så snabbt att visa innan Menu är tillbaka. För att hinna se valet man gjort = Console.Readkey();
            switch (_option)
            {
                case "1":
                    DisplayListView();
                    break;

                case "2":
                    DisplayAddNameToList();
                    break;

                case "0":
                    //Tvingar en avstängning av programmet. Alltså kan man använda while (true) som condition i, det blir ingen evighetsloop
                    Environment.Exit(0);
                    break;

                default:
                    break;

            }
            Console.Clear();
        }
        while (true);
    }

    public static void DisplayMenuOptions()
    {
        Console.WriteLine("=== MENU OPTIONS ===");
        Console.WriteLine("1. View list");
        Console.WriteLine("2. Add to list");
        Console.WriteLine("0. Exit application");
        //eller \n = Console.Write("\nChoose one option: ");
        Console.WriteLine("");
        Console.Write("Choose one option: ");
        _option = Console.ReadLine()!;
    }

    public static void DisplayAddNameToList()
    {
        Console.WriteLine("Add to list");
        Console.Write("Enter name: ");
        string input_name = Console.ReadLine()!;

        if (!string.IsNullOrWhiteSpace(input_name))
        {
            _name_list.Add(input_name);
        }
    }

    public static void DisplayListView()
    {
        Console.WriteLine("=== Name List ===");
        foreach (string name in _name_list)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }

}
