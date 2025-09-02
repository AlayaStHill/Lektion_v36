/*FRÅGOR:
Om !, gör det att programmet inte kraschar om variabeln är null eller empty eller bara ignorerar?
string answer = ""; eller string answer;
*/
//-----------------------------------------------------------------------------------------------//


//Det viktigaste, tydliga namn så att man enkelt kan se vad koden handlar om/vad en variabel är för något. Annars dålig programmering.

List<string> name_list = [];

Console.WriteLine("Hej och välkommen.");
//Hamnar på samma rad som texten i metoden

//Vill genomföra loopen minst en gång

string answer;
do
{
    Console.Write("Ange ett namn: ");

    /*Grön squiggly line varnar för att det kan uppstå fel om vi vill göra konverteringar exempelvis om name är 
     null (inget värde alls eller tom ("" = string.Empty) finns ingen text. ! för att ta bort grön line. Man ska alltid åtgärda en grön squiggly line */
    string input_name = Console.ReadLine()!;

    /*Gör att man inte får in tomma värden i listan. Om man bara har ett värde i if-satsen behöver man inte {}.
    Om condition i if-satsen inte uppfylls går den vidare i applikationen.*/
    if (!string.IsNullOrEmpty(input_name))
    {
        name_list.Add(input_name);

    }

    Console.Clear();
    Console.WriteLine("Vill du ange ett nytt namn? y/n: ");
    answer = Console.ReadLine()!;

    /*Om true som condition = evighetsloop, tar RAM-minne. Om RAM blir fullt: stackoverflow eller bluescreen of death om man gör applicationer som ör förbjudna 
     eller orsakar skada i datorn (överhettad - komponenter bränns sönder). Datorn rensar det som finns i RAM-minnet och sedan startar om*/
} while (answer == "y");

//Rensar allt som tidigare finns i konsolen när name_list skrivs ut
Console.Clear();

Console.WriteLine("=== Namnlista ===");

foreach (string name in name_list)
{
    Console.WriteLine(name);
}




// Breakar före det moment man satt en breakpoint på. Den har alltså inte genomfört sekvensen än.


//Låsa applikationen så att den inte automatiskt stänger ned sig. Nu har jag inställningar som gör att det inte stängs ned ändå.
Console.ReadKey();