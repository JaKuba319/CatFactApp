namespace CatFactApp.Services
{
    public interface IFileService
    {
        Task Write(string path, string content);
    }
}