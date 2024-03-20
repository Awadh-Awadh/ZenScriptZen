using System.Text;

namespace LanguageMastery.WcTool.Helpers;

public  class LanguageService
{
    // add static methods to read the file.

    public static string GetTotalBytes(string inputFile)
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), inputFile);

        return File.ReadAllBytes(path).Length.ToString();
    }

    public static string GetNumberOfLines(string inputFile)
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), inputFile);
        
        return (File.ReadAllLines(path)).Length.ToString();
    }

    public static string GetWordCount(string inputFile)
    {
        var count = 0;
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), inputFile);
        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                var wordCountPerLine = line.Trim().Split(" ").Length;
                count += wordCountPerLine;
            }

        }

        return count.ToString();
    }

    public static string GetCharacterCount(string inputFile)
    {
        var stream = ParseFileName(inputFile);
        using var reader = new StreamReader(stream);
        
        return reader.ReadToEnd().Length.ToString();
    }
    private static FileStream ParseFileName(string inputFile)
    {
        var file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), inputFile);
        
        return File.OpenRead(file);
        
    }
    
}