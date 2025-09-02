//Sökväg till filer

//C:\Projects\CMS25\Csharp\Exercises\Lektion_v36\Program.cs

/*Dubbla \\ läggs till automatiskt. Detta för att \ betyder läs ej nästa tecken, \ är ett escape-tecken (\n radbrytning exempelvis. För att \ ska läsas krävs \\.
 För att komma runt det kan man sätta dit ett @ tecken innan strängen. Det betyder: läs hela den här raden som en endaste textsträng. */

string filePath = "C:\\Projects\\CMS25\\Csharp\\Exercises\\Lektion_v36\\Program.cs";

string filePathTwo = @"C:\Projects\\CMS25\Csharp\\Exercises\Lektion_v36\Program.cs";

string fileName = "Program.cs";

//(strängkonkatenering)
string filePathThree = @"C:\Projects\\CMS25\Csharp\\Exercises\Lektion_v36\" + fileName;

//(stränginterpolering, "placeholder-variant)
string filePathFour = @$"C:\Projects\\CMS25\Csharp\\Exercises\Lektion_v36\{fileName}";

//Använda Path.Combine iställlet för ovan. Slår ihop de två variablerna
string folderPath = @"C:\Projects\\CMS25\Csharp\\Exercises\Lektion_v36";

string filePathFive = Path.Combine(folderPath, fileName);


//Konvertera till en text
int fileNumber = 123;
string fileNameTwo = "File_";

//string newFileName = fileNameTwo + fileNumber.ToString(); .ToString() sker automatiskt i bakgrunden eftersom en sträng blandas med ett nummer och programmet förstår det.
string newFileName = fileNameTwo + fileNumber;
Console.WriteLine(newFileName);

//--------------------------------------------------------------------------------------------------//

//ARRAY:
int[] numbers = { 1, 2, 3 };
string[] names = new string[5];

names[0] = "e";
names[1] = "d";
names[2] = "c";
names[3] = "b";
names[4] = "a";

// Bokstavsordning: abcde i consolen
Array.Sort(names);

foreach(string name in names)
{
    Console.WriteLine(name);
}

//LISTA:
List<string> namesTwo = new List<string>();
List<string> numbersTwo = new();
List<string> namesThree = [];

// .Clear(), .Add(), .Remove(), .Sort(), .Reverse(), .Contains(), .Count(), 
//Loopa ut listan direkt på objektet
namesTwo.ForEach(name => { });

//.Contains() returnerar true om objektet finns i listan eller false
bool exists = namesTwo.Contains("a");
Console.WriteLine($"Namnet existerar: {exists}");

//Kontrollerar om listan innehåller några element alls. 
bool existsTwo = names.Any();

Console.WriteLine($"Listan har objekt: {existsTwo}");

/*Man kan definiera vad det är man letar efter likt .Contains(), men kan göras mer avancerat exempelvis med ett mer komplext objekt
eller klass med många properties se exempel nedan (namnet måste vara samma på båda sidor om =>:
I beskrivningen står det 1 overload, detta betyder det finns fler sätt att använda Any: Func<string, bool> predicate, man kan specificera upp hur man vill söka efter objekt (ett condition)*/
bool existsThree = names.Any(name => name == "a");
bool existsThree = names.Any(customer => customer.FirstName == "a");


bool existsFour = names.Any(customer => customer.FirstName == "a");

//IENUEMRABLE:
/*Endast en läsbar lista (går inte att göra Add eller Remove etc). Används ofta när man hämtar ut något från en databas. Databasen är en lista i sig själv, 
 * där vi lagrar ned olika värden  */
IEnumerable<string> names = new List<string>();

/*Kan säga att IEnumerablen är likadan med names-listan. Flytta en lista till en annan lista. Men det går inte att
ex göra Add, Remove, det blir rött. IEnmberable används bland annat när man hämtar en lista från en databas, för att förhindra
oavsiktliga ändringar som skapar en diff mot listan som är sparad i databasen*/
IEnumerable<string> customerList = names;

customerList.Add("b");

//ANDRA TYPER AV LISTOR:
/*enums - statisk lista
IObservableCollection (grafiska applikationer*/

//------------------------------------------------------------------------------------------------------------//
//VILLKORSSTYRNING:
/*ÖVRIGA OPERATORER: 
 ?? (Null coalescing operator) - Om det är ett null-värde vi får välj det andra värdet*/

//TERNARY OPERATORS:
bool isEnabled = false;

//De tre prickarna betyder att uttrycket kan förändras, tryck ctrl + . för att förenkla
bool result = isEnabled
? true
: false;

Console.WriteLine(result);

/*Förenklat :
 bool result = isEnabled*/

// git add. git commit git push

//--------------------------------------------------------------------------------------------------------------//
//LOOPAR:

string[] namesAgain = ["Joakim", "Anders", "Simon"];
for(int i = 0; i < namesAgain.Length; i++)
{
    string name = namesAgain[i];
    Console.WriteLine(name);
}

//Det finns en inbyggd foreach-loop i listor som ser ut såhär: 
List<string> namesList = ["Joakim", "Anders", "Simon"];
 
namesList.ForEach(name =>
{
    Console.WriteLine(name);
});

//Istället för:
foreach (string name in names)
{
    Console.WriteLine(name);
}

