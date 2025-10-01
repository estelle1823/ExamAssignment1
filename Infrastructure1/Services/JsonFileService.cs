
using Infrastructure1.Interfaces;
using System.Runtime.CompilerServices;

namespace Infrastructure1.Services;

public class JsonFileService(string filePath) : IFileService
{
    private readonly string _filePath; = filePath;

    public JsonFileService(string filePath)
    {
        _filePath = filePath;
    }

    public string GetJsonContentFromFile()
    {
        throw new NotImplementedException();
    }

    public bool SaveJsonContentToFile(string jsonContent)
    {
        throw new NotImplementedException();
    }
}

