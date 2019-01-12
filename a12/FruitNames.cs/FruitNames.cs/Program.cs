using System;
using System.Globalization;
using System.IO;
class FruitNames
{
    static void Main()
    {
        StreamReader sr = new StreamReader("fruits.txt");
        StreamWriter sw = new StreamWriter("fruits2.txt");

        string line = sr.ReadLine();
        string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(line.ToLower());


        char cutter = ',';
        string[] splitter = titleCase.Split(cutter);

        Array.Sort(splitter);
        var substring = string.Join(",", splitter);

        sw.WriteLine(substring);

        sr.Close();
        sw.Close();
        Console.ReadKey();

    }
}
