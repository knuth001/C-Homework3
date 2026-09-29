//დავალება 1

int movieLimit = 16;

Console.WriteLine("sheiyvane sheni asaki");
int viewerAge = int.Parse(Console.ReadLine());
bool hasPermission = false;

if (viewerAge < 0 || viewerAge > 120)
{
    Console.WriteLine("ararealuri asaki");
}
else if (viewerAge >= movieLimit) {
    Console.WriteLine("shesvla nebadartulia");
}else  if (viewerAge >= 12 && viewerAge <15 && hasPermission)
{
    Console.WriteLine("shesvla shegidzlia mshobeltan ertad");
}
else
{
    Console.WriteLine("am filmze shesvla akrdzalulia!");
}

//დავალება 2

string dayName = "orshabati";

switch (dayName)
{
    case "orshabati":
    case "otxshabati":
    case "paraskevi":{ 
         Console.WriteLine("dges gaqvs C# leqcia");
        }
        break;

    case "samshabati":
    case "xutshabati":
        {
            Console.WriteLine("dges gaqvs damoukidebeli samushao");
        }
        break;

    case "shabati":
    case "kvira":
        {
            Console.WriteLine("dges dasvenebis dgea");
        }
        break;
}

//დავალება 3

Console.WriteLine("sheiyvane pirveli ricxvi");
double numberA = double.Parse(Console.ReadLine());

Console.WriteLine("sheiyvane meore ricxvi");
double numberB = double.Parse(Console.ReadLine());

double nashti = numberA % numberB;

if (nashti == 0)
{
    Console.WriteLine("ricxvi iyofa unashtod");
}
else
{
    if (nashti % 2 == 0)
    {
        Console.WriteLine("nashti aris kenti");
    }
    else
    {
        Console.WriteLine("nashti aris kenti");
    }
}

//დავალება 4 

int batteryLevel = 0;
bool isPluggedIn = false;

Console.WriteLine("sheiyvane sheni saxeli");
string username  = Console.ReadLine();

if(batteryLevel < 0 || batteryLevel > 100)
{
    Console.WriteLine("elementis ararealuri machvenebeli!");
}else if(batteryLevel == 100 && isPluggedIn)
{
    Console.WriteLine($"{username} batarea savsea,gamortet damteni");
}else if(batteryLevel >= 20 && !isPluggedIn)
{
    Console.WriteLine($"{username} telefoni jdeba,saswrafod sheaertet damteni");
}
else
{
    Console.WriteLine("elementis statusi normaluria");
}

//დავალება 5 

double amountGEL = 100; 
string currency = "USD";

switch (currency)
{
    case "USD":
        Console.WriteLine($"{amountGEL} GEL = {amountGEL / 2.7} USD");
        break;

    case "EUR":
        Console.WriteLine($"{amountGEL} GEL = {amountGEL / 3.0} EUR");
        break;

    case "გაპიასტრება":
        Console.WriteLine($"{amountGEL} GEL = {amountGEL * 100} ხურდა");
        break;

    default:
        Console.WriteLine("მოცემული ვალუტა არ არის მხარდაჭერილი!");
        break;
}
    