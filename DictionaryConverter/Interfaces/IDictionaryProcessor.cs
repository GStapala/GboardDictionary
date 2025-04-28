namespace DictionaryConverter.Interfaces;

public interface IDictionaryProcessor
{
    Task ProcessDictionary(string inputFilePath, string outputFilePath);
}