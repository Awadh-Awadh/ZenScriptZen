// See https://aka.ms/new-console-template for more information

using LanguageMastery.WcTool;
using LanguageMastery.WcTool.CommandLine;
using Parser = CommandLine.Parser;


// we should be able have a text file as an input.
// command -c text file --> should display the total bytes
// command -l text file ---> Should display the total number of line
// command -w text file ---> Should display the word count
// command -m text file ---> should display the character count
// with no command text file ---> Default should be result of -c, -l , -w

//var commands = Parser.Default.ParseArguments<CommandLineOptions>(args);
//string command = args[0][1..];
//var inputFile = args[1];

//Console.WriteLine(command);
//Console.WriteLine(inputFile);

LanguageMastery.WcTool.Parser.CommandParser('c', "test.txt");
