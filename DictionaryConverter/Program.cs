using DictionaryConverter;
using DictionaryConverter.DictionaryProcessors;
using DictionaryConverter.Interfaces;

Console.WriteLine("Pick dictionary input from:");
Console.WriteLine("1. Sjp.pl");
Console.Write("Dictionary: ");
var choice = Console.ReadLine();

Console.Write("Input dictionary Path: ");
var inputFilePath = Console.ReadLine();

Console.Write("Output path: ");
var outputFilePath = Console.ReadLine();

IDictionaryProcessor processor;
var converter = new StrategyContext();
switch (choice)
{
    case "1":
        processor = new SjpDictionaryProcessor();
        break;
    default:
        Console.WriteLine("No processor picked.");
        throw new NotImplementedException("No processor picked.");
}

converter.SetProcessor(processor);
converter.ConvertDictionary(inputFilePath, outputFilePath);

Console.WriteLine("File processed and saved at: " + outputFilePath);