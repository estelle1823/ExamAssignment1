namespace Infrastructure1.Interfaces;

public interface IFileService
{
    bool SaveJsonContentToFile(string jsonContent);
    string GetJsonContentFromFile();



}
