using LanguageMastery.WcTool.Helpers;

namespace LanguageMastery.WcTool;

public static class Parser
{
    public static void CommandParser(char command, string fileName)
    {
        var allBytes = LanguageService.GetTotalBytes(fileName);
        var numberOfLines = LanguageService.GetNumberOfLines(fileName);
        var wordCount = LanguageService.GetWordCount(fileName);
        var characterCount = LanguageService.GetCharacterCount(fileName);
        var res = command switch
        {
            'c' => new {Count = $"{allBytes} {fileName}", Operation = "Byte Count"},
            'l' => new {Count = $"{numberOfLines}  {fileName}", Operation = "Lines Count"},
            'w' =>new {Count = $"{wordCount} {fileName}", Operation = "Word Count"},
            'm' => new {Count = $"{characterCount} {fileName}", Operation = "Character Count"},
            _ => new {Count = $"{allBytes} {numberOfLines} {wordCount} {fileName}", Operation = "Count"} 
        };

        Console.WriteLine(res.Count);
    }
}