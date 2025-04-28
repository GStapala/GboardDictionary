using DictionaryConverter.Interfaces;

namespace DictionaryConverter;

public class StrategyContext()
{
    private IDictionaryProcessor _processor;

    public void SetProcessor(IDictionaryProcessor processor) => 
        _processor = processor;

    public void ConvertDictionary(string inputFilePath, string outputFilePath) => 
        _processor.ProcessDictionary(inputFilePath, outputFilePath);
}