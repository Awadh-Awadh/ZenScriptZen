using CommandLine;

namespace LanguageMastery.WcTool.CommandLine;

public class CommandLineOptions
{
    [Value(index: 1, Required = false, HelpText = "Input file. Text.txt")]
    public string? InputFile { get; set; }
    
}