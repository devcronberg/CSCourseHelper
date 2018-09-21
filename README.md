# CSCourseHelper

- Projekt til brug i Grundlæggende C# kurser
- HUSK 'using MCronberg'

## Eksempler

```csharp

static void RandomExTest()
{
    int v = RandomEx.RandomInt(1, 10);  // 1 and 10 included
    bool b = RandomEx.RandomBool();
    int d = RandomEx.RandomDice();
}

static void ToStringTest()
{
    int i = 2;
    System.Console.WriteLine(i.ToStringEx());
    System.Console.WriteLine(i.ToStringEx(showFields: true,
        showProperties: true,
        showMethods: true));
}

static void ConsoleExTest()
{

    // remember 'using MCronberg'

    // Clear console
    ConsoleEx.Clear();

    // Write without CRLF
    ConsoleEx.Write("*");
    ConsoleEx.Write("*");

    // Write with CRLF
    ConsoleEx.WriteLine();
    ConsoleEx.WriteLine("**");

    // Write many strings on same line (params)
    ConsoleEx.WriteLine("1", "2", "3", "4");

    // Write many strings on the same line (array)
    ConsoleEx.WriteLine(new string[] { "1", "2", "3", "4" });

    // Header

    // ========
    //  Header 
    // ========
    ConsoleEx.Header("Header");

    // Clear and Header
    ConsoleEx.Header("Header", true);

    // Header with * instead of =
    ConsoleEx.Header("Header", false, '*');

    // Read
    string s = ConsoleEx.ReadString();
    s = ConsoleEx.ReadString("Input ...");
    s = ConsoleEx.ReadString("Input ...", "default value");
    s = ConsoleEx.ReadString("Input ...", "default value", showDefaultValue: true);

    int i = ConsoleEx.ReadInt();                    // and overloads
    double d = ConsoleEx.ReadDouble();              // and overloads
    System.DateTime dt = ConsoleEx.ReadDate();      // and overloads

    // Generates a simple menu
    int menu = ConsoleEx.ReadMenu("item 1", "item 2", "item 3");
    /*
    1 item 1
    2 item 2
    3 item 3

    Enter menu # (1-3):
        */


```
