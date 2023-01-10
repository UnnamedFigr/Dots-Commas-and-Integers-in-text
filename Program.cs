using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file name:");
        string fileName = Console.ReadLine();
        string minimumLetters = "";

        using (StreamReader reader = new StreamReader($"{fileName}.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                minimumLetters += new string(line.Distinct().ToArray());
            }
        }

        Console.WriteLine(minimumLetters);
    }
}