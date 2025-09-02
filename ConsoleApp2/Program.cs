//DRY = dont repeat yourself. Försök att inte återupprepa kod

//Om man sätter listan inuti do..while-loopen så kommer en ny lista skapas varje gång. Listan förbli tom och de värden man skriver clearas.
List<string> name_list = [];
do
{
    Console.WriteLine("=== MENU OPTIONS ===");
    Console.WriteLine("1. View list");
    Console.WriteLine("2. Add to list");
    Console.WriteLine("0. Exit application");
    //eller \n = Console.Write("\nChoose one option: ");
    Console.WriteLine("");
    Console.Write("Choose one option: ");
    string option = Console.ReadLine()!;


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
    switch (option)
    {
        case "1":
            Console.WriteLine("View list");
            foreach(string name in name_list)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("Add to list");
            Console.Write("Enter name: ");
            string input_name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input_name)) 
            {
                name_list.Add(input_name);
            } 

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

//bin --> debug för att hitta och öppna programmet från dess fil lokalt på datorn