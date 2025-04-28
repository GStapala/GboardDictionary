using System.Text;
using DictionaryConverter.Interfaces;

namespace DictionaryConverter.DictionaryProcessors;

public class SjpDictionaryProcessor : IDictionaryProcessor
{
    public async Task ProcessDictionary(string inputFilePath, string outputFilePath)
    {
        var lines = await File.ReadAllLinesAsync(inputFilePath);
        var outputContent = new StringBuilder();
        
        outputContent.Append("# Gboard Dictionary version:1\n\n# From OS\n");
        
        foreach (var line in lines)
        {
            outputContent.Append("\t" + line + "\tpl\n");
        }
        
        await File.WriteAllTextAsync(outputFilePath, outputContent.ToString(), new UTF8Encoding(false));
    }
}